﻿
namespace OrionWinForms
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.cbxEscolaridade = new System.Windows.Forms.ComboBox();
            this.lblEscolaridade = new System.Windows.Forms.Label();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskCellFone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.cbxUFNascimento = new System.Windows.Forms.ComboBox();
            this.lblEstadoNascimento = new System.Windows.Forms.Label();
            this.txtCidadeNascimento = new System.Windows.Forms.TextBox();
            this.lblCidadeNascimento = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.lblNomeMae = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.lblNomePai = new System.Windows.Forms.Label();
            this.gbDadosIgreja = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lblDataDeBatismo = new System.Windows.Forms.Label();
            this.lblIgrejaDeBatismo = new System.Windows.Forms.Label();
            this.cbxIgrejaDeBatismo = new System.Windows.Forms.ComboBox();
            this.cbxFuncao = new System.Windows.Forms.ComboBox();
            this.lblFuncaonaIgreja = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ldlDataAdmissao = new System.Windows.Forms.Label();
            this.cbxOpcaoAdmissao = new System.Windows.Forms.ComboBox();
            this.lblAdmitidoPor = new System.Windows.Forms.Label();
            this.cbxCongregacaoAnterior = new System.Windows.Forms.ComboBox();
            this.lblCongregaçãoAnterior = new System.Windows.Forms.Label();
            this.cbxCongregacaoAtual = new System.Windows.Forms.ComboBox();
            this.lblCongregacaoAtual = new System.Windows.Forms.Label();
            this.cbxSetorAnterior = new System.Windows.Forms.ComboBox();
            this.lblSetorAnterior = new System.Windows.Forms.Label();
            this.cbxSetorAtual = new System.Windows.Forms.ComboBox();
            this.lblSetorAtual = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtComplementoAddress = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumAddress = new System.Windows.Forms.TextBox();
            this.lblNumAddress = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtPaisaddress = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtCidadeAddress = new System.Windows.Forms.TextBox();
            this.cbxUFAddress = new System.Windows.Forms.ComboBox();
            this.lblUFAddress = new System.Windows.Forms.Label();
            this.lblCidadeAddress = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.IsBatizado = new System.Windows.Forms.CheckBox();
            this.ckbMembroCartao = new System.Windows.Forms.CheckBox();
            this.gpDadosimportantes = new System.Windows.Forms.GroupBox();
            this.ISBatizedWithSpirit = new System.Windows.Forms.CheckBox();
            this.btnCaptureImagem = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisarMembro = new System.Windows.Forms.Button();
            this.btnGerarFamilia = new System.Windows.Forms.Button();
            this.btnCadastrarSetor = new System.Windows.Forms.Button();
            this.btnCadastrarIgreja = new System.Windows.Forms.Button();
            this.gbDadosPessoais.SuspendLayout();
            this.gbDadosIgreja.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gpDadosimportantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 27);
            this.txtNome.TabIndex = 1;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(211, 32);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(86, 20);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(210, 55);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(198, 27);
            this.txtSobrenome.TabIndex = 3;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtProfissao);
            this.gbDadosPessoais.Controls.Add(this.lblProfissao);
            this.gbDadosPessoais.Controls.Add(this.cbxEscolaridade);
            this.gbDadosPessoais.Controls.Add(this.lblEscolaridade);
            this.gbDadosPessoais.Controls.Add(this.mskEmail);
            this.gbDadosPessoais.Controls.Add(this.lblEmail);
            this.gbDadosPessoais.Controls.Add(this.mskCellFone);
            this.gbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbDadosPessoais.Controls.Add(this.txtIdade);
            this.gbDadosPessoais.Controls.Add(this.lblAge);
            this.gbDadosPessoais.Controls.Add(this.cbxEstadoCivil);
            this.gbDadosPessoais.Controls.Add(this.lblEstadoCivil);
            this.gbDadosPessoais.Controls.Add(this.lblGenero);
            this.gbDadosPessoais.Controls.Add(this.cbxGenero);
            this.gbDadosPessoais.Controls.Add(this.maskedTextBox1);
            this.gbDadosPessoais.Controls.Add(this.lblCPF);
            this.gbDadosPessoais.Controls.Add(this.mskRG);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.txtNacionalidade);
            this.gbDadosPessoais.Controls.Add(this.lblNacionalidade);
            this.gbDadosPessoais.Controls.Add(this.cbxUFNascimento);
            this.gbDadosPessoais.Controls.Add(this.lblEstadoNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtCidadeNascimento);
            this.gbDadosPessoais.Controls.Add(this.lblCidadeNascimento);
            this.gbDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtNomeMae);
            this.gbDadosPessoais.Controls.Add(this.lblNomeMae);
            this.gbDadosPessoais.Controls.Add(this.txtNomePai);
            this.gbDadosPessoais.Controls.Add(this.lblNomePai);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.txtSobrenome);
            this.gbDadosPessoais.Controls.Add(this.lblSobrenome);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(1521, 175);
            this.gbDadosPessoais.TabIndex = 4;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(823, 54);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(144, 27);
            this.dtpDataNascimento.TabIndex = 9;
            // 
            // txtProfissao
            // 
            this.txtProfissao.Location = new System.Drawing.Point(1296, 124);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(213, 27);
            this.txtProfissao.TabIndex = 33;
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(1296, 98);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(69, 20);
            this.lblProfissao.TabIndex = 32;
            this.lblProfissao.Text = "Profissão";
            // 
            // cbxEscolaridade
            // 
            this.cbxEscolaridade.FormattingEnabled = true;
            this.cbxEscolaridade.Location = new System.Drawing.Point(1087, 122);
            this.cbxEscolaridade.Name = "cbxEscolaridade";
            this.cbxEscolaridade.Size = new System.Drawing.Size(203, 28);
            this.cbxEscolaridade.TabIndex = 31;
            // 
            // lblEscolaridade
            // 
            this.lblEscolaridade.AutoSize = true;
            this.lblEscolaridade.Location = new System.Drawing.Point(1083, 100);
            this.lblEscolaridade.Name = "lblEscolaridade";
            this.lblEscolaridade.Size = new System.Drawing.Size(94, 20);
            this.lblEscolaridade.TabIndex = 30;
            this.lblEscolaridade.Text = "Escolaridade";
            // 
            // mskEmail
            // 
            this.mskEmail.Location = new System.Drawing.Point(818, 123);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.Size = new System.Drawing.Size(263, 27);
            this.mskEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(818, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "E-mail";
            // 
            // mskCellFone
            // 
            this.mskCellFone.Location = new System.Drawing.Point(657, 123);
            this.mskCellFone.Mask = "(99) 00000-0000";
            this.mskCellFone.Name = "mskCellFone";
            this.mskCellFone.Size = new System.Drawing.Size(155, 27);
            this.mskCellFone.TabIndex = 27;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(652, 99);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(118, 20);
            this.lblTelefone.TabIndex = 26;
            this.lblTelefone.Text = "Telefone/Celular";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(8, 123);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(54, 27);
            this.txtIdade.TabIndex = 17;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(8, 99);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(47, 20);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "Idade";
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Location = new System.Drawing.Point(500, 123);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(151, 28);
            this.cbxEstadoCivil.TabIndex = 25;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(500, 100);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(86, 20);
            this.lblEstadoCivil.TabIndex = 24;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(343, 99);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(57, 20);
            this.lblGenero.TabIndex = 22;
            this.lblGenero.Text = "Gênero";
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(343, 123);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(151, 28);
            this.cbxGenero.TabIndex = 23;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(183, 123);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(154, 27);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(183, 100);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 20);
            this.lblCPF.TabIndex = 20;
            this.lblCPF.Text = "CPF";
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(68, 123);
            this.mskRG.Mask = "00,000,000-0";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(109, 27);
            this.mskRG.TabIndex = 19;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(70, 100);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(28, 20);
            this.lblRG.TabIndex = 18;
            this.lblRG.Text = "RG";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(1296, 55);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(161, 27);
            this.txtNacionalidade.TabIndex = 15;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Location = new System.Drawing.Point(1296, 32);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(106, 20);
            this.lblNacionalidade.TabIndex = 14;
            this.lblNacionalidade.Text = "Nacionalidade";
            // 
            // cbxUFNascimento
            // 
            this.cbxUFNascimento.FormattingEnabled = true;
            this.cbxUFNascimento.Items.AddRange(new object[] {
            "AC - Acre",
            "AL - Alagoas",
            "AP - Amapá",
            "AM - Amazonas",
            "BA - Bahia\t",
            "CE - Ceará",
            "DF - Distrito Federal",
            "ES - Espírito Santo",
            "GO - Goiás",
            "MA - Maranhão",
            "MT - Mato Grosso",
            "MS - Mato Grosso do Sul",
            "MG - Minas Gerais",
            "PA - Pará",
            "PB - Paraíba",
            "PR - Paraná",
            "PE - Pernambuco",
            "PI - Piauí",
            "RJ - Rio de Janeiro",
            "RN - Rio Grande do Norte",
            "RS - Rio Grande do Sul",
            "RO - Rondônia",
            "RR - Roraima",
            "SC - Santa Catarina",
            "SP - São Paulo",
            "SE - Sergipe",
            "TO - Tocantins"});
            this.cbxUFNascimento.Location = new System.Drawing.Point(1139, 54);
            this.cbxUFNascimento.Name = "cbxUFNascimento";
            this.cbxUFNascimento.Size = new System.Drawing.Size(151, 28);
            this.cbxUFNascimento.TabIndex = 13;
            // 
            // lblEstadoNascimento
            // 
            this.lblEstadoNascimento.AutoSize = true;
            this.lblEstadoNascimento.Location = new System.Drawing.Point(1139, 32);
            this.lblEstadoNascimento.Name = "lblEstadoNascimento";
            this.lblEstadoNascimento.Size = new System.Drawing.Size(109, 20);
            this.lblEstadoNascimento.TabIndex = 12;
            this.lblEstadoNascimento.Text = "UF Nascimento";
            // 
            // txtCidadeNascimento
            // 
            this.txtCidadeNascimento.Location = new System.Drawing.Point(973, 55);
            this.txtCidadeNascimento.Name = "txtCidadeNascimento";
            this.txtCidadeNascimento.Size = new System.Drawing.Size(160, 27);
            this.txtCidadeNascimento.TabIndex = 11;
            // 
            // lblCidadeNascimento
            // 
            this.lblCidadeNascimento.AutoSize = true;
            this.lblCidadeNascimento.Location = new System.Drawing.Point(973, 32);
            this.lblCidadeNascimento.Name = "lblCidadeNascimento";
            this.lblCidadeNascimento.Size = new System.Drawing.Size(160, 20);
            this.lblCidadeNascimento.TabIndex = 10;
            this.lblCidadeNascimento.Text = "Cidade de Nascimento";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(823, 32);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(145, 20);
            this.lblDataNascimento.TabIndex = 8;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(619, 55);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(198, 27);
            this.txtNomeMae.TabIndex = 7;
            // 
            // lblNomeMae
            // 
            this.lblNomeMae.AutoSize = true;
            this.lblNomeMae.Location = new System.Drawing.Point(619, 32);
            this.lblNomeMae.Name = "lblNomeMae";
            this.lblNomeMae.Size = new System.Drawing.Size(104, 20);
            this.lblNomeMae.TabIndex = 6;
            this.lblNomeMae.Text = "Nome da Mãe";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Location = new System.Drawing.Point(414, 55);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(198, 27);
            this.txtNomePai.TabIndex = 5;
            // 
            // lblNomePai
            // 
            this.lblNomePai.AutoSize = true;
            this.lblNomePai.Location = new System.Drawing.Point(415, 32);
            this.lblNomePai.Name = "lblNomePai";
            this.lblNomePai.Size = new System.Drawing.Size(95, 20);
            this.lblNomePai.TabIndex = 4;
            this.lblNomePai.Text = "Nome do Pai";
            // 
            // gbDadosIgreja
            // 
            this.gbDadosIgreja.Controls.Add(this.dateTimePicker3);
            this.gbDadosIgreja.Controls.Add(this.lblDataDeBatismo);
            this.gbDadosIgreja.Controls.Add(this.lblIgrejaDeBatismo);
            this.gbDadosIgreja.Controls.Add(this.cbxIgrejaDeBatismo);
            this.gbDadosIgreja.Controls.Add(this.cbxFuncao);
            this.gbDadosIgreja.Controls.Add(this.lblFuncaonaIgreja);
            this.gbDadosIgreja.Controls.Add(this.dateTimePicker1);
            this.gbDadosIgreja.Controls.Add(this.ldlDataAdmissao);
            this.gbDadosIgreja.Controls.Add(this.cbxOpcaoAdmissao);
            this.gbDadosIgreja.Controls.Add(this.lblAdmitidoPor);
            this.gbDadosIgreja.Controls.Add(this.cbxCongregacaoAnterior);
            this.gbDadosIgreja.Controls.Add(this.lblCongregaçãoAnterior);
            this.gbDadosIgreja.Controls.Add(this.cbxCongregacaoAtual);
            this.gbDadosIgreja.Controls.Add(this.lblCongregacaoAtual);
            this.gbDadosIgreja.Controls.Add(this.cbxSetorAnterior);
            this.gbDadosIgreja.Controls.Add(this.lblSetorAnterior);
            this.gbDadosIgreja.Controls.Add(this.cbxSetorAtual);
            this.gbDadosIgreja.Controls.Add(this.lblSetorAtual);
            this.gbDadosIgreja.Location = new System.Drawing.Point(12, 318);
            this.gbDadosIgreja.Name = "gbDadosIgreja";
            this.gbDadosIgreja.Size = new System.Drawing.Size(1165, 182);
            this.gbDadosIgreja.TabIndex = 5;
            this.gbDadosIgreja.TabStop = false;
            this.gbDadosIgreja.Text = "Dados da Igreja";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(210, 129);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker3.TabIndex = 65;
            // 
            // lblDataDeBatismo
            // 
            this.lblDataDeBatismo.AutoSize = true;
            this.lblDataDeBatismo.Location = new System.Drawing.Point(210, 105);
            this.lblDataDeBatismo.Name = "lblDataDeBatismo";
            this.lblDataDeBatismo.Size = new System.Drawing.Size(120, 20);
            this.lblDataDeBatismo.TabIndex = 64;
            this.lblDataDeBatismo.Text = "Data de Batismo";
            // 
            // lblIgrejaDeBatismo
            // 
            this.lblIgrejaDeBatismo.AutoSize = true;
            this.lblIgrejaDeBatismo.Location = new System.Drawing.Point(12, 105);
            this.lblIgrejaDeBatismo.Name = "lblIgrejaDeBatismo";
            this.lblIgrejaDeBatismo.Size = new System.Drawing.Size(177, 20);
            this.lblIgrejaDeBatismo.TabIndex = 62;
            this.lblIgrejaDeBatismo.Text = "Congregação de Batismo";
            // 
            // cbxIgrejaDeBatismo
            // 
            this.cbxIgrejaDeBatismo.FormattingEnabled = true;
            this.cbxIgrejaDeBatismo.Location = new System.Drawing.Point(12, 128);
            this.cbxIgrejaDeBatismo.Name = "cbxIgrejaDeBatismo";
            this.cbxIgrejaDeBatismo.Size = new System.Drawing.Size(192, 28);
            this.cbxIgrejaDeBatismo.TabIndex = 63;
            // 
            // cbxFuncao
            // 
            this.cbxFuncao.FormattingEnabled = true;
            this.cbxFuncao.Location = new System.Drawing.Point(1007, 58);
            this.cbxFuncao.Name = "cbxFuncao";
            this.cbxFuncao.Size = new System.Drawing.Size(151, 28);
            this.cbxFuncao.TabIndex = 61;
            // 
            // lblFuncaonaIgreja
            // 
            this.lblFuncaonaIgreja.AutoSize = true;
            this.lblFuncaonaIgreja.Location = new System.Drawing.Point(1008, 34);
            this.lblFuncaonaIgreja.Name = "lblFuncaonaIgreja";
            this.lblFuncaonaIgreja.Size = new System.Drawing.Size(118, 20);
            this.lblFuncaonaIgreja.TabIndex = 60;
            this.lblFuncaonaIgreja.Text = "Função na Igreja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(856, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 27);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // ldlDataAdmissao
            // 
            this.ldlDataAdmissao.AutoSize = true;
            this.ldlDataAdmissao.Location = new System.Drawing.Point(856, 34);
            this.ldlDataAdmissao.Name = "ldlDataAdmissao";
            this.ldlDataAdmissao.Size = new System.Drawing.Size(131, 20);
            this.ldlDataAdmissao.TabIndex = 58;
            this.ldlDataAdmissao.Text = "Data da Admissão";
            // 
            // cbxOpcaoAdmissao
            // 
            this.cbxOpcaoAdmissao.FormattingEnabled = true;
            this.cbxOpcaoAdmissao.Location = new System.Drawing.Point(674, 57);
            this.cbxOpcaoAdmissao.Name = "cbxOpcaoAdmissao";
            this.cbxOpcaoAdmissao.Size = new System.Drawing.Size(176, 28);
            this.cbxOpcaoAdmissao.TabIndex = 57;
            // 
            // lblAdmitidoPor
            // 
            this.lblAdmitidoPor.AutoSize = true;
            this.lblAdmitidoPor.Location = new System.Drawing.Point(674, 34);
            this.lblAdmitidoPor.Name = "lblAdmitidoPor";
            this.lblAdmitidoPor.Size = new System.Drawing.Size(164, 20);
            this.lblAdmitidoPor.TabIndex = 56;
            this.lblAdmitidoPor.Text = "Admitido na Igreja por:";
            // 
            // cbxCongregacaoAnterior
            // 
            this.cbxCongregacaoAnterior.FormattingEnabled = true;
            this.cbxCongregacaoAnterior.Location = new System.Drawing.Point(500, 57);
            this.cbxCongregacaoAnterior.Name = "cbxCongregacaoAnterior";
            this.cbxCongregacaoAnterior.Size = new System.Drawing.Size(168, 28);
            this.cbxCongregacaoAnterior.TabIndex = 55;
            // 
            // lblCongregaçãoAnterior
            // 
            this.lblCongregaçãoAnterior.AutoSize = true;
            this.lblCongregaçãoAnterior.Location = new System.Drawing.Point(500, 34);
            this.lblCongregaçãoAnterior.Name = "lblCongregaçãoAnterior";
            this.lblCongregaçãoAnterior.Size = new System.Drawing.Size(156, 20);
            this.lblCongregaçãoAnterior.TabIndex = 54;
            this.lblCongregaçãoAnterior.Text = "Congregação Anterior";
            // 
            // cbxCongregacaoAtual
            // 
            this.cbxCongregacaoAtual.FormattingEnabled = true;
            this.cbxCongregacaoAtual.Location = new System.Drawing.Point(169, 57);
            this.cbxCongregacaoAtual.Name = "cbxCongregacaoAtual";
            this.cbxCongregacaoAtual.Size = new System.Drawing.Size(168, 28);
            this.cbxCongregacaoAtual.TabIndex = 51;
            // 
            // lblCongregacaoAtual
            // 
            this.lblCongregacaoAtual.AutoSize = true;
            this.lblCongregacaoAtual.Location = new System.Drawing.Point(169, 34);
            this.lblCongregacaoAtual.Name = "lblCongregacaoAtual";
            this.lblCongregacaoAtual.Size = new System.Drawing.Size(137, 20);
            this.lblCongregacaoAtual.TabIndex = 50;
            this.lblCongregacaoAtual.Text = "Congregação Atual";
            // 
            // cbxSetorAnterior
            // 
            this.cbxSetorAnterior.FormattingEnabled = true;
            this.cbxSetorAnterior.Location = new System.Drawing.Point(343, 57);
            this.cbxSetorAnterior.Name = "cbxSetorAnterior";
            this.cbxSetorAnterior.Size = new System.Drawing.Size(151, 28);
            this.cbxSetorAnterior.TabIndex = 53;
            // 
            // lblSetorAnterior
            // 
            this.lblSetorAnterior.AutoSize = true;
            this.lblSetorAnterior.Location = new System.Drawing.Point(343, 34);
            this.lblSetorAnterior.Name = "lblSetorAnterior";
            this.lblSetorAnterior.Size = new System.Drawing.Size(102, 20);
            this.lblSetorAnterior.TabIndex = 52;
            this.lblSetorAnterior.Text = "Setor Anterior";
            // 
            // cbxSetorAtual
            // 
            this.cbxSetorAtual.FormattingEnabled = true;
            this.cbxSetorAtual.Location = new System.Drawing.Point(12, 57);
            this.cbxSetorAtual.Name = "cbxSetorAtual";
            this.cbxSetorAtual.Size = new System.Drawing.Size(151, 28);
            this.cbxSetorAtual.TabIndex = 49;
            // 
            // lblSetorAtual
            // 
            this.lblSetorAtual.AutoSize = true;
            this.lblSetorAtual.Location = new System.Drawing.Point(12, 34);
            this.lblSetorAtual.Name = "lblSetorAtual";
            this.lblSetorAtual.Size = new System.Drawing.Size(83, 20);
            this.lblSetorAtual.TabIndex = 48;
            this.lblSetorAtual.Text = "Setor Atual";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtComplementoAddress);
            this.gbEndereco.Controls.Add(this.lblComplemento);
            this.gbEndereco.Controls.Add(this.txtNumAddress);
            this.gbEndereco.Controls.Add(this.lblNumAddress);
            this.gbEndereco.Controls.Add(this.maskedTextBox2);
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Controls.Add(this.txtPaisaddress);
            this.gbEndereco.Controls.Add(this.lblPais);
            this.gbEndereco.Controls.Add(this.txtCidadeAddress);
            this.gbEndereco.Controls.Add(this.cbxUFAddress);
            this.gbEndereco.Controls.Add(this.lblUFAddress);
            this.gbEndereco.Controls.Add(this.lblCidadeAddress);
            this.gbEndereco.Controls.Add(this.txtLogradouro);
            this.gbEndereco.Controls.Add(this.lblLogradouro);
            this.gbEndereco.Location = new System.Drawing.Point(12, 193);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(1521, 119);
            this.gbEndereco.TabIndex = 6;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço Residencial";
            // 
            // txtComplementoAddress
            // 
            this.txtComplementoAddress.Location = new System.Drawing.Point(440, 57);
            this.txtComplementoAddress.Name = "txtComplementoAddress";
            this.txtComplementoAddress.Size = new System.Drawing.Size(351, 27);
            this.txtComplementoAddress.TabIndex = 39;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(440, 35);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(104, 20);
            this.lblComplemento.TabIndex = 38;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtNumAddress
            // 
            this.txtNumAddress.Location = new System.Drawing.Point(361, 58);
            this.txtNumAddress.Name = "txtNumAddress";
            this.txtNumAddress.Size = new System.Drawing.Size(73, 27);
            this.txtNumAddress.TabIndex = 37;
            // 
            // lblNumAddress
            // 
            this.lblNumAddress.AutoSize = true;
            this.lblNumAddress.Location = new System.Drawing.Point(361, 35);
            this.lblNumAddress.Name = "lblNumAddress";
            this.lblNumAddress.Size = new System.Drawing.Size(63, 20);
            this.lblNumAddress.TabIndex = 36;
            this.lblNumAddress.Text = "Número";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(1355, 58);
            this.maskedTextBox2.Mask = "00000-000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(160, 27);
            this.maskedTextBox2.TabIndex = 47;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(1357, 35);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(34, 20);
            this.lblCEP.TabIndex = 46;
            this.lblCEP.Text = "CEP";
            // 
            // txtPaisaddress
            // 
            this.txtPaisaddress.Location = new System.Drawing.Point(1164, 58);
            this.txtPaisaddress.Name = "txtPaisaddress";
            this.txtPaisaddress.Size = new System.Drawing.Size(185, 27);
            this.txtPaisaddress.TabIndex = 45;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(1164, 34);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 20);
            this.lblPais.TabIndex = 44;
            this.lblPais.Text = "País";
            // 
            // txtCidadeAddress
            // 
            this.txtCidadeAddress.Location = new System.Drawing.Point(797, 57);
            this.txtCidadeAddress.Name = "txtCidadeAddress";
            this.txtCidadeAddress.Size = new System.Drawing.Size(204, 27);
            this.txtCidadeAddress.TabIndex = 41;
            // 
            // cbxUFAddress
            // 
            this.cbxUFAddress.FormattingEnabled = true;
            this.cbxUFAddress.Location = new System.Drawing.Point(1007, 57);
            this.cbxUFAddress.Name = "cbxUFAddress";
            this.cbxUFAddress.Size = new System.Drawing.Size(151, 28);
            this.cbxUFAddress.TabIndex = 43;
            // 
            // lblUFAddress
            // 
            this.lblUFAddress.AutoSize = true;
            this.lblUFAddress.Location = new System.Drawing.Point(1008, 34);
            this.lblUFAddress.Name = "lblUFAddress";
            this.lblUFAddress.Size = new System.Drawing.Size(26, 20);
            this.lblUFAddress.TabIndex = 42;
            this.lblUFAddress.Text = "UF";
            // 
            // lblCidadeAddress
            // 
            this.lblCidadeAddress.AutoSize = true;
            this.lblCidadeAddress.Location = new System.Drawing.Point(794, 34);
            this.lblCidadeAddress.Name = "lblCidadeAddress";
            this.lblCidadeAddress.Size = new System.Drawing.Size(56, 20);
            this.lblCidadeAddress.TabIndex = 40;
            this.lblCidadeAddress.Text = "Cidade";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(6, 58);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(349, 27);
            this.txtLogradouro.TabIndex = 35;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(8, 35);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(87, 20);
            this.lblLogradouro.TabIndex = 34;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // IsBatizado
            // 
            this.IsBatizado.AutoSize = true;
            this.IsBatizado.Location = new System.Drawing.Point(9, 57);
            this.IsBatizado.Name = "IsBatizado";
            this.IsBatizado.Size = new System.Drawing.Size(222, 24);
            this.IsBatizado.TabIndex = 66;
            this.IsBatizado.Text = "Membro Batizado nas Águas";
            this.IsBatizado.UseVisualStyleBackColor = true;
            // 
            // ckbMembroCartao
            // 
            this.ckbMembroCartao.AutoSize = true;
            this.ckbMembroCartao.Location = new System.Drawing.Point(9, 85);
            this.ckbMembroCartao.Name = "ckbMembroCartao";
            this.ckbMembroCartao.Size = new System.Drawing.Size(189, 24);
            this.ckbMembroCartao.TabIndex = 67;
            this.ckbMembroCartao.Text = "Tem Cartão de Membro";
            this.ckbMembroCartao.UseVisualStyleBackColor = true;
            // 
            // gpDadosimportantes
            // 
            this.gpDadosimportantes.Controls.Add(this.ISBatizedWithSpirit);
            this.gpDadosimportantes.Controls.Add(this.ckbMembroCartao);
            this.gpDadosimportantes.Controls.Add(this.IsBatizado);
            this.gpDadosimportantes.Location = new System.Drawing.Point(1183, 318);
            this.gpDadosimportantes.Name = "gpDadosimportantes";
            this.gpDadosimportantes.Size = new System.Drawing.Size(350, 182);
            this.gpDadosimportantes.TabIndex = 8;
            this.gpDadosimportantes.TabStop = false;
            this.gpDadosimportantes.Text = "Informações Importantes";
            // 
            // ISBatizedWithSpirit
            // 
            this.ISBatizedWithSpirit.AutoSize = true;
            this.ISBatizedWithSpirit.Location = new System.Drawing.Point(9, 115);
            this.ISBatizedWithSpirit.Name = "ISBatizedWithSpirit";
            this.ISBatizedWithSpirit.Size = new System.Drawing.Size(280, 24);
            this.ISBatizedWithSpirit.TabIndex = 68;
            this.ISBatizedWithSpirit.Text = "Membro Batizado com Espírito Santo";
            this.ISBatizedWithSpirit.UseVisualStyleBackColor = true;
            // 
            // btnCaptureImagem
            // 
            this.btnCaptureImagem.Location = new System.Drawing.Point(12, 551);
            this.btnCaptureImagem.Name = "btnCaptureImagem";
            this.btnCaptureImagem.Size = new System.Drawing.Size(155, 45);
            this.btnCaptureImagem.TabIndex = 69;
            this.btnCaptureImagem.Text = "Capturar Imagem";
            this.btnCaptureImagem.UseVisualStyleBackColor = true;
            this.btnCaptureImagem.Click += new System.EventHandler(this.btnCaptureImagem_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(1423, 551);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 45);
            this.btnSalvar.TabIndex = 71;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnPesquisarMembro
            // 
            this.btnPesquisarMembro.Location = new System.Drawing.Point(173, 551);
            this.btnPesquisarMembro.Name = "btnPesquisarMembro";
            this.btnPesquisarMembro.Size = new System.Drawing.Size(160, 45);
            this.btnPesquisarMembro.TabIndex = 70;
            this.btnPesquisarMembro.Text = "Pesquisar Membro";
            this.btnPesquisarMembro.UseVisualStyleBackColor = true;
            this.btnPesquisarMembro.Click += new System.EventHandler(this.btnPesquisarMembro_Click);
            // 
            // btnGerarFamilia
            // 
            this.btnGerarFamilia.Location = new System.Drawing.Point(339, 551);
            this.btnGerarFamilia.Name = "btnGerarFamilia";
            this.btnGerarFamilia.Size = new System.Drawing.Size(160, 45);
            this.btnGerarFamilia.TabIndex = 72;
            this.btnGerarFamilia.Text = "Gerar Família";
            this.btnGerarFamilia.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarSetor
            // 
            this.btnCadastrarSetor.Location = new System.Drawing.Point(503, 551);
            this.btnCadastrarSetor.Name = "btnCadastrarSetor";
            this.btnCadastrarSetor.Size = new System.Drawing.Size(160, 45);
            this.btnCadastrarSetor.TabIndex = 73;
            this.btnCadastrarSetor.Text = "Cadastrar Setor";
            this.btnCadastrarSetor.UseVisualStyleBackColor = true;
            this.btnCadastrarSetor.Click += new System.EventHandler(this.btnCadastrarSetor_Click);
            // 
            // btnCadastrarIgreja
            // 
            this.btnCadastrarIgreja.Location = new System.Drawing.Point(669, 551);
            this.btnCadastrarIgreja.Name = "btnCadastrarIgreja";
            this.btnCadastrarIgreja.Size = new System.Drawing.Size(160, 45);
            this.btnCadastrarIgreja.TabIndex = 74;
            this.btnCadastrarIgreja.Text = "Cadastrar Igreja";
            this.btnCadastrarIgreja.UseVisualStyleBackColor = true;
            this.btnCadastrarIgreja.Click += new System.EventHandler(this.btnCadastrarIgreja_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 617);
            this.Controls.Add(this.btnCadastrarIgreja);
            this.Controls.Add(this.btnCadastrarSetor);
            this.Controls.Add(this.btnGerarFamilia);
            this.Controls.Add(this.btnPesquisarMembro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCaptureImagem);
            this.Controls.Add(this.gpDadosimportantes);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbDadosIgreja);
            this.Controls.Add(this.gbDadosPessoais);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro de Membros";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbDadosIgreja.ResumeLayout(false);
            this.gbDadosIgreja.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gpDadosimportantes.ResumeLayout(false);
            this.gpDadosimportantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label lblNomeMae;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.Label lblNomePai;
        private System.Windows.Forms.Label lblEstadoNascimento;
        private System.Windows.Forms.TextBox txtCidadeNascimento;
        private System.Windows.Forms.Label lblCidadeNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.ComboBox cbxUFNascimento;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox gbDadosIgreja;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtPaisaddress;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtCidadeAddress;
        private System.Windows.Forms.ComboBox cbxUFAddress;
        private System.Windows.Forms.Label lblUFAddress;
        private System.Windows.Forms.Label lblCidadeAddress;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.ComboBox cbxSetorAtual;
        private System.Windows.Forms.Label lblSetorAtual;
        private System.Windows.Forms.TextBox txtComplementoAddress;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumAddress;
        private System.Windows.Forms.Label lblNumAddress;
        private System.Windows.Forms.ComboBox cbxSetorAnterior;
        private System.Windows.Forms.Label lblSetorAnterior;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.ComboBox cbxEscolaridade;
        private System.Windows.Forms.Label lblEscolaridade;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskCellFone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lblDataDeBatismo;
        private System.Windows.Forms.Label lblIgrejaDeBatismo;
        private System.Windows.Forms.ComboBox cbxIgrejaDeBatismo;
        private System.Windows.Forms.ComboBox cbxFuncao;
        private System.Windows.Forms.Label lblFuncaonaIgreja;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ldlDataAdmissao;
        private System.Windows.Forms.ComboBox cbxOpcaoAdmissao;
        private System.Windows.Forms.Label lblAdmitidoPor;
        private System.Windows.Forms.ComboBox cbxCongregacaoAnterior;
        private System.Windows.Forms.Label lblCongregaçãoAnterior;
        private System.Windows.Forms.Label lblCongregacaoAtual;
        private System.Windows.Forms.CheckBox IsBatizado;
        private System.Windows.Forms.CheckBox ckbMembroCartao;
        private System.Windows.Forms.GroupBox gpDadosimportantes;
        private System.Windows.Forms.CheckBox ISBatizedWithSpirit;
        private System.Windows.Forms.Button btnCaptureImagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisarMembro;
        private System.Windows.Forms.Button btnGerarFamilia;
        private System.Windows.Forms.Button btnCadastrarSetor;
        private System.Windows.Forms.Button btnCadastrarIgreja;
        private System.Windows.Forms.ComboBox cbxCongregacaoAtual;
    }
}
