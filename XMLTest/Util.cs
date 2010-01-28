using System;
using System.Collections.Generic;
using System.Text;

namespace XMLTest
{
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
            System.IO.StreamWriter strOut = new System.IO.StreamWriter("Test.xml");
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
        public List<object> GetCache(string path, Type type, string extension)
        {
            string[] strArray = System.IO.Directory.GetFiles(path);
            List<object> objList = new List<object>();

            foreach (string str in strArray)
            {
                System.IO.FileInfo fi = new FileInfo(str);
                if (fi.Extension == extension)
                    objList.Add((object)Util.DeserializeXML(path, type));

            }

            return objList;
        }
    }
}
