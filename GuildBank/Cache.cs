using System;
using System.Collections.Generic;
using System.Text;


public class Cache
{

    string cachePath;

    //Cache dictionaries
    Dictionary<int, wowhead> itemDic;


    public Cache()
    {
        cachePath = "cache";
        itemDic = new Dictionary<int, wowhead>();
    }

    public void Populate()
    {
        //Get the items.
        List<object> objList = Util.GetCache(cachePath + "\\" + "items", typeof(wowhead), ".xml");
        foreach (object obj in objList)
        {
            wowhead t = obj as wowhead;
            itemDic.Add(t.Items.id, t);
            
        }
    }

    public string CachePath
    {
        get { return cachePath; }
    }

    public bool Add(object obj)
    {
        if (obj.GetType() == typeof(wowhead))
        {
            wowhead wh = (wowhead)obj;
            itemDic.Add(wh.Items.id, wh);

            return true;
        }

        return false;
    }

    public object ItemFromWeb(int itemId, Type type)
    {
        /*
         * HTTP Parsing?
         */
        object res = Util.GetItemFromWeb(itemId);
        if (res != null)
            Util.SerializeXML(cachePath + "\\" + "items" + "\\" + itemId.ToString() + ".xml", res, type);

        //Add to existing cache
        wowhead wh = (wowhead)res;
        itemDic.Add(wh.Items.id, wh);

        return res;
    }

    //public TValue this [int index
    public wowhead this[int key]
    {
        get
        {
            return itemDic[key];
        }
    }

    public string this[string i]
    {
        get { return i; }
    }

    public Dictionary<int, wowhead> Items
    {
        get { return itemDic; }
    }

}
