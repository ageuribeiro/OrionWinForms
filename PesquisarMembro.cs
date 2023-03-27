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



    }
}
