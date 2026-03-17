namespace ToDoDesktop
{
    partial class ToDoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoForm));
            this.lblGorev = new System.Windows.Forms.Label();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.lstGorevler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTamamlandi = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkTamamlananlariGizle = new System.Windows.Forms.CheckBox();
            this.lblSayac = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.BackColor = System.Drawing.Color.Transparent;
            this.lblGorev.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGorev.ForeColor = System.Drawing.Color.DimGray;
            this.lblGorev.Location = new System.Drawing.Point(185, 54);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(138, 30);
            this.lblGorev.TabIndex = 0;
            this.lblGorev.Text = "Görev Girin:";
            this.lblGorev.Click += new System.EventHandler(this.lblGorev_Click);
            // 
            // txtGorev
            // 
            this.txtGorev.BackColor = System.Drawing.Color.White;
            this.txtGorev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGorev.Location = new System.Drawing.Point(376, 54);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(246, 26);
            this.txtGorev.TabIndex = 1;
            this.txtGorev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGorev_KeyDown);
            // 
            // lstGorevler
            // 
            this.lstGorevler.BackColor = System.Drawing.Color.White;
            this.lstGorevler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstGorevler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGorevler.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstGorevler.ForeColor = System.Drawing.Color.LightCoral;
            this.lstGorevler.FormattingEnabled = true;
            this.lstGorevler.ItemHeight = 30;
            this.lstGorevler.Location = new System.Drawing.Point(0, 0);
            this.lstGorevler.Name = "lstGorevler";
            this.lstGorevler.Size = new System.Drawing.Size(376, 334);
            this.lstGorevler.TabIndex = 2;
            this.lstGorevler.SelectedIndexChanged += new System.EventHandler(this.lstGorevler_SelectedIndexChanged);
            this.lstGorevler.DoubleClick += new System.EventHandler(this.lstGorevler_DoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnEkle.Location = new System.Drawing.Point(700, 54);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(164, 34);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSil.Location = new System.Drawing.Point(159, 533);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(164, 34);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.BackColor = System.Drawing.Color.White;
            this.btnTamamlandi.FlatAppearance.BorderSize = 0;
            this.btnTamamlandi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamlandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamlandi.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnTamamlandi.Location = new System.Drawing.Point(410, 533);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(164, 34);
            this.btnTamamlandi.TabIndex = 5;
            this.btnTamamlandi.Text = "Tamamlandı";
            this.btnTamamlandi.UseVisualStyleBackColor = false;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.White;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(657, 533);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(164, 34);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Ana Menüye Dön";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lstGorevler);
            this.panel1.Location = new System.Drawing.Point(306, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 334);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // chkTamamlananlariGizle
            // 
            this.chkTamamlananlariGizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkTamamlananlariGizle.BackColor = System.Drawing.Color.White;
            this.chkTamamlananlariGizle.FlatAppearance.BorderSize = 0;
            this.chkTamamlananlariGizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTamamlananlariGizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTamamlananlariGizle.Location = new System.Drawing.Point(411, 573);
            this.chkTamamlananlariGizle.Name = "chkTamamlananlariGizle";
            this.chkTamamlananlariGizle.Size = new System.Drawing.Size(224, 34);
            this.chkTamamlananlariGizle.TabIndex = 9;
            this.chkTamamlananlariGizle.Text = "Tamamlananları Gizle";
            this.chkTamamlananlariGizle.UseVisualStyleBackColor = false;
            this.chkTamamlananlariGizle.CheckedChanged += new System.EventHandler(this.chkTamamlananlariGizle_CheckedChanged);
            // 
            // lblSayac
            // 
            this.lblSayac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSayac.AutoSize = true;
            this.lblSayac.BackColor = System.Drawing.Color.Transparent;
            this.lblSayac.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.ForeColor = System.Drawing.Color.DimGray;
            this.lblSayac.Location = new System.Drawing.Point(186, 99);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(161, 30);
            this.lblSayac.TabIndex = 10;
            this.lblSayac.Text = "Görev Sayısı : 0";
            // 
            // ToDoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 624);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.chkTamamlananlariGizle);
            this.Controls.Add(this.lblGorev);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTamamlandi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "ToDoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görevler";
            this.Load += new System.EventHandler(this.ToDoForm_Load);
            this.Resize += new System.EventHandler(this.ToDoForm_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.ListBox lstGorevler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTamamlandi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkTamamlananlariGizle;
        private System.Windows.Forms.Label lblSayac;
    }
}