using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace OrionWinForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dtpDataNascimento.Value = DateTime.Now.Date;
            dtpDataAdmissao.Value = DateTime.Now.Date;
            dtpDataBatismo.Value = DateTime.Now.Date;
            
            CarregarUFNascimento();
            CarregarUFAddress();
            CarregarGenero();
            CarregarEstadoCivil();
            CarregarEscolaridade();
            CarregarSetorAnterior();
            CarregarSetorAtual();
            CarregarAdmitidoPor();
            CarregarIgrejaAtual();
            CarregarIgrejaAnterior();
            CarregarFuncao();
            CarregarIgrejaBatismo();
        }
        private void CarregarUFNascimento()
        {
            //Define a variável de conexão com o banco de dados            
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT Id, Sigla, Nome FROM UF ORDER BY Sigla", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaUFNascimento = new DataTable();
                    tabelaUFNascimento.Load(reader);

                    cbxUFNascimento.DataSource = tabelaUFNascimento;
                    cbxUFNascimento.DisplayMember = "Sigla";
                    cbxUFNascimento.ValueMember = "Id";
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexao.Close();
            }
        }
        private void CarregarUFAddress()
        {
            //Define a variável de conexão com o banco de dados            
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT Id, Sigla, Nome FROM UF ORDER BY Sigla", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaUFAddress = new DataTable();
                    tabelaUFAddress.Load(reader);
                    cbxUFAddress.DataSource = tabelaUFAddress;
                    cbxUFAddress.DisplayMember = "Sigla";
                    cbxUFAddress.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexao.Close();
            }

        }
        private void CarregarGenero()
        {
            //Define a conexao com o banco de dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Gender ORDER BY Name", conexao);

                //abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaGenero = new DataTable();
                    tabelaGenero.Load(reader);
                    cbxGenero.DataSource = tabelaGenero;
                    cbxGenero.DisplayMember = "Name";
                    cbxGenero.ValueMember = "Id";

                    reader.Close();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarEstadoCivil()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM MaritalStatus ORDER BY MaritalStatusName", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaMaritalStatus = new DataTable();
                    tabelaMaritalStatus.Load(reader);
                    cbxEstadoCivil.DataSource = tabelaMaritalStatus;
                    cbxEstadoCivil.DisplayMember = "MaritalStatusName";
                    cbxEstadoCivil.ValueMember = "MaritalStatusID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarEscolaridade()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Escolaridade ORDER BY Escolaridade", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaEscolaridade = new DataTable();
                    tabelaEscolaridade.Load(reader);
                    cbxEscolaridade.DataSource = tabelaEscolaridade;
                    cbxEscolaridade.DisplayMember = "Escolaridade";
                    cbxEscolaridade.ValueMember = "Id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarSetorAnterior()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Sector ORDER BY Number", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaSetorAnterior = new DataTable();
                    tabelaSetorAnterior.Load(reader);
                    cbxSetorAnterior.DataSource = tabelaSetorAnterior;
                    cbxSetorAnterior.DisplayMember = "Name";
                    cbxSetorAnterior.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarSetorAtual()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Sector ORDER BY Number", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaSetorAtual = new DataTable();
                    tabelaSetorAtual.Load(reader);
                    cbxSetorAtual.DataSource = tabelaSetorAtual;
                    cbxSetorAtual.DisplayMember = "Name";
                    cbxSetorAtual.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarIgrejaAnterior()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Church ORDER BY IdSector", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaIgrejaAnterior = new DataTable();
                    tabelaIgrejaAnterior.Load(reader);
                    cbxCongregacaoAnterior.DataSource = tabelaIgrejaAnterior;
                    cbxCongregacaoAnterior.DisplayMember = "Name";
                    cbxCongregacaoAnterior.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarIgrejaAtual()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Church ORDER BY IdSector", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaIgrejaAtual = new DataTable();
                    tabelaIgrejaAtual.Load(reader);
                    cbxCongregacaoAtual.DataSource = tabelaIgrejaAtual;
                    cbxCongregacaoAtual.DisplayMember = "Name";
                    cbxCongregacaoAtual.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarAdmitidoPor()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM AdmitidoPor ORDER BY Nome", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaAdmitidoPor = new DataTable();
                    tabelaAdmitidoPor.Load(reader);
                    cbxOpcaoAdmissao.DataSource = tabelaAdmitidoPor;
                    cbxOpcaoAdmissao.DisplayMember = "Nome";
                    cbxOpcaoAdmissao.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarFuncao()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Office ORDER BY Id", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaFuncao = new DataTable();
                    tabelaFuncao.Load(reader);
                    cbxFuncao.DataSource = tabelaFuncao;
                    cbxFuncao.DisplayMember = "Name";
                    cbxFuncao.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarIgrejaBatismo()
        {
            {
                //Define a conexao com o Banco de Dados
                using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
                {
                    //Define o comando
                    SqlCommand command = new SqlCommand(@"SELECT * FROM Church ORDER BY IdSector", conexao);

                    //Abre conexao
                    conexao.Open();

                    //Se ocorrer conexao com o banco de dados
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable tabelaIgrejaBatismo = new DataTable();
                        tabelaIgrejaBatismo.Load(reader);
                        cbxIgrejaDeBatismo.DataSource = tabelaIgrejaBatismo;
                        cbxIgrejaDeBatismo.DisplayMember = "Name";
                        cbxIgrejaDeBatismo.ValueMember = "Id";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (ValidarDados())
            {
                GerenciarDiretorios();

                GerarArquivoPdf();
                //msg = "Gerando arquivo em formato PDF...";
                //MessageBox.Show(msg);

                GerarArquivoCSV();
                //msg = "Gerando arquivo em formato CSV...";
                //MessageBox.Show(msg);

                GerarArquivoJSON();
                //msg = "Gerando arquivo em fomrato JSON...";
                //MessageBox.Show(msg);

                RegistrarnoBancoSQL();
                //msg = "Registrando informações no banco de dados...";
                //MessageBox.Show(msg);
            }
        }
        private bool ValidarDados()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o Nome do Membro");
                txtNome.Focus();
                return false;
            }
            else if (txtSobrenome.Text == "")
            {
                MessageBox.Show("Informe o Sobrenome do Membro");
                txtSobrenome.Focus();
                return false;
            }

            else if (txtNomePai.Text == "")
            {
                MessageBox.Show("Informe o Nome do Pai do Membro");
                txtNomePai.Focus();
                return false;
            }

            else if (txtNomeMae.Text == "")
            {
                MessageBox.Show("Informe o Nome da Mãe do Membro");
                txtNomeMae.Focus();
                return false;
            }

            else if (this.dtpDataNascimento.Value == DateTime.Now.Date)
            {
                MessageBox.Show("Informe a Data de Nascimento do Membro");
                dtpDataNascimento.Focus();
                return false;
            }

            else if (txtCidadeNascimento.Text == "")
            {
                MessageBox.Show("Informe a Cidade de Nascimento do Membro");
                txtCidadeNascimento.Focus();
                return false;
            }

            else if (txtNacionalidade.Text == "")
            {
                MessageBox.Show("Informe a Nacionalidade do Membro");
                txtNacionalidade.Focus();
                return false;
            }

            else if (txtIdade.Text == "")
            {
                MessageBox.Show("Informe a Idade do Membro");
                txtIdade.Focus();
                return false;
            }

            else if (mskRG.Text == "" || mskRG.Text== "00,000,000-0" ||mskRG.Text== "  .   .   -")
            {
                MessageBox.Show("Informe o número do RG do Membro");
                mskRG.Focus();
                return false;
            }

            else if (mskCPF.Text =="" || mskCPF.Text== "000,000,000-00" || mskCPF.Text== "   .   .   -")
            {
                MessageBox.Show("Informe o número do CPF do Membro");
                mskCPF.Focus();
                return false;
            }

            else if (cbxGenero.Text == "")
            {
                MessageBox.Show("Escolha o Gênero do Membro");
                cbxGenero.Focus();
                return false;
            }

            else if (cbxEstadoCivil.Text == "")
            {
                MessageBox.Show("Escolha o Estado Civil do Membro");
                cbxEstadoCivil.Focus();
                return false;
            }
            
            else if (mskCellFone.Text == "" || mskCellFone.Text== "(99) 00000-0000" || mskCellFone.Text== "(  )      -")
            {
                MessageBox.Show("Informe o número de Telefone do Membro");
                mskCellFone.Focus();
                return false;
            }

            else if (mskEmail.Text == "" )
            {
                MessageBox.Show("Informe o Email do Membro");
                mskEmail.Focus();
                return false;
            }

            else if (cbxEscolaridade.Text == "")
            {
                MessageBox.Show("Escolha a Escolaridade do Membro");
                cbxEscolaridade.Focus();
                return false;
            }

            else if (txtProfissao.Text == "")
            {
                MessageBox.Show("Informe a profissão do Membro");
                txtProfissao.Focus();
                return false;
            }

            else if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Informe o Endereço do Membro");
                txtLogradouro.Focus();
                return false;
            }

            else if (txtNumAddress.Text == "")
            {
                MessageBox.Show("Informe o Número de Residência do Membro");
                txtNumAddress.Focus();
                return false;
            }

            else if (txtComplementoAddress.Text == "")
            {
                MessageBox.Show("Informe o Complemento da Residência do Membro");
                txtComplementoAddress.Focus();
                return false;
            }

            else if (txtCidadeAddress.Text == "")
            {
                MessageBox.Show("Informe a Cidade da Residência do Membro");
                txtCidadeAddress.Focus();
                return false;
            }
            
            else if (cbxUFAddress.Text == "")
            {
                MessageBox.Show("Informe o Estado da Residência do Membro");
                cbxUFAddress.Focus();
                return false;
            }
            
            else if (txtPaisaddress.Text == "")
            {
                MessageBox.Show("Informe o País da Residência do Membro");
                txtPaisaddress.Focus();
                return false;
            }

            else if (mskCEPAddress.Text == "" || mskCEPAddress.Text == "00000-000" || mskCEPAddress.Text== "     -")
            {
                MessageBox.Show("Informe o CEP da Residência do Membro");
                mskCEPAddress.Focus();
                return false;
            }

            else if (cbxSetorAtual.Text == "")
            {
                MessageBox.Show("Informe o Setor Atual do Membro");
                cbxSetorAtual.Focus();
                return false;
            }

            else if (cbxSetorAnterior.Text == "")
            {
                MessageBox.Show("Informe o Setor Anterior do Membro");
                cbxSetorAnterior.Focus();
                return false;
            }

            else if (cbxCongregacaoAtual.Text == "")
            {
                MessageBox.Show("Informe a Congregação Atual do Membro");
                cbxCongregacaoAtual.Focus();
                return false;
            }

            else if (cbxCongregacaoAnterior.Text == "")
            {
                MessageBox.Show("Informe a Congregação Anterior do Membro");
                cbxCongregacaoAnterior.Focus();
                return false;
            }

            else if (cbxOpcaoAdmissao.Text == "")
            {
                MessageBox.Show("Informe o opção de Admissão do Membro");
                cbxOpcaoAdmissao.Focus();
                return false;
            }

            else if (this.dtpDataAdmissao.Value == DateTime.Now.Date)
            {
                MessageBox.Show("Informe a Data de Admissão do Membro");
                dtpDataAdmissao.Focus();
                return false;
            }

            else if (this.dtpDataBatismo.Value == DateTime.Now.Date)
            {
                MessageBox.Show("Informe a Data de Batismo do Membro");
                dtpDataBatismo.Focus();
                return false;
            }

            else if (cbxFuncao.Text == "")
            {
                MessageBox.Show("Informe a Função Atual do Membro");
                cbxFuncao.Focus();
                return false;
            }

            else if (cbxIgrejaDeBatismo.Text == "")
            {
                MessageBox.Show("Informe a Congregação de Batismo do Membro");
                cbxIgrejaDeBatismo.Focus();
                return false;
            }

            return true;
        }
        private void GerenciarDiretorios() 
        {
            var nome = txtNome.Text;
            var sobrenome = txtSobrenome.Text;
            var nomecompleto = nome + sobrenome;
            //Criar diretorio 
            Directory.CreateDirectory(@"c:\AppOrion\Dados\Membros\" + nomecompleto);
            MessageBox.Show("Pasta criada com sucesso!");
        }
        private void GerarArquivoPdf() { }
        private void GerarArquivoCSV() { }
        private void GerarArquivoJSON() { }
        private void RegistrarnoBancoSQL() { }
        private void btnCaptureImagem_Click(object sender, EventArgs e)
        {
            CapturarImagem frmCapturarImagem = new CapturarImagem();
            frmCapturarImagem.Show();
        }
        private void btnPesquisarMembro_Click(object sender, EventArgs e)
        {
            PesquisarMembro frmPesquisarMembro = new PesquisarMembro();
            frmPesquisarMembro.Show();
        }
        private void btnCadastrarSetor_Click(object sender, EventArgs e)
        {
            CadastrarSetor frmCadastrarSetor = new CadastrarSetor();
            frmCadastrarSetor.Show();
        }
        private void btnCadastrarIgreja_Click(object sender, EventArgs e)
        {
            CadastrarIgreja frmCadastrarIgreja = new CadastrarIgreja();
            frmCadastrarIgreja.Show();
        }
    }
}
