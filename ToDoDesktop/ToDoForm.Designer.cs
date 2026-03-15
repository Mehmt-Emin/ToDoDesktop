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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.BackColor = System.Drawing.Color.Transparent;
            this.lblGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorev.ForeColor = System.Drawing.Color.LightCoral;
            this.lblGorev.Location = new System.Drawing.Point(204, 54);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(128, 25);
            this.lblGorev.TabIndex = 0;
            this.lblGorev.Text = "Görev Girin:";
            // 
            // txtGorev
            // 
            this.txtGorev.BackColor = System.Drawing.Color.Honeydew;
            this.txtGorev.Location = new System.Drawing.Point(366, 55);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(246, 26);
            this.txtGorev.TabIndex = 1;
            // 
            // lstGorevler
            // 
            this.lstGorevler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstGorevler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstGorevler.ForeColor = System.Drawing.Color.LightCoral;
            this.lstGorevler.FormattingEnabled = true;
            this.lstGorevler.ItemHeight = 22;
            this.lstGorevler.Location = new System.Drawing.Point(2, -3);
            this.lstGorevler.Name = "lstGorevler";
            this.lstGorevler.Size = new System.Drawing.Size(376, 286);
            this.lstGorevler.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnEkle.Location = new System.Drawing.Point(668, 55);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(164, 34);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSil.Location = new System.Drawing.Point(238, 509);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(164, 34);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamlandi.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnTamamlandi.Location = new System.Drawing.Point(505, 509);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(164, 34);
            this.btnTamamlandi.TabIndex = 5;
            this.btnTamamlandi.Text = "Tamamlandı";
            this.btnTamamlandi.UseVisualStyleBackColor = true;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(761, 509);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(164, 34);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Ana Menüye Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lstGorevler);
            this.panel1.Location = new System.Drawing.Point(305, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 286);
            this.panel1.TabIndex = 7;
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTamamlandi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.lblGorev);
            this.Name = "ToDoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görevler";
            this.Load += new System.EventHandler(this.ToDoForm_Load);
            this.panel1.ResumeLayout(false);
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
    }
}