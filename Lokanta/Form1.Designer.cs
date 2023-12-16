namespace Lokanta
{
    partial class Form1
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
            this.masalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemeklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masalarToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.yemeklerToolStripMenuItem,
            this.siparişlerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masalarToolStripMenuItem
            // 
            this.masalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaEkleToolStripMenuItem,
            this.masaGösterToolStripMenuItem});
            this.masalarToolStripMenuItem.Name = "masalarToolStripMenuItem";
            this.masalarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.masalarToolStripMenuItem.Text = "Masalar";
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem});
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.personellerToolStripMenuItem.Text = "Personeller";
            // 
            // yemeklerToolStripMenuItem
            // 
            this.yemeklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.yemekEkleToolStripMenuItem});
            this.yemeklerToolStripMenuItem.Name = "yemeklerToolStripMenuItem";
            this.yemeklerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.yemeklerToolStripMenuItem.Text = "Yemekler";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // yemekEkleToolStripMenuItem
            // 
            this.yemekEkleToolStripMenuItem.Name = "yemekEkleToolStripMenuItem";
            this.yemekEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yemekEkleToolStripMenuItem.Text = "Yemek Ekle";
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEkleToolStripMenuItem,
            this.siparişiKapatToolStripMenuItem});
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // siparişEkleToolStripMenuItem
            // 
            this.siparişEkleToolStripMenuItem.Name = "siparişEkleToolStripMenuItem";
            this.siparişEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişEkleToolStripMenuItem.Text = "Sipariş Ekle";
            // 
            // siparişiKapatToolStripMenuItem
            // 
            this.siparişiKapatToolStripMenuItem.Name = "siparişiKapatToolStripMenuItem";
            this.siparişiKapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişiKapatToolStripMenuItem.Text = "Siparişi Kapat";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            // 
            // masaEkleToolStripMenuItem
            // 
            this.masaEkleToolStripMenuItem.Name = "masaEkleToolStripMenuItem";
            this.masaEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masaEkleToolStripMenuItem.Text = "Masa Ekle";
            this.masaEkleToolStripMenuItem.Click += new System.EventHandler(this.masaEkleToolStripMenuItem_Click);
            // 
            // masaGösterToolStripMenuItem
            // 
            this.masaGösterToolStripMenuItem.Name = "masaGösterToolStripMenuItem";
            this.masaGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masaGösterToolStripMenuItem.Text = "Masa Göster";
            this.masaGösterToolStripMenuItem.Click += new System.EventHandler(this.masaGösterToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemeklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişiKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

