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
    public partial class CadastrarFamilia : Form
    {
        public CadastrarFamilia()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnGerarFamilia_Click(object sender, EventArgs e)
        {
            InserirFamilia();
            CarregarDataGridView();
        }
        private void InserirFamilia()
        {
            var Pai = txtNomePaiFamilia.Text;
            var Mae = txtNomeMaeFamilia.Text;
            var Familia = string.Empty;
            if(Pai != null && Mae != null)
            {
                var nomesComuns = Pai.Split(' ').Intersect(Mae.Split(' '));
                Familia = string.Join(" ", nomesComuns);
            }
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
                        string insertFamilySQL = "INSERT INTO Family (Pai, Mae, Name) SELECT @pai, @mae, @familia WHERE NOT EXISTS(SELECT 1 FROM Family WHERE Name = @familia); ";

                        SqlCommand cmdFamily = new SqlCommand(insertFamilySQL, connection);

                        cmdFamily.Parameters.AddWithValue("@pai", txtNomePaiFamilia.Text);
                        cmdFamily.Parameters.AddWithValue("@mae", txtNomeMaeFamilia.Text);
                        cmdFamily.Parameters.AddWithValue("@familia", Familia);

                        cmdFamily.ExecuteNonQuery();

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
                MessageBox.Show("Erro ao conectar ao Servidor: " + ex.Message, "Erro ao conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CadastrarFamilia_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }
        
        private void CarregarDataGridView()
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";
            string query = "SELECT * FROM Family";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                dataGridViewFamily.DataSource = data.Tables[0];
                
            }
        }
    }
}
