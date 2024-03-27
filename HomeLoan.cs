using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class HomeLoan:Loan
    {
        private string HomeNum;
        private string HomeAddress;

        public HomeLoan(string Name, string LoanNum, int Amount, string HomeNum, string HomeAddress):base(Name,LoanNum,Amount)
        {
            this.HomeNum = HomeNum;
            this.HomeAddress = HomeAddress;
        }
        public override string ToString()
        {
            return string.Format("Name of loan is {0} \n Num of loan is {1} \n Amount of loan is {2} \n Home Num is {3} \n Home address is {4} ", Name,LoanNum,Amount,HomeNum,HomeAddress);
        }
    }
}
