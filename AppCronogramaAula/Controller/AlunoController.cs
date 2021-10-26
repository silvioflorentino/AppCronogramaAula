using System.Data;
using System.Data.SqlClient;
using AppCronogramaAula.Model;
using System.Windows.Forms;


namespace AppCronogramaAula.Controller
{
    class AlunoController
    {
   
        public void cadastroAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirAluno",conexao);
            comando.CommandType = CommandType.StoredProcedure;


            try
            {
                MessageBox.Show(Aluno.NomeAluno + Aluno.EmailAluno + Aluno.FoneAluno);
                comando.Parameters.AddWithValue("@nome",Aluno.NomeAluno );
                comando.Parameters.AddWithValue("@email", Aluno.EmailAluno);
                comando.Parameters.AddWithValue("@telefone", Aluno.FoneAluno);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Aluno cadastrado com sucesso. ," +
                    "Deseja cadastrar outro Aluno?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Aluno.Retorno = "False";
                    return;
                }
                else
                {
                    Aluno.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Aluno não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }


        }
        /*
        public void visuCodigoAluno()
        {
            if (tbCodigoFun.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção");
                tbCodigoFun.Focus();
                return;
            }

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoFuncionario", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoFun.Text);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    tbNomeFun.Text = tabelaDados["Nome"].ToString();
                    tbEmailFun.Text = tabelaDados["Email"].ToString();
                    tbChapaFun.Text = tabelaDados["Chapa"].ToString();

                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    tbNomeFun.Clear();
                    tbEmailFun.Clear();
                    tbChapaFun.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void alterarAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarFuncionario", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoFun.Text);
                comandos.Parameters.AddWithValue("@nome", tbNomeFun.Text);
                comandos.Parameters.AddWithValue("@email", tbEmailFun.Text);
                comandos.Parameters.AddWithValue("@chapa", tbChapaFun.Text);

                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Funcionário Alterado com sucesso!");

            }
            catch
            {
                MessageBox.Show("Funcionário não alterado.");
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarFuncionario", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoFun.Text);
                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Funcionário Excluido com sucesso!");
                tbNomeFun.Clear();
                tbEmailFun.Clear();
                tbChapaFun.Clear();

            }
            catch
            {
                MessageBox.Show("Funcionário não Excluido.");
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }
        */
    }
}
