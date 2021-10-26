using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Uc
    {
        private static int codigo;
        private static string nomeUc;
        private static string descUc;
        private static int numAulasUc;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeUc { get => nomeUc; set => nomeUc = value; }
        public static string DescUc { get => descUc; set => descUc = value; }
        public static int NumAulasUc { get => numAulasUc; set => numAulasUc = value; }
    }
}
