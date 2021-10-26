
namespace CronogramaAula
{
    partial class TelaCadUc
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeUc = new System.Windows.Forms.TextBox();
            this.tbNumUc = new System.Windows.Forms.TextBox();
            this.tbDescUc = new System.Windows.Forms.RichTextBox();
            this.btnCadUc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de UC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da UC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(168, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de aulas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(168, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // tbNomeUc
            // 
            this.tbNomeUc.Location = new System.Drawing.Point(304, 94);
            this.tbNomeUc.Name = "tbNomeUc";
            this.tbNomeUc.Size = new System.Drawing.Size(180, 23);
            this.tbNomeUc.TabIndex = 4;
            // 
            // tbNumUc
            // 
            this.tbNumUc.Location = new System.Drawing.Point(342, 241);
            this.tbNumUc.Name = "tbNumUc";
            this.tbNumUc.Size = new System.Drawing.Size(61, 23);
            this.tbNumUc.TabIndex = 6;
            // 
            // tbDescUc
            // 
            this.tbDescUc.Location = new System.Drawing.Point(276, 134);
            this.tbDescUc.Name = "tbDescUc";
            this.tbDescUc.Size = new System.Drawing.Size(208, 81);
            this.tbDescUc.TabIndex = 7;
            this.tbDescUc.Text = "";
            // 
            // btnCadUc
            // 
            this.btnCadUc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadUc.Location = new System.Drawing.Point(237, 295);
            this.btnCadUc.Name = "btnCadUc";
            this.btnCadUc.Size = new System.Drawing.Size(189, 36);
            this.btnCadUc.TabIndex = 8;
            this.btnCadUc.Text = "Cadastrar";
            this.btnCadUc.UseVisualStyleBackColor = true;
            // 
            // TelaCadUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(629, 363);
            this.Controls.Add(this.btnCadUc);
            this.Controls.Add(this.tbDescUc);
            this.Controls.Add(this.tbNumUc);
            this.Controls.Add(this.tbNomeUc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadUc";
            this.Text = "TelaCadUc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomeUc;
        private System.Windows.Forms.TextBox tbNumUc;
        private System.Windows.Forms.RichTextBox tbDescUc;
        private System.Windows.Forms.Button btnCadUc;
    }
}