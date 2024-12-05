using System;
using System.Xml;
using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;

//Declare a namspace in which the class will be srored
namespace CLRStoredProcedure
{
    //Declare a class name XMLProc to define the functionality
    public class XMLProc
    {
        // Marks that the code will be used as a stored procedure 
        [Microsoft.SqlServer.Server.SqlProcedure]

        //Define the function that provides functionality
        public static void SaveXML(SqlXml XmlData, SqlString FileName)
        {
            SqlPipe pipe = SqlContext.Pipe;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(XmlData.Value);
            xmlDoc.Save(FileName.Value);
            pipe.Send("Data saved in an XML file");
        }
    }
}
