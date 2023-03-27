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
    public partial class CadastrarSetor : Form
    {
        public CadastrarSetor()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void CadastrarSetor_Load(object sender, EventArgs e)
        {
            ResetarCampos();
            CarregarDatagridView();
        }

        private void ResetarCampos()
        {
            txtNumeroSetor.Text = "";
            txtNomeSetor.Text = "";
            txtEnderecoSetor.Text = "";
            txtCidadeSetor.Text = "";
            txtUFSetor.Text = "";
            txtPaisSetor.Text = "";
            txtCepSetor.Text = "";
            txtPastorSetor.Text = "";
        }

        private void CarregarDatagridView()
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";
            string query = "SELECT * FROM Sector ORDER BY Number";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        private void btnCadastratSetor_Click(object sender, EventArgs e)
        {
            CadastraSetor();
            CarregarDatagridView();
        }

        private void CadastraSetor()
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";

            try
            {
                //Cria a conexão com o servidor SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Abre a conexão com o servidor
                    connection.Open();
                    string insertSectorSQL = "INSERT INTO Sector(Number, Name, Address, City, State, Country, Zip, Pastor, Registerdate, LastUpdateDate)" +
                                                         "VALUES(@number, @nome, @endereco, @cidade, @uf, @pais, @cep, @pastor, @datareg, @dataupdate);";

                    SqlCommand cmdSector = new SqlCommand(insertSectorSQL, connection);
                    cmdSector.Parameters.AddWithValue("@number", txtNumeroSetor.Text);
                    cmdSector.Parameters.AddWithValue("@nome",txtNomeSetor.Text);
                    cmdSector.Parameters.AddWithValue("@endereco",txtEnderecoSetor.Text);
                    cmdSector.Parameters.AddWithValue("@cidade",txtCidadeSetor.Text);
                    cmdSector.Parameters.AddWithValue("@uf",txtUFSetor.Text);
                    cmdSector.Parameters.AddWithValue("@pais",txtPaisSetor.Text);
                    cmdSector.Parameters.AddWithValue("@cep",txtCepSetor.Text);
                    cmdSector.Parameters.AddWithValue("@pastor",txtPastorSetor.Text);
                    cmdSector.Parameters.AddWithValue("@datareg", DateTime.Now);
                    cmdSector.Parameters.AddWithValue("@dataupdate", DateTime.Now);

                    cmdSector.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Setor foi cadastrado com sucesso!","Congratulations",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
