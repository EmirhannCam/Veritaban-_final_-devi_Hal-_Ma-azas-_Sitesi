namespace Halı_Mağazası_Sitesi
{
    partial class Anaform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMüşteriler = new System.Windows.Forms.ToolStripButton();
            this.btnÜrünler = new System.Windows.Forms.ToolStripButton();
            this.btnSatışYap = new System.Windows.Forms.ToolStripButton();
            this.btnÖdemeYap = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSatışDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSatışSil = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnÖdemeDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnÖdemeSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMüşteriler,
            this.btnÜrünler,
            this.btnSatışYap,
            this.btnÖdemeYap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(631, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMüşteriler
            // 
            this.btnMüşteriler.Image = ((System.Drawing.Image)(resources.GetObject("btnMüşteriler.Image")));
            this.btnMüşteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriler.Name = "btnMüşteriler";
            this.btnMüşteriler.Size = new System.Drawing.Size(129, 36);
            this.btnMüşteriler.Text = "MÜŞTERİLER";
            this.btnMüşteriler.Click += new System.EventHandler(this.btnMüşteriler_Click);
            // 
            // btnÜrünler
            // 
            this.btnÜrünler.Image = ((System.Drawing.Image)(resources.GetObject("btnÜrünler.Image")));
            this.btnÜrünler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜrünler.Name = "btnÜrünler";
            this.btnÜrünler.Size = new System.Drawing.Size(109, 36);
            this.btnÜrünler.Text = "ÜRÜNLER";
            this.btnÜrünler.Click += new System.EventHandler(this.btnÜrünler_Click);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışYap.Image")));
            this.btnSatışYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(111, 36);
            this.btnSatışYap.Text = "SATIŞ YAP";
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // btnÖdemeYap
            // 
            this.btnÖdemeYap.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdemeYap.Image")));
            this.btnÖdemeYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeYap.Name = "btnÖdemeYap";
            this.btnÖdemeYap.Size = new System.Drawing.Size(125, 36);
            this.btnÖdemeYap.Text = "ÖDEME YAP";
            this.btnÖdemeYap.Click += new System.EventHandler(this.btnÖdemeYap_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SATIŞLAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(617, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSatışDuzenle,
            this.btnSatışSil,
            this.btnMusteriBul,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(617, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSatışDuzenle
            // 
            this.btnSatışDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışDuzenle.Image")));
            this.btnSatışDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışDuzenle.Name = "btnSatışDuzenle";
            this.btnSatışDuzenle.Size = new System.Drawing.Size(87, 24);
            this.btnSatışDuzenle.Text = "Düzenle";
            this.btnSatışDuzenle.Click += new System.EventHandler(this.btnSatışDuzenle_Click);
            // 
            // btnSatışSil
            // 
            this.btnSatışSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışSil.Image")));
            this.btnSatışSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışSil.Name = "btnSatışSil";
            this.btnSatışSil.Size = new System.Drawing.Size(49, 24);
            this.btnSatışSil.Text = "Sil";
            this.btnSatışSil.Click += new System.EventHandler(this.btnSatışSil_Click);
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMusteriBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMusteriBul.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriBul.Image")));
            this.btnMusteriBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(29, 24);
            this.btnMusteriBul.Text = "Bul";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ÖDEMELER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(617, 349);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnÖdemeDüzenle,
            this.btnÖdemeSil,
            this.toolStripButton3,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(617, 27);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnÖdemeDüzenle
            // 
            this.btnÖdemeDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdemeDüzenle.Image")));
            this.btnÖdemeDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeDüzenle.Name = "btnÖdemeDüzenle";
            this.btnÖdemeDüzenle.Size = new System.Drawing.Size(87, 24);
            this.btnÖdemeDüzenle.Text = "Düzenle";
            this.btnÖdemeDüzenle.Click += new System.EventHandler(this.btnÖdemeDüzenle_Click);
            // 
            // btnÖdemeSil
            // 
            this.btnÖdemeSil.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdemeSil.Image")));
            this.btnÖdemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeSil.Name = "btnÖdemeSil";
            this.btnÖdemeSil.Size = new System.Drawing.Size(49, 24);
            this.btnÖdemeSil.Text = "Sil";
            this.btnÖdemeSil.Click += new System.EventHandler(this.btnÖdemeSil_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "Bul";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(150, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 28);
            this.toolStripLabel2.Text = "Ara:";
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Anaform";
            this.Text = "Halı Satış Mağazası";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMüşteriler;
        private System.Windows.Forms.ToolStripButton btnÜrünler;
        private System.Windows.Forms.ToolStripButton btnSatışYap;
        private System.Windows.Forms.ToolStripButton btnÖdemeYap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSatışDuzenle;
        private System.Windows.Forms.ToolStripButton btnSatışSil;
        private System.Windows.Forms.ToolStripButton btnMusteriBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnÖdemeDüzenle;
        private System.Windows.Forms.ToolStripButton btnÖdemeSil;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

