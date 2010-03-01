
public partial class page {
    
}

public partial class TabInfo {

}

public partial class GuildInfo {

}

public partial class GuildHeader {
}

public partial class Emblem {

}

public partial class GuildMessages {
}

public partial class Rank {

}

public partial class GuildInfoGuildBank {
}

public partial class Bag {
}

public partial class Banklogs {

    public Banklogs()
    {
        this.banklog = new Banklog[0];
    }

    public void MergeBanklogs(Banklog[] b)
    {
        int i;

        System.Collections.Generic.List<Banklog> t = new System.Collections.Generic.List<Banklog>(this.banklog);
        if (!System.Object.ReferenceEquals(this, b))
        {
            for (i = 0; i < b.Length; i++)
            {
                if (!t.Contains(b[i]))
                    t.Add(b[i]);
            }
        }

        this.banklog = t.ToArray();
    }

}

public partial class Banklog {

    public override bool Equals(object obj)
    {

        bool r = false;
        Banklog t = (Banklog)obj;
        
        if (this.ts == t.ts &&
            this.player == t.player &&
            this.type == t.type &&
            this.money == t.money
            )
            r =  true;

        //System.Console.WriteLine("Banklog called for {0} == {1}. Returned {2}", this.ts, t.ts, r);

        return r;

        //return base.Equals(obj);
    }

}

public partial class BanklogItem {

    public override bool Equals(object obj)
    {
        BanklogItem t = (BanklogItem)obj;

        if (this.id == t.id)
            return true;

        return false;

        //return base.Equals(obj);
    }

}

public partial class NewDataSet {

}
