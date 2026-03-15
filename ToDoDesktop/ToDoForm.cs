using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoDesktop
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
        }

       

        private void ToDoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGorev.Text))
            {
                lstGorevler.Items.Add(txtGorev.Text);
                txtGorev.Clear();
                txtGorev.Focus();
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
                lstGorevler.Items.Remove(lstGorevler.SelectedItem);
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
                int seciliIndex = lstGorevler.SelectedIndex;
                string gorev = lstGorevler.SelectedItem.ToString();

                if (!gorev.StartsWith("✔ "))
                {
                    lstGorevler.Items[seciliIndex] = "✔ " + gorev;
                }
                else
                {
                    MessageBox.Show("Bu görev zaten tamamlandı olarak işaretlenmiş.");
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
    }
}
