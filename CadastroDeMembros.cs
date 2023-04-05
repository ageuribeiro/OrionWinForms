using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace OrionWinForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            CarregarStatus();
            CarregarFamily();
        }
        private void CarregarUFNascimento()
        {
        
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
        private void CarregarStatus()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Status ORDER BY Status", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaStatus = new DataTable();
                    tabelaStatus.Load(reader);
                    cbxStatus.DataSource = tabelaStatus;
                    cbxStatus.DisplayMember = "Nome";
                    cbxStatus.ValueMember = "Status";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarFamily()
        {
            //Define a conexao com o Banco de Dados
            using (SqlConnection conexao = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Define o comando
                SqlCommand command = new SqlCommand(@"SELECT * FROM Family ORDER BY Name", conexao);

                //Abre conexao
                conexao.Open();

                //Se ocorrer conexao com o banco de dados
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable tabelaFamily = new DataTable();
                    tabelaFamily.Load(reader);
                    cbxFamily.DataSource = tabelaFamily;
                    cbxFamily.DisplayMember = "Name";
                    cbxFamily.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (ValidarDados())
            {
                GerenciarDiretorios();
                RegistrarnoBancoSQL();

                GerarArquivoPdf();

                ResetarCampos();

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

            else if (mskRG.Text == "" || mskRG.Text == "00,000,000-0" || mskRG.Text == "  .   .   -")
            {
                MessageBox.Show("Informe o número do RG do Membro");
                mskRG.Focus();
                return false;
            }

            else if (mskCPF.Text == "" || mskCPF.Text == "000,000,000-00" || mskCPF.Text == "   .   .   -")
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

            else if (mskCellFone.Text == "" || mskCellFone.Text == "(99) 00000-0000" || mskCellFone.Text == "(  )      -")
            {
                MessageBox.Show("Informe o número de Telefone do Membro");
                mskCellFone.Focus();
                return false;
            }

            else if (mskEmail.Text == "")
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

            else if(txtNeighborhood.Text == "")
            {
                MessageBox.Show("Informe o Bairro Residencial do Membro");
                txtNeighborhood.Focus();
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

            else if (mskCEPAddress.Text == "" || mskCEPAddress.Text == "00000-000" || mskCEPAddress.Text == "     -")
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

            else if (cbxFamily.Text == "")
            {
                MessageBox.Show("Informe a Familia do Membro");
                cbxFamily.Focus();
                return false;
            }

            else if(cbxStatus.Text == "")
            {
                MessageBox.Show("Informe o Status atual do Membro");
                cbxStatus.Focus();
                return false;
            }

            return true;
        }
        private void GerenciarDiretorios()
        {
            var nome = txtNome.Text;
            //Criar diretorio 
            Directory.CreateDirectory(@"c:\AppOrion\Dados\Membros\" + nome);
            MessageBox.Show("Pasta criada com sucesso!");
        }
        private void RegistrarnoBancoSQL()
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";
            string rg = mskRG.Text;
            string cpf = mskCPF.Text;

            try
            {
                //Cria a conexão com o servidor SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Abre a conexão com o servidor
                    connection.Open();

                    //Inicia uma nova Transação
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        //insert na tabela members
                        string insertMemberSQL = "INSERT INTO Members( IdFamily, IdMaritalStatus, FirstName, LastName, Father, Mother, BirthDay, BirthPlace, BirthPlaceUF, Nationality, RG, CPF, Gender, Status, PictureProfile, Age, RegisterDate, LastUpdateDate)" +
                                                            " VALUES( @familia, @estCivil, @nome, @sobrenome, @pai, @mae, @dataNascimento, @cidadeNascimento, @ufNascimento, @nacionalidade, @rg, @cpf, @genero, @status, @pictureProfile, @idade, @dateregister, @dateupdate); SELECT SCOPE_IDENTITY()";

                        SqlCommand cmdMember = new SqlCommand(insertMemberSQL, connection, transaction);
                        cmdMember.Parameters.AddWithValue("@familia", cbxFamily.SelectedValue);
                        cmdMember.Parameters.AddWithValue("@estCivil", cbxEstadoCivil.SelectedValue);
                        cmdMember.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmdMember.Parameters.AddWithValue("@sobrenome", txtSobrenome.Text);
                        cmdMember.Parameters.AddWithValue("@pai", txtNomePai.Text);
                        cmdMember.Parameters.AddWithValue("@mae", txtNomeMae.Text);
                        cmdMember.Parameters.AddWithValue("@dataNascimento", dtpDataNascimento.Value);
                        cmdMember.Parameters.AddWithValue("@cidadeNascimento", txtCidadeNascimento.Text);
                        cmdMember.Parameters.AddWithValue("@ufNascimento", cbxUFNascimento.Text);
                        cmdMember.Parameters.AddWithValue("@nacionalidade", txtNacionalidade.Text);
                        cmdMember.Parameters.AddWithValue("@rg", mskRG.Text.Replace(".","").Replace("-",""));
                        cmdMember.Parameters.AddWithValue("@cpf", mskCPF.Text.Replace(".", "").Replace("-", ""));
                        cmdMember.Parameters.AddWithValue("@genero", cbxGenero.Text);
                        cmdMember.Parameters.AddWithValue("@status", cbxStatus.Text);
                        var nomeDoMembro = txtNome.Text;
                        var pictureProfile = @"c:\AppOrion\Dados\Membros\" + nomeDoMembro + "\\" + nomeDoMembro + ".jpg";
                        cmdMember.Parameters.AddWithValue("@pictureProfile", pictureProfile);
                        cmdMember.Parameters.AddWithValue("@idade", txtIdade.Text);
                        cmdMember.Parameters.AddWithValue("@dateregister", DateTime.UtcNow);
                        cmdMember.Parameters.AddWithValue("@dateupdate", DateTime.UtcNow);



                        //insert na tabela contact
                        string insertContactSQL = "INSERT INTO Contact(MembroCPF, MembroRG, CellPhone, Email)VALUES(@cpf, @rg, @cel, @mail); SELECT SCOPE_IDENTITY()";
                        SqlCommand cmdContact = new SqlCommand(insertContactSQL, connection, transaction);
                        cmdContact.Parameters.AddWithValue("@cel", mskCellFone.Text.Replace("(","").Replace(")","").Replace("-",""));
                        cmdContact.Parameters.AddWithValue("@mail", mskEmail.Text);
                        cmdContact.Parameters.AddWithValue("@rg", mskRG.Text.Replace(".", "").Replace("-", ""));
                        cmdContact.Parameters.AddWithValue("@cpf", mskCPF.Text.Replace(".", "").Replace("-", ""));


                        //insert na tabela address
                        string insertAddressSQL = "INSERT INTO Address(MembroCPF, MembroRG, Address, Neighborhood, City, State, Country, Zip)"+
                                                               "VALUES(@cpf, @rg, @address, @neighborhood, @city, @uf, @country, @cep); SELECT SCOPE_IDENTITY()";
                        SqlCommand cmdAddress = new SqlCommand(insertAddressSQL, connection, transaction);
                        var Address = txtLogradouro.Text + ", " + txtNumAddress.Text + ", " + txtComplementoAddress.Text;
                        cmdAddress.Parameters.AddWithValue("@address", Address);
                        cmdAddress.Parameters.AddWithValue("@city", txtCidadeAddress.Text);
                        cmdAddress.Parameters.AddWithValue("@uf", cbxUFAddress.Text);
                        cmdAddress.Parameters.AddWithValue("@country", txtPaisaddress.Text);
                        cmdAddress.Parameters.AddWithValue("@cep", mskCEPAddress.Text.Replace("-",""));
                        cmdAddress.Parameters.AddWithValue("@rg", mskRG.Text.Replace(".", "").Replace("-", ""));
                        cmdAddress.Parameters.AddWithValue("@cpf", mskCPF.Text.Replace(".", "").Replace("-", ""));
                        cmdAddress.Parameters.AddWithValue("@neighborhood", txtNeighborhood.Text);


                        //insert na tabela professionalINfo
                        string insertProfessionalInfoSQL = "INSERT INTO ProfessionalInfo(MembroCPF, MembroRG, Schooling, Profession, AdmissionDateChurch, HaveCardChurch, IsBaptizedWaterChurch, IsBaptizedSpiritChurch, AdmissionByChurch, CurrentSector, PreviousSector, CurrentChurch, PreviousChurch, Office, BaptizedChurch, BaptizedDate)" +
                                                                                    "VALUES(@cpf, @rg, @escolar, @profissao, @dtAdmissao, @isMemberCard, @IsBaptized, @isSpirit, @admitidoPor, @setorAtual, @setorAnterior, @congrAtual, @congrAnterior, @function, @congrBatismo, @dtBatismo); SELECT SCOPE_IDENTITY()";
                        SqlCommand cmdProfessionalInfo = new SqlCommand(insertProfessionalInfoSQL, connection, transaction);
                        cmdProfessionalInfo.Parameters.AddWithValue("@rg", mskRG.Text.Replace(".", "").Replace("-", ""));
                        cmdProfessionalInfo.Parameters.AddWithValue("@cpf", mskCPF.Text.Replace(".", "").Replace("-", ""));
                        cmdProfessionalInfo.Parameters.AddWithValue("@escolar", cbxEscolaridade.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@profissao", txtProfissao.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@dtAdmissao", dtpDataAdmissao.Value.Date);
                        cmdProfessionalInfo.Parameters.AddWithValue("@isMemberCard", isMemberCard.Checked);
                        cmdProfessionalInfo.Parameters.AddWithValue("@IsBaptized", IsBatizado.Checked);
                        cmdProfessionalInfo.Parameters.AddWithValue("@isSpirit", IsBatizedWithSpirit.Checked);
                        cmdProfessionalInfo.Parameters.AddWithValue("@admitidoPor", cbxOpcaoAdmissao.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@setorAtual", cbxSetorAtual.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@setorAnterior", cbxSetorAnterior.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@congrAtual", cbxCongregacaoAtual.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@congrAnterior", cbxCongregacaoAnterior.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@function", cbxFuncao.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@congrBatismo", cbxIgrejaDeBatismo.Text);
                        cmdProfessionalInfo.Parameters.AddWithValue("@dtBatismo", dtpDataBatismo.Value.Date);

                        cmdMember.ExecuteNonQuery();
                        cmdContact.ExecuteNonQuery();
                        cmdAddress.ExecuteNonQuery();
                        cmdProfessionalInfo.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Registro inserido com sucesso", "Inserção de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao inserir registro: " + ex.Message, "Erro ao inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao Servidor: " + ex.Message, "Erro ao conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetarCampos()
        {
            // atribui valores vazios ou padrões aos controles
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtNomePai.Text = string.Empty;
            txtNomeMae.Text = string.Empty;
            dtpDataNascimento.Value = DateTime.Now;
            txtCidadeNascimento.Text = string.Empty;
            cbxUFNascimento.SelectedIndex = -1;
            txtNacionalidade.Text = string.Empty;
            txtIdade.Text = string.Empty;
            mskRG.Text = string.Empty;
            mskCPF.Text = string.Empty;
            cbxGenero.SelectedIndex = -1;
            cbxEstadoCivil.SelectedIndex = -1;
            mskCellFone.Text = string.Empty;
            mskEmail.Text = string.Empty;
            cbxEscolaridade.SelectedIndex = -1;
            txtProfissao.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumAddress.Text = string.Empty;
            txtComplementoAddress.Text = string.Empty;
            txtCidadeAddress.Text = string.Empty;
            cbxUFAddress.SelectedIndex = -1;
            txtPaisaddress.Text = string.Empty;
            mskCEPAddress.Text = string.Empty;
            cbxSetorAtual.SelectedIndex = -1;
            cbxSetorAnterior.SelectedIndex = -1;
            cbxCongregacaoAtual.SelectedIndex = -1;
            cbxCongregacaoAnterior.SelectedIndex = -1;
            cbxOpcaoAdmissao.SelectedIndex = -1;
            dtpDataAdmissao.Value = DateTime.Now;
            cbxFuncao.SelectedIndex = -1;
            cbxIgrejaDeBatismo.SelectedIndex = -1;
            dtpDataBatismo.Value = DateTime.Now;
            IsBatizado.Checked = false;
            isMemberCard.Checked = false;
            IsBatizedWithSpirit.Checked = false;
            cbxStatus.SelectedIndex = -1;

        }
       
        private void GerarArquivoPdf() { }

        private void btnCaptureImagem_Click(object sender, EventArgs e)
        {
            CapturarImagem frmCapturarImagem = new CapturarImagem();
            frmCapturarImagem.ShowDialog();
        }
        private void btnPesquisarMembro_Click(object sender, EventArgs e)
        {
            PesquisarMembro frmPesquisarMembro = new PesquisarMembro();
            frmPesquisarMembro.ShowDialog();
        }
        private void btnCadastrarSetor_Click(object sender, EventArgs e)
        {
            CadastrarSetor frmCadastrarSetor = new CadastrarSetor();
            frmCadastrarSetor.ShowDialog();
        }
        private void btnCadastrarIgreja_Click(object sender, EventArgs e)
        {
            CadastrarIgreja frmCadastrarIgreja = new CadastrarIgreja();
            frmCadastrarIgreja.ShowDialog();
        }

        private void btnGerarFamilia_Click(object sender, EventArgs e)
        {
            CadastrarFamilia frmCadastrarFamilia = new CadastrarFamilia();
            frmCadastrarFamilia.ShowDialog();
        }

    }
}
