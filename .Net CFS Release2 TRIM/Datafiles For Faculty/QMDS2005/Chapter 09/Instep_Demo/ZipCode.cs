using System;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO;

[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.UserDefined, MaxByteSize = 8000)] // Specifying that the code will be used as User-Defined data type.
public struct ZipCode : IBinarySerialize, INullable // Implementing the required interface
{
    private string zip_code; //Declaring the private members
    private bool isNull; //Declaring the private members

    public bool IsNull //The IsNull property of the INullable    interface
    {
        get
        {
            return this.isNull; // Return that the data is NULL
        }
    }
    public static ZipCode Null // the ZipCode property
    {
        get
        {
            ZipCode sd = new ZipCode();
            sd.isNull = true;
            return sd;
        }
    }
    public ZipCode(string s) // The constructor of the structure 
    {
        isNull = false;
        zip_code = s;        
    }

    public static ZipCode Parse(SqlString s) // The parser
    {
        string value = s.Value;
        if (s.IsNull || value.Trim() == "") return Null;
        string zip = value;
        return new ZipCode(zip);
    }
    public override String ToString() // Overriding the default ToString function
    {
        return zip_code;
    }
    public void Read(BinaryReader r) // Displaying the data to the    user
    {
        zip_code = r.ReadString();
    }
    public void Write(BinaryWriter w) // Inserting the data in the     table
    {
        if (zip_code == "CA")
        {
            w.Write("State : California");
        }
        else if (zip_code == "NY")
        {
            w.Write("State : New York");
        }
        else
        {
            w.Write("State : Invailid, " + zip_code);
        }
    }
}
