
namespace CronogramaAula
{
    partial class TelaCadSala
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomeSala = new System.Windows.Forms.TextBox();
            this.tbTipoSala = new System.Windows.Forms.TextBox();
            this.btnCadSala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Sala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(117, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo da Sala:";
            // 
            // tbNomeSala
            // 
            this.tbNomeSala.Location = new System.Drawing.Point(263, 94);
            this.tbNomeSala.Name = "tbNomeSala";
            this.tbNomeSala.Size = new System.Drawing.Size(144, 23);
            this.tbNomeSala.TabIndex = 3;
            // 
            // tbTipoSala
            // 
            this.tbTipoSala.Location = new System.Drawing.Point(248, 137);
            this.tbTipoSala.Name = "tbTipoSala";
            this.tbTipoSala.Size = new System.Drawing.Size(159, 23);
            this.tbTipoSala.TabIndex = 4;
            // 
            // btnCadSala
            // 
            this.btnCadSala.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadSala.Location = new System.Drawing.Point(201, 189);
            this.btnCadSala.Name = "btnCadSala";
            this.btnCadSala.Size = new System.Drawing.Size(143, 38);
            this.btnCadSala.TabIndex = 5;
            this.btnCadSala.Text = "Cadastrar";
            this.btnCadSala.UseVisualStyleBackColor = true;
            // 
            // TelaCadSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(511, 287);
            this.Controls.Add(this.btnCadSala);
            this.Controls.Add(this.tbTipoSala);
            this.Controls.Add(this.tbNomeSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadSala";
            this.Text = "TelaCadSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomeSala;
        private System.Windows.Forms.TextBox tbTipoSala;
        private System.Windows.Forms.Button btnCadSala;
    }
}