using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEntityQuete1
{
    class SavingCalculator
    {
        public Person CurrentPerson { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public static double CalculateTotalSaved(DateTime begin, DateTime end, List<SavingAccount> saList)
        {
            double TotalWin = 0;

            int NbYearBetweenBeginAndEnd = Convert.ToInt32((end - begin).TotalDays / 365);

            foreach (SavingAccount CurrentSA in saList)
            {
                TotalWin = TotalWin + (CurrentSA.InitialAmount * CurrentSA.SavingsRate * NbYearBetweenBeginAndEnd);
            }
            return TotalWin;
        }
    }
}
