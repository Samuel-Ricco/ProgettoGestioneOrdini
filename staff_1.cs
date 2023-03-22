using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGruppo2
{
    public partial class staff
    {
        public string full_name { get => $"{first_name} {last_name}"; }
    }
}
