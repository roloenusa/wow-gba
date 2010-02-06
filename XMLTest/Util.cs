using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

class Util
{
    public static object DeserializeXML(string filePath, Type type)
    {
        System.IO.StreamReader str = new System.IO.StreamReader(filePath);
        System.Xml.Serialization.XmlSerializer xSerializer = new System.Xml.Serialization.XmlSerializer(type);
        object res = (object)xSerializer.Deserialize(str);
        str.Close();

        return res;
    }

    public static void SerializeXML(string filePath, object res, Type type)
    {
        //TEST FOR WRITER
        System.IO.StreamWriter strOut = new System.IO.StreamWriter(filePath);
        System.Xml.Serialization.XmlSerializer xSerializerOut = new System.Xml.Serialization.XmlSerializer(type);
        xSerializerOut.Serialize(strOut, res);

        strOut.Close();
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
        string[] strArray = System.IO.Directory.GetFiles(path);
        List<object> objList = new List<object>();

        foreach (string str in strArray)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(str);
            if (fi.Extension == extension)
                objList.Add((object)Util.DeserializeXML(str, type));

        }

        return objList;
    }

    public static object CacheItemFromWeb(int itemId)
    {
        /*
         * HTTP Parsing?
         */
        wowhead res = GetItemFromWeb(itemId);
        if(res != null) 
            Util.SerializeXML("cache\\" + itemId.ToString() + ".xml", res, typeof(wowhead));

        return res;
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
