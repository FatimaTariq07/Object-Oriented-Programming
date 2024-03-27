using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class AutoLoan : Loan
    {
        private string AutoNum;
        private string AutoCompany;

        public AutoLoan(string Name, string LoanNum, int Amount, string AutoNum, string AutoCompany)
            : base(Name, LoanNum, Amount)
        {
            this.AutoNum = AutoNum;
            this.AutoCompany = AutoCompany;
        }
        public override string ToString()
        {
            return string.Format("Name of loan is {0} \n Num of loan is {1} \n Amount of loan is {2} \n Auto Num is {3} \n Auto company is {4} ", Name, LoanNum, Amount, AutoNum, AutoCompany);
        }
    }
}
