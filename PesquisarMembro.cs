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
    public partial class PesquisarMembro : Form
    {
        DataTable dt = new DataTable();
        public PesquisarMembro()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void PesquisarMembro_Load(object sender, EventArgs e)
        {
            CarregarDatagridView();
        }

        private void CarregarDatagridView()
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";
            string query = "SELECT M.CPF, M.RG, M.FirstName, M.LastName, A.Address, A.Neighborhood, C.CellPhone, O.Name as Office, M.BirthDay FROM Members AS M "+
                            "LEFT JOIN Address AS A ON A.MembroCPF = M.CPF AND A.MembroRG = M.RG "+
                            "LEFT JOIN Contact AS C ON C.MembroCPF = M.CPF AND C.MembroRG = M.RG "+
                            "LEFT JOIN ProfessionalInfo AS P ON P.MembroCPF = M.CPF AND P.MembroRG = M.RG "+
                            "LEFT JOIN Office AS O ON P.Office = O.Name; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("O DataGridView não contem dados.");
            }
            else
            {
                if (txtPesquisar.Text == string.Empty)
                {
                    CarregarDatagridView();
                }
                FiltrarGrade();
            }
        }

        private void FiltrarGrade()
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";
            try 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var Query = "SELECT M.CPF, M.RG, M.FirstName, M.LastName, A.Address, A.Neighborhood, C.CellPhone, C.Email, O.Name as Office, M.BirthDay FROM Members AS M " +
                            "LEFT JOIN Address AS A ON A.MembroCPF = M.CPF AND A.MembroRG = M.RG " +
                            "LEFT JOIN Contact AS C ON C.MembroCPF = M.CPF AND C.MembroRG = M.RG " +
                            "LEFT JOIN ProfessionalInfo AS P ON P.MembroCPF = M.CPF AND P.MembroRG = M.RG " +
                            "LEFT JOIN Office AS O ON P.Office = O.Name WHERE M.RG ='"+txtPesquisar.Text+"' OR M.CPF ='"+ txtPesquisar.Text + "' OR M.FirstName ='"+ txtPesquisar.Text + "' OR M.LastName ='" + txtPesquisar.Text + "' OR C.CellPhone ='" + txtPesquisar.Text + "'";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, connection))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            dataAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount == 0)
            {
                MessageBox.Show("O DataGridView não contem dados.");
            }
            else
            {
                string RG = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                string CPF = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

                if (RG == null || CPF == null)
                {
                    MessageBox.Show("Escolha um Membro para Alterar os dados!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AlterarDadosMembro alterarDados = new AlterarDadosMembro(RG, CPF);
                alterarDados.ShowDialog();
            }  
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("O DataGridView não contem dados.");
            }
            else
            {
                string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string RG = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                    string CPF = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

                    DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //Excluir a linha correspondente da tabela "Address" no banco de dados
                        string sqlAddress = "DELETE FROM Address WHERE MembroRG = @RG AND MembroCPF = @CPF";
                        SqlCommand commandAddress = new SqlCommand(sqlAddress, connection);
                        commandAddress.Parameters.AddWithValue("@RG", RG);
                        commandAddress.Parameters.AddWithValue("@CPF", CPF);
                        connection.Open();
                        commandAddress.ExecuteNonQuery();
                        connection.Close();

                        //Excluir a linha correspondente da tabela "Contact" no banco de dados
                        string sqlContact = "DELETE FROM Contact WHERE MembroRG = @RG AND MembroCPF = @CPF";
                        SqlCommand commandContact = new SqlCommand(sqlContact, connection);
                        commandContact.Parameters.AddWithValue("@RG", RG);
                        commandContact.Parameters.AddWithValue("@CPF", CPF);
                        connection.Open();
                        commandContact.ExecuteNonQuery();
                        connection.Close();

                        //Excluir a linha correspondente da tabela "Contact" no banco de dados
                        string sqlProfessionalInfo = "DELETE FROM ProfessionalInfo WHERE MembroRG = @RG AND MembroCPF = @CPF";
                        SqlCommand commandProfessionalInfo = new SqlCommand(sqlProfessionalInfo, connection);
                        commandProfessionalInfo.Parameters.AddWithValue("@RG", RG);
                        commandProfessionalInfo.Parameters.AddWithValue("@CPF", CPF);
                        connection.Open();
                        commandProfessionalInfo.ExecuteNonQuery();
                        connection.Close();

                        //Excluir a linha correspondete da tabela "Members" do banco de dados
                        string sqlMembers = "DELETE FROM Members WHERE RG = @RG AND CPF = @CPF";
                        SqlCommand commandMembers = new SqlCommand(sqlMembers, connection);
                        commandMembers.Parameters.AddWithValue("@RG", RG);
                        commandMembers.Parameters.AddWithValue("@CPF", CPF);
                        connection.Open();
                        commandMembers.ExecuteNonQuery();
                        connection.Close();

                        DataGridViewRow row = dataGridView1.CurrentRow;
                        if (row != null)
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                    }
                }
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void GerarRelatorioIndividual() 
        {
            
        }

        private void GerarRelatorioGeral()
        {

        }
    }
}
