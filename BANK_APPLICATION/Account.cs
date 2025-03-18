using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest
{
    public enum AccType { Savings, Current }
    //public enum MinBalance { Savings = 1000, Current = 5000 }
    class Account
    {
        //Enum 

        //Data Member
        
        protected int _accNo;
        protected string _name;
        protected float _balance;
        protected float _amount;
        protected AccType _type;
        protected string _minBal;
        protected string _mobile_no;
        protected string _email_id;
        protected char _deleted;
        private int _acc_Deposit;
        private string _pan;

        //Default constructor
        public Account()
        {

        }

        //Parameterized Constructor


        public Account(int accNo, string name, string mobile_no, string Email_id, float balance )
        {
            this._accNo = accNo;
            this._name = name;
            this._email_id = Email_id;
            this._mobile_no = mobile_no;
            this._balance = balance;


        }
        public int AccNo
        {
            get
            {
                return _accNo;
            }
            set
            {
                _accNo = value;
            }
        }


        public float Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }



        public AccType AccType
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }


        public string  MinBal
        {
            get
            {
                return _minBal;
            }
            set
            {
                _minBal = value;
            }
        }




        public string Acc_Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Name");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public float Acc_Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid Amount");
                }
                else
                {
                    _amount = value;

                }
            }
        }

        public String Pan { get { return _pan; } set { _pan = value; } }
        public int Acc_Deposit { get{return _acc_Deposit; } set{ _acc_Deposit=value; } }
        public string Email_id
        {
            get { return _email_id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Mail_id");
                }
                else
                {
                    _email_id = value;
                }
            }
        }
        public string Mobile_No
        {
            get { return _mobile_no; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Mail_id");
                }
                else
                {
                    _mobile_no = value;
                }
            }
        }
        public char Delete { get; set; }

        public override string ToString()
        {
            return "Account_No:" + AccNo + "Acc_Name:" + Acc_Name + "Acc_type" + AccType + "Mobile_No:" + Mobile_No+"Min_Bal:"+MinBal+"Balance"+Balance;
        }
    }
}
