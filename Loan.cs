using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Loan
    {
        protected string Name;
        protected string LoanNum;
        protected int Amount;

        public Loan(string Name,string LoanNum,int Amount)
        {
            this.Name = Name;
            this.LoanNum = LoanNum;
            this.Amount = Amount;
        }
        public override string ToString()
        {
            return string.Format("Name of loan is {0} \n Num of loan is {1} \n Amount of loan is {2}", Name, LoanNum, Amount);
        }
    }
}
