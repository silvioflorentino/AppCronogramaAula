﻿
namespace CronogramaAula
{
    partial class TelaCadAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeAluno = new System.Windows.Forms.TextBox();
            this.tbEmailAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFoneAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // tbNomeAluno
            // 
            this.tbNomeAluno.Location = new System.Drawing.Point(145, 93);
            this.tbNomeAluno.Name = "tbNomeAluno";
            this.tbNomeAluno.Size = new System.Drawing.Size(256, 23);
            this.tbNomeAluno.TabIndex = 2;
            // 
            // tbEmailAluno
            // 
            this.tbEmailAluno.Location = new System.Drawing.Point(144, 138);
            this.tbEmailAluno.Name = "tbEmailAluno";
            this.tbEmailAluno.Size = new System.Drawing.Size(257, 23);
            this.tbEmailAluno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // tbFoneAluno
            // 
            this.tbFoneAluno.Location = new System.Drawing.Point(144, 184);
            this.tbFoneAluno.Name = "tbFoneAluno";
            this.tbFoneAluno.Size = new System.Drawing.Size(147, 23);
            this.tbFoneAluno.TabIndex = 6;
            this.tbFoneAluno.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadAluno.Location = new System.Drawing.Point(322, 258);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(161, 36);
            this.btnCadAluno.TabIndex = 7;
            this.btnCadAluno.Text = "Cadastrar";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(507, 324);
            this.Controls.Add(this.btnCadAluno);
            this.Controls.Add(this.tbFoneAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmailAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "TelaCadAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cronograma de Aulas ::::  Cadastro de Aluno";
            this.Load += new System.EventHandler(this.TelaCadAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeAluno;
        private System.Windows.Forms.TextBox tbEmailAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFoneAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadAluno;
    }
}