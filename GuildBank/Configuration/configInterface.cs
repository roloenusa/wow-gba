/*
 * Created by: Juan Delgado
 * Purpose: Outsources the configuration interface for this component
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class configurations
{
    //Resource Path
    string resourcePath = "resources";

    GroupBox groupBoxCacheSettings;
    Label[] labelProperties;
    TextBox[] textBoxProperties;
    //Button[] buttonAcceptCancel;

    //
    //Getters and setters
    //
    public string CachePath
    {
        get { return "cache"; }
    }
    public string CacheItemPath
    {
        get { return CachePath + "\\" + "items\\"; }
    }

    public configurationsProperty[] Properties
    {
        get { return itemsField; }
    }

    public bool configurationsInit()
    {
        //Verify everything is configured.
        int i = 0;
        for (i = 0; i < this.Properties.Length; i++)
        {
            if (this.Properties[i].configured == false)
                break;
        }



        //For now, we just create the cache folders
        if(!System.IO.Directory.Exists("cache"))
            System.IO.Directory.CreateDirectory("cache");
        if(!System.IO.Directory.Exists("cache\\items"))
            System.IO.Directory.CreateDirectory("cache\\items");

        return i < this.Properties.Length ? false : true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Form"></param>
    /// <returns></returns>
    public void configurationInterface(Control control)
    {
        int i = 0; //sentinel value
        System.Drawing.Point location = new System.Drawing.Point(20, 20);

        //
        //GroupBox
        //
        this.groupBoxCacheSettings = new GroupBox();
        this.groupBoxCacheSettings.Location = new System.Drawing.Point(100, 100);
        this.groupBoxCacheSettings.Name = "groupBoxCacheSettings";
        this.groupBoxCacheSettings.Text = "Cache Settings";
        this.groupBoxCacheSettings.AutoSize = true;
        this.groupBoxCacheSettings.Dock = DockStyle.Fill;
        //this.groupBoxCacheSettings.Size = new System.Drawing.Size(500, 100);
        //this.groupBoxCacheSettings.TabIndex = 16;
        
        //
        //Labels
        //
        labelProperties = new Label[Properties.Length];
        for (i = 0; i < Properties.Length; i++)
        {
            labelProperties[i] = new Label();
            labelProperties[i].Text = Properties[i].name;
            labelProperties[i].Location = location;

            location.Y += 40;
        }
        this.groupBoxCacheSettings.Controls.AddRange(labelProperties);

        //
        //Text boxes
        //
        location = new System.Drawing.Point(150, 20);
        textBoxProperties = new TextBox[Properties.Length];
        for (i = 0; i < Properties.Length; i++)
        {
            textBoxProperties[i] = new TextBox();
            textBoxProperties[i].Text = Properties[i].location;
            textBoxProperties[i].Location = location;

            location.Y += 40;
        }
        this.groupBoxCacheSettings.Controls.AddRange(textBoxProperties);



        //
        //Attach controls
        //
        //control.Controls.Clear();
        control.Controls.Add(this.groupBoxCacheSettings);
        //control.Controls.AddRange(labelProperties);
    }

    //public TValue this [int index
    public configurationsProperty this [string key]
    {
        get{
            int i = 0;
            for(i = 0; i < itemsField.Length; i++)
            {
                if (itemsField[i].name == key)
                    break;
            }

            return itemsField[i];
        }
    }
    
}

