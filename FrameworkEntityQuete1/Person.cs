using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEntityQuete1
{
    class Person
    {
        public Guid PersonId { get; set; }
        public string PersonName { get; set; }
        public List<SavingAccount> SaList { get; set; }
    }
}
