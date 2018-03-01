namespace MetroUi
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miseAJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeNomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseAJourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseAJourToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.newFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miseAJourToolStripMenuItem
            // 
            this.miseAJourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeNomsToolStripMenuItem,
            this.listeParVilleToolStripMenuItem,
            this.nombreParVilleToolStripMenuItem,
            this.miseAJourToolStripMenuItem1});
            this.miseAJourToolStripMenuItem.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.miseAJourToolStripMenuItem.Name = "miseAJourToolStripMenuItem";
            this.miseAJourToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.miseAJourToolStripMenuItem.Text = "Client";
            // 
            // listeNomsToolStripMenuItem
            // 
            this.listeNomsToolStripMenuItem.Name = "listeNomsToolStripMenuItem";
            this.listeNomsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listeNomsToolStripMenuItem.Text = "Liste Noms";
            this.listeNomsToolStripMenuItem.Click += new System.EventHandler(this.listeNomsToolStripMenuItem_Click);
            // 
            // listeParVilleToolStripMenuItem
            // 
            this.listeParVilleToolStripMenuItem.Name = "listeParVilleToolStripMenuItem";
            this.listeParVilleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listeParVilleToolStripMenuItem.Text = "liste Par Ville";
            this.listeParVilleToolStripMenuItem.Click += new System.EventHandler(this.listeParVilleToolStripMenuItem_Click);
            // 
            // nombreParVilleToolStripMenuItem
            // 
            this.nombreParVilleToolStripMenuItem.Name = "nombreParVilleToolStripMenuItem";
            this.nombreParVilleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nombreParVilleToolStripMenuItem.Text = "Nombre Par Ville";
            // 
            // miseAJourToolStripMenuItem1
            // 
            this.miseAJourToolStripMenuItem1.Name = "miseAJourToolStripMenuItem1";
            this.miseAJourToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.miseAJourToolStripMenuItem1.Text = "Gestion";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.consultationToolStripMenuItem.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.consultationToolStripMenuItem.Text = "Article";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.gestionToolStripMenuItem.Text = "gestion";
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCommandesToolStripMenuItem});
            this.commandeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.commandeToolStripMenuItem.Text = "Commande";
            this.commandeToolStripMenuItem.Click += new System.EventHandler(this.commandeToolStripMenuItem_Click);
            // 
            // listeCommandesToolStripMenuItem
            // 
            this.listeCommandesToolStripMenuItem.Name = "listeCommandesToolStripMenuItem";
            this.listeCommandesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listeCommandesToolStripMenuItem.Text = "liste commandes";
            this.listeCommandesToolStripMenuItem.Click += new System.EventHandler(this.listeCommandesToolStripMenuItem_Click);
            // 
            // newFormToolStripMenuItem
            // 
            this.newFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            this.newFormToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.newFormToolStripMenuItem.Text = "new form";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "new";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 449);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miseAJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeNomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeParVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreParVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseAJourToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

