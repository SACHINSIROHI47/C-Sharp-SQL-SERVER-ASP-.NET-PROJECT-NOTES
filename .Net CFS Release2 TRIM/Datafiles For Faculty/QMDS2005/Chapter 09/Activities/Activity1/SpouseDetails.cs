using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.UserDefined, MaxByteSize = 8000)] //* Specifying that the code will be used as User-Defined data type.*/
public struct SpouseDetails : IBinarySerialize, INullable 
// Implementing the required interface
{
    private string sp_name; //Declaring the private members
    private string sp_age; //Declaring the private members
    private bool isNull; //Declaring the private members

    public bool IsNull //The IsNull property of the INullable
    {
        get
        {
            return this.isNull;
        }
    }
    public static SpouseDetails Null //The static property 
    {
        get
        {
            SpouseDetails sd = new SpouseDetails();
            sd.isNull = true;
            return sd;
        }
    }
    public SpouseDetails(string s, string s1) // The constructor
    {
        isNull = false;
        sp_name = s;
        sp_age = s1;
    }

    public static SpouseDetails Parse(SqlString s) // The parser
    {
        string value = s.Value;
        if (s.IsNull || value.Trim() == "") return Null;
        string name = value.Substring(0, value.IndexOf(';'));
        string dob = value.Substring(value.IndexOf(';') + 1, 
        value.Length - name.Length - 1);
        return new SpouseDetails(name, dob);
    }

    public override String ToString() // The overridden ToString method
    {
        return sp_name;    
    }

    public void Read(BinaryReader r) // Displaying the data to the user on the SELECT query
    {
        sp_name = r.ReadString();
    }
    public void Write(BinaryWriter w)// *Inserting the data in the able*/
    {
      w.Write("Spouse Name : " + sp_name + "; Spouse Date of Birth:" 
      + sp_age + ".");
    }   
}
