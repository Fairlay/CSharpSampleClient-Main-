﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairlaySampleClient
{



    public class UserOrder
    {
        public int BidOrAsk;
        public long MarketID;
        public int RunnerID;
        public long OrderID;
        public string MatchedSubUser;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(BidOrAsk + " ");
            sb.Append(MarketID + " ");
            sb.Append(RunnerID + "-");

            return sb.ToString();
        }

    }

    public class ReturnMOrder
    {
        public UserOrder _UserOrder;
        public MatchedOrder _MatchedOrder;
        public long _UserUMOrderID;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_UserOrder + " ");
            sb.Append(_MatchedOrder + "");

            return sb.ToString();
        }
    }

    public class ReturnUOrder
    {
        public UserOrder _UserOrder;
        public UnmatchedOrder _UnmatchedOrder;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_UserOrder + " ");
            sb.Append(_UnmatchedOrder + "");

            return sb.ToString();
        }

    }




    public class MUserTransfer 
    {     

        public long ID2;
        public int FromU;
        public int ToU;
        public string Descr;
        public string Email;
        public int TType;
        public decimal Amount;
        public DateTime ExcludedCreationTime
        {
            get
            {
                return new DateTime(2015, 1, 1).AddMilliseconds(ID2);
            }
            set
            {

            }
        }

    }

    public class MUserStatement
    {
        public MUserStatement(decimal am, decimal bank,  string descr, int ttype)
        {
            Descr = descr;
           
            Bank = bank;
            T = ttype;
            Am = am;
        }


        public long ID;
        public string Descr;
        public int T;
        public decimal Am;
        public decimal Bank;
        public DateTime ExcludedCreationTime
        {
            get
            {
                return new DateTime(2016, 1, 1).AddMilliseconds(ID);
            }
            set
            {

            }
        }

    }

 }