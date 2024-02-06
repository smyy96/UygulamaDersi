using ClassLibrary1.Concreate;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapStokYönetim
{
    public partial class HesapAcForm : Form
    {
        UserRepository repo = new UserRepository();
        public HesapAcForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            var user = new User()
            {
                Id = new Random().Next(1, 1000),
                Name = txtAd.Text,
                Balance = 0,
                Password = txtSifre.Text,
                UserName = txtKullaniciAd.Text
            };

            repo.Add(user);

            MessageBox.Show("hesap oluşturuldu");

        }

        private void HesapAcForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FirstForm.Show();
            Program.SecondForm = null;

        }
    }
}
