namespace MetroUi
{
    partial class Detail_command
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_supprimer = new System.Windows.Forms.Button();
            this.dataGridView_detail = new System.Windows.Forms.DataGridView();
            this.textBox_numClient = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_numCommande = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtteCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(405, 381);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 18;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // dataGridView_detail
            // 
            this.dataGridView_detail.AllowUserToAddRows = false;
            this.dataGridView_detail.AllowUserToDeleteRows = false;
            this.dataGridView_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumP,
            this.Description,
            this.Prix,
            this.QtteCom,
            this.Supprimer});
            this.dataGridView_detail.Location = new System.Drawing.Point(23, 187);
            this.dataGridView_detail.Name = "dataGridView_detail";
            this.dataGridView_detail.Size = new System.Drawing.Size(470, 180);
            this.dataGridView_detail.TabIndex = 17;
            // 
            // textBox_numClient
            // 
            this.textBox_numClient.Enabled = false;
            this.textBox_numClient.Location = new System.Drawing.Point(158, 152);
            this.textBox_numClient.Name = "textBox_numClient";
            this.textBox_numClient.Size = new System.Drawing.Size(134, 20);
            this.textBox_numClient.TabIndex = 16;
            // 
            // textBox_date
            // 
            this.textBox_date.Enabled = false;
            this.textBox_date.Location = new System.Drawing.Point(158, 120);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(134, 20);
            this.textBox_date.TabIndex = 15;
            // 
            // textBox_numCommande
            // 
            this.textBox_numCommande.Enabled = false;
            this.textBox_numCommande.Location = new System.Drawing.Point(158, 91);
            this.textBox_numCommande.Name = "textBox_numCommande";
            this.textBox_numCommande.Size = new System.Drawing.Size(134, 20);
            this.textBox_numCommande.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Num Client : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Num Commande : ";
            // 
            // NumP
            // 
            this.NumP.HeaderText = "NumP";
            this.NumP.Name = "NumP";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // QtteCom
            // 
            this.QtteCom.HeaderText = "QtteCom";
            this.QtteCom.Name = "QtteCom";
            // 
            // Supprimer
            // 
            this.Supprimer.FalseValue = "False";
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.TrueValue = "True";
            // 
            // Detail_command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 481);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.dataGridView_detail);
            this.Controls.Add(this.textBox_numClient);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_numCommande);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Detail_command";
            this.Text = "Detail command";
            this.Load += new System.EventHandler(this.Detail_command_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.DataGridView dataGridView_detail;
        private System.Windows.Forms.TextBox textBox_numClient;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_numCommande;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtteCom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Supprimer;
    }
}