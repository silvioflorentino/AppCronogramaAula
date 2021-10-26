using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Aluno
    {
        private static int codigo;
        private static string nomeAluno;
        private static string emailAluno;
        private static string foneAluno;
        private static string retorno;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeAluno { get => nomeAluno; set => nomeAluno = value; }
        public static string EmailAluno { get => emailAluno; set => emailAluno = value; }
        public static string FoneAluno { get => foneAluno; set => foneAluno = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }

}
