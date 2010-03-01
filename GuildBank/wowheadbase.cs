
public partial class wowhead {

    public override bool Equals(object obj)
    {
        wowhead wh = (wowhead)obj;
        if (this.itemsField.Equals(obj))
            return true;

        if (this.itemsField.id == wh.itemsField.id)
            return true;

        return base.Equals(obj);
    }
}
