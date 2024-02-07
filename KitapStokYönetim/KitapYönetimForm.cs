using ClassLibrary1.Abstract;
using ClassLibrary1.Concreate;
using ClassLibrary1.Entities;
using KitapStokYönetim.Helpers;
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
    public partial class KitapYönetimForm : Form
    {

        IRepository<Product> _repository = new ProductRepository();
        IRepository<User> _repositoryUser = new UserRepository();
        public KitapYönetimForm()
        {
            InitializeComponent();
        }

        private void KitapYönetimForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!MyCustomControl.ControlStingToNumber(txtFiyat.Text, out int fiyat))
            {
                MessageBox.Show("geçersiz bir fiyat girdin");
                return;
            }
            if (!MyCustomControl.ControlStingToNumber(txtAdet.Text, out int adet))
            {
                MessageBox.Show("geçersiz bir adet girdin");
                return;

            }
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("geçersiz bir ad girdin");
                return;

            }


            _repository.Add(new()
            {
                Id = new Random().Next(99, 99999999),
                Name = txtAd.Text,
                Price = fiyat,
                StockAmount = adet
            });

            MessageBox.Show("data eklendi");
            UpdateListBox(_repository.GetAll());

        }

        public void UpdateListBox(List<Product> products)
        {
            listBox1.Items.Clear();
            foreach (var item in products)
            {


                listBox1.Items.Add($"{item.Id}|{item.Name}|{item.StockAmount}|{item.Price}TL");
            }



            var user = _repositoryUser.GetById(Program.CurrentUserId);

            label1.Text = "Kasadaki Para : " + user.Balance.ToString()+ " TL ";



        }

        private void KitapYönetimForm_Load(object sender, EventArgs e)
        {
            UpdateListBox(_repository.GetAll());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lbx = sender as ListBox;

            if (string.IsNullOrEmpty((string)lbx.SelectedItem))
            {
                return;
            }
            var bookId= int.Parse(((string)lbx.SelectedItem).Split('|')[0]);

            var kitap =  _repository.GetById(bookId);


            KitapForm kitapForm = new KitapForm();
            kitapForm.Form = this;
            kitapForm.Kitap = kitap;

            kitapForm.Show();





        }
    }
}
