using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            CarregarDados();
        }

        private void CarregarDados()
        {
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Endereço", typeof(string));
            dt.Columns.Add("Bairro", typeof(string));
            dt.Columns.Add("Celular", typeof(string));
            dt.Columns.Add("Cargo", typeof(string));
            dt.Columns.Add("Data Nascimento", typeof(string));

            

            dataGridView1.DataSource = dt;
        }

        private void PesquisarMembro_Load(object sender, EventArgs e)
        {
            
        }

    }
}
