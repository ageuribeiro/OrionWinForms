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
    public partial class AlterarDadosMembro : Form
    {
        string RG = "";
        string CPF = "";
        public AlterarDadosMembro(string RG, string CPF)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.RG = RG;
            this.CPF = CPF;
            GetMembro(RG, CPF);
            CarregarFuncao();
        }

        private void GetMembro(string RG, string CPF)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True"))
            {
                //Abre conexao
                connection.Open();

                //Define o comando
                //select na tabela members
                string selectMemberSQL = "SELECT M.CPF, M.RG, M.FirstName, M.LastName, A.Address, A.Neighborhood, C.CellPhone, C.Email, O.Name as Office, M.BirthDay FROM Members AS M " +
                            "LEFT JOIN Address AS A ON A.MembroCPF = M.CPF AND A.MembroRG = M.RG " +
                            "LEFT JOIN Contact AS C ON C.MembroCPF = M.CPF AND C.MembroRG = M.RG " +
                            "LEFT JOIN ProfessionalInfo AS P ON P.MembroCPF = M.CPF AND P.MembroRG = M.RG " +
                            "LEFT JOIN Office AS O ON P.Office = O.Name WHERE RG = @RG AND CPF = @CPF";

                using (SqlCommand command = new SqlCommand(selectMemberSQL, connection))
                {
                    command.Parameters.AddWithValue("@RG", RG);
                    command.Parameters.AddWithValue("@CPF", CPF);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            if (dataReader.Read())
                            {
                                // obter o valor do campo Office
                                string office = dataReader["Office"].ToString();


                                mskRG.Text = dataReader["RG"].ToString();
                                mskCPF.Text = dataReader["CPF"].ToString();
                                txtNome.Text = dataReader["FirstName"].ToString();
                                txtSobrenome.Text = dataReader["LastName"].ToString();
                                cbxFuncao.Text = dataReader["Office"].ToString();
                                txtAddress.Text = dataReader["Address"].ToString();
                                txtNeighborhood.Text = dataReader["Neighborhood"].ToString();
                                mskCellFone.Text = dataReader["CellPhone"].ToString();
                                mskEmail.Text = dataReader["Email"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ASUSX512FJC\SQLSERVER;Initial Catalog=AppConnectedChurchDatabase;Integrated Security=True";


            try
            {
                // Atualiza a tabela Members
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    string sql = "UPDATE Members SET FirstName = @FirstName, LastName = @LastName, BirthDay = @BirthDate WHERE RG = @RG AND CPF = @CPF";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@FirstName", txtNome.Text);
                        command.Parameters.AddWithValue("@LastName", txtSobrenome.Text);
                        command.Parameters.AddWithValue("@BirthDate", dtpDataNascimento.Value.Date);
                        command.Parameters.AddWithValue("@RG", mskRG.Text.Replace(".", "").Replace("-", ""));
                        command.Parameters.AddWithValue("@CPF", mskCPF.Text.Replace(".", "").Replace("-", ""));


                        await command.ExecuteNonQueryAsync();
                    }
                }

                // Atualiza a tabela Address
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Address SET Address = @Address, Neighborhood = @Neighborhood WHERE MembroRG = @RG AND MembroCPF = @CPF";
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Neighborhood", txtNeighborhood.Text);
                        command.Parameters.AddWithValue("@RG", mskRG.Text.Replace(".", "").Replace("-", ""));
                        command.Parameters.AddWithValue("@CPF", mskCPF.Text.Replace(".", "").Replace("-", ""));


                        await command.ExecuteNonQueryAsync();
                    }
                }

                // Atualiza a tabela Contact
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Contact SET CellPhone = @CellPhone, Email = @Email WHERE MembroRG = @RG AND MembroCPF = @CPF";
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@CellPhone", mskCellFone.Text.Replace("(", "").Replace(")", "").Replace("-", ""));
                        command.Parameters.AddWithValue("@Email", mskEmail.Text);
                        command.Parameters.AddWithValue("@RG", mskRG.Text.Replace(".", "").Replace("-", ""));
                        command.Parameters.AddWithValue("@CPF", mskCPF.Text.Replace(".", "").Replace("-", ""));


                        await command.ExecuteNonQueryAsync();
                    }
                }

                // Atualiza a tabela ProfessionalInfo
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE ProfessionalInfo SET Office = @Office WHERE MembroRG = @RG AND MembroCPF = @CPF";
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Office", cbxFuncao.Text);
                        command.Parameters.AddWithValue("@RG", mskRG.Text.Replace(".", "").Replace("-", ""));
                        command.Parameters.AddWithValue("@CPF", mskCPF.Text.Replace(".", "").Replace("-", ""));


                        await command.ExecuteNonQueryAsync();
                    }
                }
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

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
    }
}

