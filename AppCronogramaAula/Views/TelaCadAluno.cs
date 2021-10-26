using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;

namespace CronogramaAula
{
    public partial class TelaCadAluno : Form
    {
        public TelaCadAluno()
        {
            InitializeComponent();
        }

        private void TelaCadAluno_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno.NomeAluno = tbNomeAluno.Text;
            Aluno.EmailAluno = tbEmailAluno.Text;
            Aluno.FoneAluno = tbFoneAluno.Text;

            AlunoController alunocontroller = new AlunoController();
            alunocontroller.cadastroAluno();

            
            tbNomeAluno.Clear();
            tbEmailAluno.Clear();
            tbFoneAluno.Clear();

            if (Aluno.Retorno == "True")
            {
                this.Close();
            }
           

        }
    }
}
