using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace ToDoDesktop
{
    public partial class ToDoForm : Form
    {
        string dosyaYolu = "gorevler.txt";
        List<string> tumGorevler = new List<string>();
        public ToDoForm()
        {
            InitializeComponent();
        }

        private void ListeyiGuncelle()
        {
            lstGorevler.Items.Clear();

            foreach (string gorev in tumGorevler)
            {
                if (chkTamamlananlariGizle.Checked && gorev.StartsWith("✔ "))
                {
                    continue;
                }
                lstGorevler.Items.Add(gorev);
            }
            lblSayac.Text = "Görev Sayısı: " + tumGorevler.Count;
        }
        
        private void GorevleriKaydet()
        {
            
            File.WriteAllLines(dosyaYolu, tumGorevler);
        }

        private void GorevleriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
               tumGorevler = File.ReadAllLines(dosyaYolu).ToList();
            }
                ListeyiGuncelle();
        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;

            GorevleriYukle();

            pictureBox1.SendToBack();
            panel1.BringToFront();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGorev.Text))
            {
                tumGorevler.Add(txtGorev.Text);
                txtGorev.Clear();
                txtGorev.Focus();
                GorevleriKaydet();
                ListeyiGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen bir görev girin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedItem != null)
            {
                DialogResult sonuc = MessageBox.Show("Bu görevi silmek istediğinize emin misiniz?", "Görev Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    string seciliGorev = lstGorevler.SelectedItem.ToString();
                    tumGorevler.Remove(seciliGorev);

                    GorevleriKaydet();
                    ListeyiGuncelle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir görev seçin.");
            }
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedItem != null)
            {
                string seciliGorev = lstGorevler.SelectedItem.ToString();

                if (!seciliGorev.StartsWith("✔ "))
                {
                    int index = tumGorevler.IndexOf(seciliGorev);

                    if (index != -1)
                    {
                        tumGorevler[index] = "✔ " + seciliGorev;
                        GorevleriKaydet();
                        ListeyiGuncelle();
                    }
                }
                else
                {
                    MessageBox.Show("Bu görev zaten tamamlandı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tamamlandı yapmak için bir görev seçin.");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 anaMenu = new Form1();
            anaMenu.Show();
            this.Hide();
        }

        private void lstGorevler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGorev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEkle.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void lstGorevler_DoubleClick(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedItem != null)
            {
                string eskiGorev = lstGorevler.SelectedItem.ToString();
                int index = tumGorevler.IndexOf(eskiGorev);

                if (index == -1) return;

                bool tamamlandiMi = eskiGorev.StartsWith("✔ ");
                string duzenlenecekMetin = eskiGorev;

                if (tamamlandiMi)
                {
                    duzenlenecekMetin = eskiGorev.Substring(2);
                }

                string yeniGorev = Microsoft.VisualBasic.Interaction.InputBox(
                    "Görevi düzenleyin:",
                    "Görev Düzenle",
                    duzenlenecekMetin
                );

                if (!string.IsNullOrWhiteSpace(yeniGorev))
                {
                    if (tamamlandiMi)
                        tumGorevler[index] = "✔ " + yeniGorev;
                    else
                        tumGorevler[index] = yeniGorev;

                    GorevleriKaydet();
                    ListeyiGuncelle();
                }
            }
        }

        private void ToDoForm_Resize(object sender, EventArgs e)
        {
        }

        private void KontrolleriYerlestir()
        {
            int pw = pictureBox1.Width;
            int ph = pictureBox1.Height;

            int px = pictureBox1.Left;
            int py = pictureBox1.Top;

            panel1.Left = px + (int)(pw * 0.39);
            panel1.Top = py + (int)(ph * 0.24);
            panel1.Width = (int)(pw * 0.40);
            panel1.Height = (int)(ph * 0.54);

            lblGorev.Left = px + (int)(pw * 0.20);
            lblGorev.Top = py + (int)(ph * 0.10);

            txtGorev.Left = px + (int)(pw * 0.40);
            txtGorev.Top = py + (int)(ph * 0.09);
            txtGorev.Width = (int)(pw * 0.18);

            btnEkle.Left = px + (int)(pw * 0.65);
            btnEkle.Top = py + (int)(ph * 0.09);
            btnEkle.Width = (int)(pw * 0.16);

            btnSil.Left = px + (int)(pw * 0.20);
            btnSil.Top = py + (int)(ph * 0.88);
            btnSil.Width = (int)(pw * 0.18);

            btnTamamlandi.Left = px + (int)(pw * 0.48);
            btnTamamlandi.Top = py + (int)(ph * 0.88);
            btnTamamlandi.Width = (int)(pw * 0.18);

            btnGeri.Left = px + (int)(pw * 0.73);
            btnGeri.Top = py + (int)(ph * 0.88);
            btnGeri.Width = (int)(pw * 0.20);

            chkTamamlananlariGizle.Left = pictureBox1.Left + (int)(pictureBox1.Width * 0.03);
            chkTamamlananlariGizle.Top = pictureBox1.Top + (int)(pictureBox1.Height * 0.88);
            chkTamamlananlariGizle.Width = (int)(pictureBox1.Width * 0.22);
            chkTamamlananlariGizle.Height = 30;

            lblSayac.Left = px + (int)(pw * 0.03);
            lblSayac.Top = py + (int)(ph * 0.83);
            lblSayac.Width = (int)(pw * 0.20);
            lblSayac.Height = 30;

        }

        private void lblGorev_Click(object sender, EventArgs e)
        {

        }

        private void chkTamamlananlariGizle_CheckedChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }
    }
}
