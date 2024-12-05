using System;
using System.Data;
using System.Data.Sql;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using System.Text.RegularExpressions;
using System.Transactions;

public class trgMail
{
    [SqlTrigger(Name = @"EmailAudit", Target = "[dbo].[Users]", Event 
    = "FOR INSERT")] 
// Specifies that the code will be used as a SQL Trigger
    
public static void MailValid()
     {
        string userName;
        string realName;
        SqlCommand command;
        SqlTriggerContext triggContext = SqlContext.TriggerContext;
        SqlPipe pipe = SqlContext.Pipe;
        SqlDataReader reader;
        switch (triggContext.TriggerAction)
        {
            case TriggerAction.Insert:
            using (SqlConnection connection
            = new SqlConnection(@"context connection=true"))
                {
                   connection.Open();// Opens the SQL Connection
command = new SqlCommand(@"SELECT * FROM INSERTED;", connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    userName = (string)reader[0];
                    realName = (string)reader[1];
                    reader.Close();
                    if (IsValidEMailAddress(userName))
                    {
                        command = new SqlCommand(
                           @"INSERT [dbo].[UserNameAudit] VALUES ('"
                           + userName + @"', '" + realName + @"');",
                           connection); 
                        pipe.Send(command.CommandText);
                        command.ExecuteNonQuery();
                        pipe.Send("You inserted: " + userName);
                    }
                  else
                    {
                        try
                        {
                            pipe.Send("Invalid EmailID");
                            Transaction trans = Transaction.Current;
                            trans.Rollback();

                        }
                        catch (SqlException ex)
                        {
                            
                        } 
                    }
                }
                break;
        }
    }
    public static bool IsValidEMailAddress(string email)
    {
        return Regex.IsMatch(email, @"^([\w-]+\.)*?[\w-]+
        @[\w-]+\.([\w-]+\.)*?[\w]+$");
    }
}
