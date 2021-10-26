using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Crono
    {
      private static int codigo;
      private static int  codigoUcFK;
      private static int  codigoTurmaFK;
      private static int  codigoSalaFK;
      private static int  codigoProfFK;
      private static DateTime  dataAula;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static int CodigoUcFK { get => codigoUcFK; set => codigoUcFK = value; }
        public static int CodigoTurmaFK { get => codigoTurmaFK; set => codigoTurmaFK = value; }
        public static int CodigoSalaFK { get => codigoSalaFK; set => codigoSalaFK = value; }
        public static int CodigoProfFK { get => codigoProfFK; set => codigoProfFK = value; }
        public static DateTime DataAula { get => dataAula; set => dataAula = value; }
    }
}
