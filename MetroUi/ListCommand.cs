using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUi
{
    public partial class ListCommand : MetroFramework.Forms.MetroForm
    {
        public ListCommand()
        {
            InitializeComponent();
        }
        
        private void ListCommand_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "CodeCi";
            comboBox1.DataSource = Program.ds.Tables["Client"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_code.Text = comboBox1.SelectedValue.ToString();
            DataRow dr = Program.ds.Tables["Client"].Rows.Find(comboBox1.SelectedValue);
            label_ville.Text = dr["Ville"].ToString();
            DataRow [] rows = dr.GetChildRows("R_clt_cmd");
            dataGridView_commandes.Rows.Clear();
            foreach (DataRow r in rows)
            {
                dataGridView_commandes.Rows.Add(r[0], r[1]);
            }


        }

        private void dataGridView_commandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 2)
            {
                Program.cmd = int.Parse(dataGridView_commandes.Rows[e.RowIndex].Cells[0].Value.ToString());
                Detail_command d = new Detail_command();
                d.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
