using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Account
    {
        int id, type;
        string name;


        public Account(int id, int type, string name)
        {
            this.id = id;
            this.type = type;
            this.name = name;
        }
        public override string ToString()
        {
            string account_type;
            if (type == 0)
            {
                account_type = "Secretary";
            }
            else if (type == 1)
            {
                account_type = "Doctor" ;
            }
            else
            {
                account_type = "Patient";
            }
            return account_type + ":" + id.ToString() + ":" + name;
        }

        public int getId()
        {
            return id;
        }
    }
}
