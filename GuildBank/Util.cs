using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

class Util
{
    public static long LINUXTIMEOFFSET
    {
        get { return 62135596800000; }
    }

    public static object DeserializeXML(string filePath, Type type)
    {
        //TODO: Need to implement error handling to make sure that invalid XMLs are handled properly.
        System.IO.StreamReader str = new System.IO.StreamReader(filePath);
        System.Xml.Serialization.XmlSerializer xSerializer = new System.Xml.Serialization.XmlSerializer(type);
        object res = (object)xSerializer.Deserialize(str);
        str.Close();

        return res;
    }

    public static void SerializeXML(string filePath, object res, Type type)
    {
        try
        {
            //TEST FOR WRITER
            System.IO.StreamWriter strOut = new System.IO.StreamWriter(filePath);
            System.Xml.Serialization.XmlSerializer xSerializerOut = new System.Xml.Serialization.XmlSerializer(type);
            xSerializerOut.Serialize(strOut, res);

            strOut.Close();
        }
        catch( Exception e)
        {
            System.Windows.Forms.MessageBox.Show("The selected XML is in a invalid XML format. \n\nMake sure you select the correct one and try again", "Error parsing the file!", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }

    /// <summary>
    /// Gets all the cache files from a directory of XML files.
    /// </summary>
    /// <param name="path">Path to the cache</param>
    /// <param name="type">Type of object to deserialize</param>
    /// <param name="extension">Extension of the files to cache</param>
    /// <returns>List of objects to be handled by the client</returns>
    public static List<object> GetCache(string path, Type type, string extension)
    {
        List<object> objList = new List<object>();
        
        if(System.IO.Directory.Exists("cache\\"))
        {
            string[] strArray = System.IO.Directory.GetFiles(path);
            

            foreach (string str in strArray)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(str);
                if (fi.Extension == extension)
                    objList.Add((object)Util.DeserializeXML(str, type));

            }
        }



        return objList;
    }

    public static wowhead GetItemFromWeb(int itemId)
    {
        wowhead res = null;

        try
        {
            String URLString = "http://www.wowhead.com/?item=";
            URLString += itemId.ToString() + "&xml";
            XmlTextReader reader = new XmlTextReader(URLString);
            System.Xml.Serialization.XmlSerializer xSerializer = new System.Xml.Serialization.XmlSerializer(typeof(wowhead));
            res = (wowhead)xSerializer.Deserialize(reader);

            //Set default weight
            res.Items.SetDefaultWeight();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            res = null;
        }

        
        return res;
    }
}
