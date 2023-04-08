
namespace OrionWinForms
{
    partial class CadastrarIgreja
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
            this.lblSetor = new System.Windows.Forms.Label();
            this.cbxSetor = new System.Windows.Forms.ComboBox();
            this.lblIgreja = new System.Windows.Forms.Label();
            this.txtNomeIgreja = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEnderecoIgreja = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCidadeIgreja = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCepIgreja = new System.Windows.Forms.TextBox();
            this.lblPAstor = new System.Windows.Forms.Label();
            this.txtPastorIgreja = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(12, 14);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(44, 20);
            this.lblSetor.TabIndex = 0;
            this.lblSetor.Text = "Setor";
            // 
            // cbxSetor
            // 
            this.cbxSetor.FormattingEnabled = true;
            this.cbxSetor.Location = new System.Drawing.Point(12, 37);
            this.cbxSetor.Name = "cbxSetor";
            this.cbxSetor.Size = new System.Drawing.Size(178, 28);
            this.cbxSetor.TabIndex = 1;
            // 
            // lblIgreja
            // 
            this.lblIgreja.AutoSize = true;
            this.lblIgreja.Location = new System.Drawing.Point(196, 11);
            this.lblIgreja.Name = "lblIgreja";
            this.lblIgreja.Size = new System.Drawing.Size(47, 20);
            this.lblIgreja.TabIndex = 2;
            this.lblIgreja.Text = "Igreja";
            // 
            // txtNomeIgreja
            // 
            this.txtNomeIgreja.Location = new System.Drawing.Point(196, 37);
            this.txtNomeIgreja.Name = "txtNomeIgreja";
            this.txtNomeIgreja.Size = new System.Drawing.Size(254, 27);
            this.txtNomeIgreja.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(457, 11);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Endereço";
            // 
            // txtEnderecoIgreja
            // 
            this.txtEnderecoIgreja.Location = new System.Drawing.Point(456, 37);
            this.txtEnderecoIgreja.Name = "txtEnderecoIgreja";
            this.txtEnderecoIgreja.Size = new System.Drawing.Size(303, 27);
            this.txtEnderecoIgreja.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(766, 11);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 20);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Cidade";
            // 
            // txtCidadeIgreja
            // 
            this.txtCidadeIgreja.Location = new System.Drawing.Point(765, 37);
            this.txtCidadeIgreja.Name = "txtCidadeIgreja";
            this.txtCidadeIgreja.Size = new System.Drawing.Size(148, 27);
            this.txtCidadeIgreja.TabIndex = 7;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(919, 10);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 20);
            this.lblUF.TabIndex = 8;
            this.lblUF.Text = "UF";
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Location = new System.Drawing.Point(919, 36);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(80, 28);
            this.cbxUF.TabIndex = 9;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(12, 78);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(37, 20);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP:";
            // 
            // txtCepIgreja
            // 
            this.txtCepIgreja.Location = new System.Drawing.Point(12, 101);
            this.txtCepIgreja.Name = "txtCepIgreja";
            this.txtCepIgreja.Size = new System.Drawing.Size(150, 27);
            this.txtCepIgreja.TabIndex = 13;
            // 
            // lblPAstor
            // 
            this.lblPAstor.AutoSize = true;
            this.lblPAstor.Location = new System.Drawing.Point(168, 78);
            this.lblPAstor.Name = "lblPAstor";
            this.lblPAstor.Size = new System.Drawing.Size(49, 20);
            this.lblPAstor.TabIndex = 14;
            this.lblPAstor.Text = "Pastor";
            // 
            // txtPastorIgreja
            // 
            this.txtPastorIgreja.Location = new System.Drawing.Point(168, 101);
            this.txtPastorIgreja.Name = "txtPastorIgreja";
            this.txtPastorIgreja.Size = new System.Drawing.Size(212, 27);
            this.txtPastorIgreja.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 285);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(1102, 99);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 29);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Inserir";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(1006, 14);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 20);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(1005, 36);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(151, 27);
            this.txtPais.TabIndex = 11;
            // 
            // CadastrarIgreja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPastorIgreja);
            this.Controls.Add(this.lblPAstor);
            this.Controls.Add(this.txtCepIgreja);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtCidadeIgreja);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtEnderecoIgreja);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtNomeIgreja);
            this.Controls.Add(this.lblIgreja);
            this.Controls.Add(this.cbxSetor);
            this.Controls.Add(this.lblSetor);
            this.Name = "CadastrarIgreja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Igreja";
            this.Load += new System.EventHandler(this.CadastrarIgreja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.ComboBox cbxSetor;
        private System.Windows.Forms.Label lblIgreja;
        private System.Windows.Forms.TextBox txtNomeIgreja;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEnderecoIgreja;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCidadeIgreja;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCepIgreja;
        private System.Windows.Forms.Label lblPAstor;
        private System.Windows.Forms.TextBox txtPastorIgreja;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPais;
    }
}