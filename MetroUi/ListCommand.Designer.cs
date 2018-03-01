namespace MetroUi
{
    partial class ListCommand
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_code = new System.Windows.Forms.Label();
            this.label_ville = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_commandes = new System.Windows.Forms.DataGridView();
            this.NumCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_commandes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ville :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(152, 150);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(10, 13);
            this.label_code.TabIndex = 4;
            this.label_code.Text = " ";
            // 
            // label_ville
            // 
            this.label_ville.AutoSize = true;
            this.label_ville.Location = new System.Drawing.Point(268, 150);
            this.label_ville.Name = "label_ville";
            this.label_ville.Size = new System.Drawing.Size(0, 13);
            this.label_ville.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Liste des Commandes";
            // 
            // dataGridView_commandes
            // 
            this.dataGridView_commandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_commandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_commandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCom,
            this.Date,
            this.Detail});
            this.dataGridView_commandes.Location = new System.Drawing.Point(23, 208);
            this.dataGridView_commandes.Name = "dataGridView_commandes";
            this.dataGridView_commandes.Size = new System.Drawing.Size(443, 181);
            this.dataGridView_commandes.TabIndex = 9;
            this.dataGridView_commandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_commandes_CellContentClick);
            // 
            // NumCom
            // 
            this.NumCom.HeaderText = "NumCom";
            this.NumCom.Name = "NumCom";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.Text = "Voir";
            this.Detail.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_commandes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ville);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListCommand";
            this.Text = "Liste Des Commandes Par Client";
            this.Load += new System.EventHandler(this.ListCommand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_commandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_ville;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_commandes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.Button button1;
    }
}