
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
            this.lblStatusFamilia = new System.Windows.Forms.Label();
            this.btnGerarFamilia = new System.Windows.Forms.Button();
            this.lblQtdFamilia = new System.Windows.Forms.Label();
            this.dataGridViewFamily = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamily)).BeginInit();
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
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Mãe";
            // 
            // txtNomePaiFamilia
            // 
            this.txtNomePaiFamilia.Location = new System.Drawing.Point(123, 6);
            this.txtNomePaiFamilia.Name = "txtNomePaiFamilia";
            this.txtNomePaiFamilia.Size = new System.Drawing.Size(328, 27);
            this.txtNomePaiFamilia.TabIndex = 1;
            // 
            // txtNomeMaeFamilia
            // 
            this.txtNomeMaeFamilia.Location = new System.Drawing.Point(123, 46);
            this.txtNomeMaeFamilia.Name = "txtNomeMaeFamilia";
            this.txtNomeMaeFamilia.Size = new System.Drawing.Size(328, 27);
            this.txtNomeMaeFamilia.TabIndex = 3;
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
            this.btnGerarFamilia.Location = new System.Drawing.Point(457, 44);
            this.btnGerarFamilia.Name = "btnGerarFamilia";
            this.btnGerarFamilia.Size = new System.Drawing.Size(125, 29);
            this.btnGerarFamilia.TabIndex = 4;
            this.btnGerarFamilia.Text = "Gerar Família";
            this.btnGerarFamilia.UseVisualStyleBackColor = true;
            this.btnGerarFamilia.Click += new System.EventHandler(this.btnGerarFamilia_Click);
            // 
            // lblQtdFamilia
            // 
            this.lblQtdFamilia.AutoSize = true;
            this.lblQtdFamilia.Location = new System.Drawing.Point(415, 89);
            this.lblQtdFamilia.Name = "lblQtdFamilia";
            this.lblQtdFamilia.Size = new System.Drawing.Size(0, 20);
            this.lblQtdFamilia.TabIndex = 8;
            // 
            // dataGridViewFamily
            // 
            this.dataGridViewFamily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamily.Location = new System.Drawing.Point(13, 89);
            this.dataGridViewFamily.Name = "dataGridViewFamily";
            this.dataGridViewFamily.RowHeadersWidth = 51;
            this.dataGridViewFamily.RowTemplate.Height = 29;
            this.dataGridViewFamily.Size = new System.Drawing.Size(569, 349);
            this.dataGridViewFamily.TabIndex = 9;
            // 
            // CadastrarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.dataGridViewFamily);
            this.Controls.Add(this.lblQtdFamilia);
            this.Controls.Add(this.btnGerarFamilia);
            this.Controls.Add(this.lblStatusFamilia);
            this.Controls.Add(this.txtNomeMaeFamilia);
            this.Controls.Add(this.txtNomePaiFamilia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Família";
            this.Load += new System.EventHandler(this.CadastrarFamilia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePaiFamilia;
        private System.Windows.Forms.TextBox txtNomeMaeFamilia;
        private System.Windows.Forms.Label lblStatusFamilia;
        private System.Windows.Forms.Button btnGerarFamilia;
        private System.Windows.Forms.Label lblQtdFamilia;
        private System.Windows.Forms.DataGridView dataGridViewFamily;
    }
}