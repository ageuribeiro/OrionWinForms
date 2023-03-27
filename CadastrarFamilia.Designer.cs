
namespace OrionWinForms
{
    partial class CadastrarFamilia
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
            this.txtNomePaiFamilia = new System.Windows.Forms.TextBox();
            this.txtNomeMaeFamilia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatusFamilia = new System.Windows.Forms.Label();
            this.btnGerarFamilia = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblQtdFamilia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Pai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Mãe";
            // 
            // txtNomePaiFamilia
            // 
            this.txtNomePaiFamilia.Location = new System.Drawing.Point(123, 6);
            this.txtNomePaiFamilia.Name = "txtNomePaiFamilia";
            this.txtNomePaiFamilia.Size = new System.Drawing.Size(297, 27);
            this.txtNomePaiFamilia.TabIndex = 2;
            // 
            // txtNomeMaeFamilia
            // 
            this.txtNomeMaeFamilia.Location = new System.Drawing.Point(123, 46);
            this.txtNomeMaeFamilia.Name = "txtNomeMaeFamilia";
            this.txtNomeMaeFamilia.Size = new System.Drawing.Size(297, 27);
            this.txtNomeMaeFamilia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Família: ";
            // 
            // lblStatusFamilia
            // 
            this.lblStatusFamilia.AutoSize = true;
            this.lblStatusFamilia.Location = new System.Drawing.Point(81, 89);
            this.lblStatusFamilia.Name = "lblStatusFamilia";
            this.lblStatusFamilia.Size = new System.Drawing.Size(0, 20);
            this.lblStatusFamilia.TabIndex = 5;
            // 
            // btnGerarFamilia
            // 
            this.btnGerarFamilia.Location = new System.Drawing.Point(428, 26);
            this.btnGerarFamilia.Name = "btnGerarFamilia";
            this.btnGerarFamilia.Size = new System.Drawing.Size(125, 29);
            this.btnGerarFamilia.TabIndex = 6;
            this.btnGerarFamilia.Text = "Gerar Família";
            this.btnGerarFamilia.UseVisualStyleBackColor = true;
            this.btnGerarFamilia.Click += new System.EventHandler(this.btnGerarFamilia_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 326);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblQtdFamilia
            // 
            this.lblQtdFamilia.AutoSize = true;
            this.lblQtdFamilia.Location = new System.Drawing.Point(415, 89);
            this.lblQtdFamilia.Name = "lblQtdFamilia";
            this.lblQtdFamilia.Size = new System.Drawing.Size(0, 20);
            this.lblQtdFamilia.TabIndex = 8;
            // 
            // CadastrarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.lblQtdFamilia);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnGerarFamilia);
            this.Controls.Add(this.lblStatusFamilia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeMaeFamilia);
            this.Controls.Add(this.txtNomePaiFamilia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarFamilia";
            this.Text = "Cadastrar Família";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePaiFamilia;
        private System.Windows.Forms.TextBox txtNomeMaeFamilia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatusFamilia;
        private System.Windows.Forms.Button btnGerarFamilia;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblQtdFamilia;
    }
}