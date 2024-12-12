namespace PetrolOtomasyon
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnYakıtSatışı;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.DataGridView dgvPompaListesi;
        private System.Windows.Forms.DataGridView dgvKasaIslemleri;
        private System.Windows.Forms.Button btnOnayla;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.btnYakıtSatışı = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPompaListesi = new System.Windows.Forms.DataGridView();
            this.dgvKasaIslemleri = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPlaka);
            this.tabPage1.Controls.Add(this.txtPlaka);
            this.tabPage1.Controls.Add(this.lblOdemeTuru);
            this.tabPage1.Controls.Add(this.cmbOdemeTuru);
            this.tabPage1.Controls.Add(this.btnYakıtSatışı);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pompacı";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(50, 50);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(45, 16);
            this.lblPlaka.TabIndex = 2;
            this.lblPlaka.Text = "Plaka:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(120, 50);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(200, 22);
            this.txtPlaka.TabIndex = 0;
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Location = new System.Drawing.Point(50, 100);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(85, 16);
            this.lblOdemeTuru.TabIndex = 3;
            this.lblOdemeTuru.Text = "Ödeme Türü:";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(120, 100);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(200, 24);
            this.cmbOdemeTuru.TabIndex = 1;
            // 
            // btnYakıtSatışı
            // 
            this.btnYakıtSatışı.Location = new System.Drawing.Point(120, 150);
            this.btnYakıtSatışı.Name = "btnYakıtSatışı";
            this.btnYakıtSatışı.Size = new System.Drawing.Size(200, 30);
            this.btnYakıtSatışı.TabIndex = 4;
            this.btnYakıtSatışı.Text = "Yakıt Satışı Yap";
            this.btnYakıtSatışı.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPompaListesi);
            this.tabPage2.Controls.Add(this.dgvKasaIslemleri);
            this.tabPage2.Controls.Add(this.btnOnayla);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Şube Kasa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPompaListesi
            // 
            this.dgvPompaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompaListesi.Location = new System.Drawing.Point(50, 30);
            this.dgvPompaListesi.Name = "dgvPompaListesi";
            this.dgvPompaListesi.RowHeadersWidth = 51;
            this.dgvPompaListesi.Size = new System.Drawing.Size(400, 150);
            this.dgvPompaListesi.TabIndex = 5;
            // 
            // dgvKasaIslemleri
            // 
            this.dgvKasaIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaIslemleri.Location = new System.Drawing.Point(50, 200);
            this.dgvKasaIslemleri.Name = "dgvKasaIslemleri";
            this.dgvKasaIslemleri.RowHeadersWidth = 51;
            this.dgvKasaIslemleri.Size = new System.Drawing.Size(400, 150);
            this.dgvKasaIslemleri.TabIndex = 6;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(50, 370);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(100, 30);
            this.btnOnayla.TabIndex = 7;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Genel Müdürlük";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Petrol Otomasyon Sistemi";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaIslemleri)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
