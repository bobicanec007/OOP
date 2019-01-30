using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korisnici
{
    class StudentMeva : Student
    {
        private string fakultet = "MEV";

        public new string PredstaviSe()
        {
            return String.Format("Ja sam student {0}, {1} godine studija {2}, zaporka mi je {3}",
                korisnickoIme,godinaStudija,fakultet, zaporka);
        }
    }
}
