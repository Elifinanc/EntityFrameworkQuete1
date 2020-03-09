using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEntityQuete1
{
    class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public double InitialAmount { get; set; }
        public double SavingsRate { get; set; } /*ce sont les taux d'épargne par an, sachant que le 1er est 5% par mois ça donne 6% par an!*/

        /* si je ne met pas le constructeur ci-dessous avec les 2 arguments, alors il prend le constructeur par défaut qui est public SavingAccount() 
        
        public SavingAccount(double initialAmount, double savingsRate)
        {
            InitialAmount = initialAmount;
            SavingsRate = savingsRate;
        }*/
    }
}
