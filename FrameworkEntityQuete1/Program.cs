using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkEntityQuete1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var context = new SaContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var newPerson = new Person
                {
                    PersonName = "Bob"
                };

                newPerson.SaList = new List<SavingAccount>
                {
                    /*new SavingAccount (2000000, 0.6),  si j'ajoute le constructeur avec les 2 arguments je dois ajouter mes SavingAccount de cette façon*/
                    new SavingAccount { InitialAmount = 2000000.00 , SavingsRate = 0.6 },
                    new SavingAccount { InitialAmount = 250000.00 ,SavingsRate = 0.15 },
                    new SavingAccount { InitialAmount = 10000000.00, SavingsRate = 0.02 },
                };

                context.Add(newPerson);

                context.SaveChanges();

                double WinResult = SavingCalculator.CalculateTotalSaved(Convert.ToDateTime(02 - 02 - 2017), Convert.ToDateTime(03 - 03 - 2020), newPerson.SaList);

                MessageBox.Show("For this period you have earned a total of :" , Convert.ToString(WinResult),
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
