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
    public partial class Detail_command : MetroFramework.Forms.MetroForm
    {
        public Detail_command()
        {
            InitializeComponent();
        }

        private void Detail_command_Load(object sender, EventArgs e)
        {
            decimal prixTotal = 0, qtteTotal = 0;
            textBox_numCommande.Text = Program.cmd.ToString();

            DataRow dr = Program.ds.Tables["Command"].Rows.Find(Program.cmd);

            textBox_date.Text = dr["DateCom"].ToString();
            textBox_numClient.Text = dr["CodeCi"].ToString();

            DataRow[] rows = dr.GetChildRows("R_cmd_detail");

            dataGridView_detail.Rows.Clear();
            foreach (DataRow r in rows)
            {
                DataRow artRow = Program.ds.Tables["Article"].Rows.Find(r["CodeArt"]);
                dataGridView_detail.Rows.Add(r["CodeArt"], artRow["Designation"], artRow["PU"], r["Qte"]);

                prixTotal += decimal.Parse(artRow["PU"].ToString());
                qtteTotal += decimal.Parse(r["Qte"].ToString());
            }
            foreach (DataGridViewRow r in dataGridView_detail.Rows)
            {
                if (int.Parse(r.Cells[3].Value.ToString()) > 5)
                    r.DefaultCellStyle.BackColor = Color.LawnGreen;
            }

            
            //for (int i = 0; i < dataGridView_detail.Rows.Count; i++)
            //{
            //    int val = int.Parse(dataGridView_detail.Rows[i].Cells[3].Value.ToString());
            //    if (val < 5)
            //    {
            //        dataGridView_detail.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            //    }

            //}

            dataGridView_detail.Rows.Add("Total", "", prixTotal, qtteTotal);
            dataGridView_detail.Rows[dataGridView_detail.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView_detail.Rows[dataGridView_detail.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);
            dataGridView_detail.Rows[dataGridView_detail.Rows.Count - 1].ReadOnly = true;
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView_detail.Rows.Count; i++)
            //{
            //    //DataGridViewRow qp = dataGridView_detail.Rows[i];
            //    //DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)qp.Cells[4];

            //    //if (cell.Value != null && cell.Value.ToString() == "True")
            //    //{
            //    //    DataRow dr = Program.ds.Tables["Détail"].Rows.Find(qp.Cells[0].Value);
            //    //    dr.Delete();
            //    //    dataGridView_detail.Rows.RemoveAt(i);
            //    //}

            //    //if (dataGridView_detail.Rows[i].Cells["Supprimer"].Value.ToString() == "true") ;
            //    //{
            //    //    int codeP = int.Parse(dataGridView_detail.Rows[i].Cells[0].Value.ToString());
            //    //    int[] k =
            //    //    {
            //    //        codeP,Program.cmd;
            //    //    }

            //    //    DataRow dr = Program.ds.Tables["Détail"].Rows.Find(k);
            //    //    dr.Delete();
            //    //    dataGridView_detail.Rows.RemoveAt(i);

            //    //}
            //    }




            }
        }
    }
}
