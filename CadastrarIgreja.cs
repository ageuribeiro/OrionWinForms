using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrionWinForms
{
    public partial class CadastrarIgreja : Form
    {
        public CadastrarIgreja()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            CarregarSetor();
            CarregarUF();

        }


        private void CarregarSetor()
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
                    cbxSetor.DataSource = tabelaSetorAnterior;
                    cbxSetor.DisplayMember = "Name";
                    cbxSetor.ValueMember = "Id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarUF()
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

                    cbxUF.DataSource = tabelaUFNascimento;
                    cbxUF.DisplayMember = "Sigla";
                    cbxUF.ValueMember = "Id";
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexao.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {

                RegistrarnoBancoSQL();
                ResetarCampos();

            }


        }
        private bool ValidarDados()
        {
            if (txtNomeIgreja.Text == "")
            {
                MessageBox.Show("Informe o Nome do Membro");
                txtNomeIgreja.Focus();
                return false;
            }

            else if (txtEnderecoIgreja.Text == "")
            {
                MessageBox.Show("Informe o Sobrenome do Membro");
                txtEnderecoIgreja.Focus();
                return false;
            }
            return true;
        }

        private void RegistrarnoBancoSQL()
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";


            try
            {
                //Cria a conexão com o servidor SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Abre a conexão com o servidor
                    connection.Open();


                    try
                    {
                        //insert na tabela members
                        string insChurchSQL = "INSERT INTO Church (IdSector, Name, Address, City, State, Country, Zip, Pastor)VALUES(@sector,@nome,@endereco,@cidade,@estado,@pais,@cep,@pastor)" ;

                        SqlCommand cmdChurch = new SqlCommand(insChurchSQL, connection);
                        cmdChurch.Parameters.AddWithValue("@sector", cbxSetor.SelectedValue);
                        cmdChurch.Parameters.AddWithValue("@nome", txtNomeIgreja.Text);
                        cmdChurch.Parameters.AddWithValue("@endereco", txtEnderecoIgreja.Text);
                        cmdChurch.Parameters.AddWithValue("@cidade", txtCidadeIgreja.Text);
                        cmdChurch.Parameters.AddWithValue("@estado", cbxUF.Text);
                        cmdChurch.Parameters.AddWithValue("@pais", txtPais.Text);
                        cmdChurch.Parameters.AddWithValue("@cep", txtCepIgreja.Text);
                        cmdChurch.Parameters.AddWithValue("@pastor", txtPastorIgreja.Text);

                        cmdChurch.ExecuteNonQuery();

                        
                        MessageBox.Show("Registro inserido com sucesso", "Inserção de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (SqlException ex)
                    {
                       
                        MessageBox.Show("Erro ao inserir registro: " + ex.Message, "Erro ao inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
       }

        private void ResetarCampos()
        {
            // atribui valores vazios ou padrões aos controles
            txtNomeIgreja.Text = string.Empty;
            txtEnderecoIgreja.Text = string.Empty;
            txtCidadeIgreja.Text = string.Empty;
            txtPastorIgreja.Text = string.Empty;
            cbxSetor.SelectedIndex = -1;
            cbxUF.SelectedIndex = -1;
        }

        private void CadastrarIgreja_Load(object sender, EventArgs e)
        {
            CarregarDatagridView();
        }

        private void CarregarDatagridView()
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";
            string query = "SELECT * FROM Church";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }
    }
}
