

namespace AppCronogramaAula.Model

{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\silvio.wflorentino\source\repos\silvioflorentino\AppCronogramaAula\AppCronogramaAula\bdcronograma_aula.mdf;Integrated Security=True";
        }
    }
}
