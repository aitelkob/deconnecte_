using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MetroUi
{
    public partial class Clientparville : MetroFramework.Forms.MetroForm
    {
        public Clientparville()
        {
            InitializeComponent();
        }

        private void Clientparville_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Ville";
            comboBox1.DataSource = Program.ds.Tables["Client"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataView dv = new DataView(Program.ds.Tables["Client"]);
            //dv.RowFilter = "Ville'" + comboBox1.Text + "'";
            //dataGridView1.DataSource = dv; 
        }
    }
}
