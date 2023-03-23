using System;
using System.Data;
using System.Data.SqlClient;
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


                SalvarImagem();
                //msg = "Salvando imagem de perfil do usuário...";
                //MessageBox.Show(msg);

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

            else if (dtpDataNascimento.Text == "")
            {
                MessageBox.Show("Informe a Data de Nascimento do Membro");
                dtpDataNascimento.Focus();
                return false;
            }
            return true;
        }
        private void GerenciarDiretorios() { }
        private void SalvarImagem() { }
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
