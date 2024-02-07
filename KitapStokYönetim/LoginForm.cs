using ClassLibrary1.Abstract;
using ClassLibrary1.Concreate;
using ClassLibrary1.Entities;

namespace KitapStokYönetim
{
    public partial class LoginForm : Form
    {
        IRepository<User> UserRepository = new UserRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.FirstForm = this;
            Program.SecondForm = new HesapAcForm();

            Program.SecondForm.Show();
            Program.FirstForm.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var sifre = txtSifre.Text;
            var kullanıcıAdı = txtKullaniciAdı.Text;

            var users = UserRepository.GetAll();

            var control = false;
            foreach (var item in users)
            {
                if (item.UserName == kullanıcıAdı && item.Password == sifre)
                {
                    control = true;
                    Program.CurrentUserId = item.Id;
                }
            }

            if (!control)
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış!!");
                return;
            }

            //programin ana sayfası

            Program.FirstForm = new KitapYönetimForm();
            Program.FirstForm.Show();
            Program.MainForm = this;

            this.Hide();
        }
    }


}
