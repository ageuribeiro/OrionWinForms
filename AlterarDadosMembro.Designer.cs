
namespace OrionWinForms
{
    partial class AlterarDadosMembro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.lblFuncaonaIgreja = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskCellFone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 544);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(136, 45);
            this.btnSalvar.TabIndex = 81;
            this.btnSalvar.Text = "Alterar Dados";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(197, 31);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(86, 20);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(197, 54);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(174, 27);
            this.txtSobrenome.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 27);
            this.txtNome.TabIndex = 1;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(6, 171);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(145, 20);
            this.lblDataNascimento.TabIndex = 8;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(9, 303);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(28, 20);
            this.lblRG.TabIndex = 18;
            this.lblRG.Text = "RG";
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(7, 326);
            this.mskRG.Mask = "00,000,000-0";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(153, 27);
            this.mskRG.TabIndex = 19;
            // 
            // lblFuncaonaIgreja
            // 
            this.lblFuncaonaIgreja.AutoSize = true;
            this.lblFuncaonaIgreja.Location = new System.Drawing.Point(7, 231);
            this.lblFuncaonaIgreja.Name = "lblFuncaonaIgreja";
            this.lblFuncaonaIgreja.Size = new System.Drawing.Size(118, 20);
            this.lblFuncaonaIgreja.TabIndex = 60;
            this.lblFuncaonaIgreja.Text = "Função na Igreja";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Location = new System.Drawing.Point(5, 372);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "Endereço";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(173, 303);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 20);
            this.lblCPF.TabIndex = 20;
            this.lblCPF.Text = "CPF";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(5, 395);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(366, 27);
            this.txtAddress.TabIndex = 35;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(173, 326);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(198, 27);
            this.mskCPF.TabIndex = 21;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 97);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(118, 20);
            this.lblTelefone.TabIndex = 26;
            this.lblTelefone.Text = "Telefone/Celular";
            // 
            // mskCellFone
            // 
            this.mskCellFone.Location = new System.Drawing.Point(5, 122);
            this.mskCellFone.Mask = "(99) 00000-0000";
            this.mskCellFone.Name = "mskCellFone";
            this.mskCellFone.Size = new System.Drawing.Size(155, 27);
            this.mskCellFone.TabIndex = 27;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(166, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "E-mail";
            // 
            // mskEmail
            // 
            this.mskEmail.Location = new System.Drawing.Point(173, 122);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.Size = new System.Drawing.Size(198, 27);
            this.mskEmail.TabIndex = 29;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(6, 193);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(365, 27);
            this.dtpDataNascimento.TabIndex = 9;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.cbxFuncao);
            this.gbDadosPessoais.Controls.Add(this.lblBairro);
            this.gbDadosPessoais.Controls.Add(this.txtNeighborhood);
            this.gbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.mskEmail);
            this.gbDadosPessoais.Controls.Add(this.lblEmail);
            this.gbDadosPessoais.Controls.Add(this.mskCellFone);
            this.gbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbDadosPessoais.Controls.Add(this.mskCPF);
            this.gbDadosPessoais.Controls.Add(this.txtAddress);
            this.gbDadosPessoais.Controls.Add(this.lblCPF);
            this.gbDadosPessoais.Controls.Add(this.lblAddress);
            this.gbDadosPessoais.Controls.Add(this.lblFuncaonaIgreja);
            this.gbDadosPessoais.Controls.Add(this.mskRG);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.txtSobrenome);
            this.gbDadosPessoais.Controls.Add(this.lblSobrenome);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(377, 526);
            this.gbDadosPessoais.TabIndex = 75;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Location = new System.Drawing.Point(6, 254);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(365, 28);
            this.cbxFuncao.TabIndex = 64;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(9, 453);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 20);
            this.lblBairro.TabIndex = 63;
            this.lblBairro.Text = "Bairro";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(5, 476);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(366, 27);
            this.txtNeighborhood.TabIndex = 62;
            // 
            // AlterarDadosMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 607);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbDadosPessoais);
            this.Name = "AlterarDadosMembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Dados do Membro";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label lblFuncaonaIgreja;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskCellFone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.ComboBox cbxFuncao;
    }
}