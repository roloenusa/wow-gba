using System;
using System.Collections.Generic;
using System.Text;

namespace XMLTest
{
    enum TransactionType
    {
        DepositItem = 1,
        WithdrawItem = 2, 
        Move = 3, 
        DepositMoney = 4, 
        WithdrawMoney = 5,
        Repair = 6
    }

    enum TransactionFlags
    {
        ExcessWithdraw,
        UnevenWithdraw,
        UnscheduledRepair,
        MoneyWithdraw

    }


    public class PlayerTransactions
    {
        const long LINUXTIMEOFFSET = 62135596800000;

        string player;
        int numberOfTransactions;
        long lastTransaction;

        //Detailed Data
        int wMoney;
        int dMoney;
        int rMoney;
        int wItem;
        int dItem;

        double karma;

        int flagmarker;
        TransactionFlags[] flag;
        pageGuildInfoGuildBankBanklogsBanklog[] flaggedTransaction;

        SortedList<long, pageGuildInfoGuildBankBanklogsBanklog> bankLog;

        static private configurations configurations;
        static private List<wowhead> itemCache;

        #region Constructors

        public PlayerTransactions(string name)
        {
            //General Data
            player = name;
            numberOfTransactions = 0;
            lastTransaction = 0;

            //Detailed Data
            wMoney = 0;
            dMoney = 0;
            rMoney = 0;
            wItem = 0;
            dItem = 0;

            karma = 0;


            //Flags
            flagmarker = 0;
            flag = new TransactionFlags[5];
            flaggedTransaction = new pageGuildInfoGuildBankBanklogsBanklog[5];

            bankLog = new SortedList<long,pageGuildInfoGuildBankBanklogsBanklog>();

        }

        #endregion

        #region Getters and Setters

        static public configurations Configurations
        {
            get { return configurations; }
            set { configurations = value; }
        }

        static public List<wowhead> ItemCache
        {
            set { itemCache = value; }
        }

        public string Player
        {
            get { return player; }
        }

        public int NumberOfTransactions
        {
            get { return numberOfTransactions; }
        }

        public DateTime LastTransaction
        {
            get 
            {
            //    DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
            //    TimeSpan t = new TimeSpan(dt.Ticks);
            //    Console.WriteLine(t.TotalMilliseconds.ToString());

                TimeSpan ts = TimeSpan.FromMilliseconds(lastTransaction + LINUXTIMEOFFSET);
                return new DateTime(ts.Ticks);
            }
        }

        public int MoneyWithdrawls
        {
            get { return wMoney; }
        }

        public int MoneyDeposits
        {
            get { return dMoney; }
        }

        public int Repairs
        {
            get { return rMoney; }
        }

        public int MoneyOffset
        {
            get { return dMoney - wMoney - rMoney; }
        }

        public double Karma
        {
            get { return karma; }
        }

        #endregion


        #region Functions

        public bool AddTransaction(pageGuildInfoGuildBankBanklogsBanklog transaction)
        {
            //Double check that this is the right player.
            if (transaction.player != player)
                return false;

            //Update the values
            numberOfTransactions++;
            if(transaction.ts > lastTransaction)
                lastTransaction = transaction.ts;


            //Process the transaction
            switch (transaction.type)
            {
                case (int)TransactionType.DepositMoney:
                    dMoney += transaction.money;
                    break;

                case (int)TransactionType.WithdrawMoney:
                    wMoney += transaction.money;
                    break;

                case (int)TransactionType.DepositItem:
                    dItem++;
                    karma += getItemWeight(transaction.item[0].type, transaction.item[0].subtype, transaction.item[0].id); 
                    break;                

                case (int)TransactionType.WithdrawItem:
                    wItem++;
                    karma -= getItemWeight(transaction.item[0].type, transaction.item[0].subtype, transaction.item[0].id);
                    break;

                case (int)TransactionType.Repair:
                    rMoney += transaction.money;
                    break;

                case (int)TransactionType.Move:
                    break;
 
            }

            //Add to log
            //bankLog.Add(transaction.ts, transaction);

            return true;
        }

        private int getItemWeight(string type, string subtype, int id)
        {
            
            return 1;
        }

        #endregion

    }

    /*****
     * Karma Table of Equivalents
     * 
     * Herbs/Alch 1 Flask = 10 reagents = 15g
     * 
     * 
     ******/
}
