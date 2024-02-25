using System;
using System.Text.Json;
using System.Windows.Forms;

namespace RandomGrupOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string path = "gruplar.txt";



        List<string> ogrenciList = new List<string>() { "Ayþenur Tokgöz", "Bengü Ürgen Demir", "Burak Gonca", "Eyþan Tekinsoy", "Furkan Baybura", "Hakan Girgin", "Hivda Karahan", "Ilgýn Deniz Ayaz", "Kerem Yasir Özyön", "Mehmet Çaðrý Çelenk", "Sümeyye Coþkun", "Yasin Baðçuvan", "Yusuf Kenan Girgin" };

        List<string> kullanilanKisiler = new List<string>();

        Random random = new Random();
        string grup = "";
        int randomKisi = 0;

        private async void btnGrupOlustur_Click(object sender, EventArgs e)
        {

            lstbxGrup.Items.Clear();

            bool sonuncu = false;
            int grupSayisi;

            bool kontrol = int.TryParse(txtGrupSayisi.Text, out grupSayisi);
            if (kontrol && ogrenciList.Count > 0)
            {
                int kalan = ogrenciList.Count % grupSayisi;
                int gruplama = ogrenciList.Count / grupSayisi;

                for (int j = 0; j < gruplama + kalan; j++)
                {

                    if (ogrenciList.Count >= grupSayisi)
                    {
                        if (j != 0)
                            lstbxGrup.Items.Add("");

                        grup = (j + 1) + ". Grup\n";
                        lstbxGrup.Items.Add("\t" + grup);

                        for (int i = 0; i < grupSayisi; i++)
                        {
                            sonuncu = true;

                            GruplariEkleme();
                            await Task.Delay(1500);
                        }
                    }


                    if (sonuncu == false)
                    {
                        GruplariEkleme();
                        await Task.Delay(1500);
                    }
                    sonuncu = false;
                }
            }
            else if (ogrenciList.Count == 0)
                MessageBox.Show("Liste Boþ");
            else MessageBox.Show("Sayýsal deðer giriniz.");



            ogrenciList.AddRange(kullanilanKisiler);
            kullanilanKisiler.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBxKisiler.Items.Clear();

            foreach (string ogrenciAdi in ogrenciList)
            {
                lstBxKisiler.Items.Add(ogrenciAdi);
            }
        }

        private void btnListeyiSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Verileri silmek istediðinize emin misiniz?", "Dikkat!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                lstBxKisiler.Items.Clear();
                ogrenciList.Clear();

            }

            else
            {
                MessageBox.Show("Dönülmez yollardan döndün. ");
            }

        }

        private void btnYeniKisi_Click(object sender, EventArgs e)
        {
            ogrenciList.Add(txtYeniKisi.Text);
            lstBxKisiler.Items.Add(txtYeniKisi.Text);
            txtYeniKisi.Text = string.Empty;
        }



        private void GruplariEkleme()
        {
            randomKisi = random.Next(0, ogrenciList.Count);
            lstbxGrup.Items.Add(ogrenciList[randomKisi]);
            kullanilanKisiler.Add(ogrenciList[randomKisi]);

            ogrenciList.RemoveAt(randomKisi);

        }



        //private void button1_Click(object sender, EventArgs e)
        //{

        //    string okunanVeriler;

        //    if (File.Exists(path))
        //    {
        //        string datas = File.ReadAllText(path);
        //        okunanVeriler = JsonSerializer.Deserialize<string>(datas);
        //    }

        //    okunanVeriler.Add(lstbxGrup.Items.ToString());

        //    var yeniVeriler = JsonSerializer.Serialize(okunanVeriler);
        //    File.WriteAllText(path, yeniVeriler);

        //}



        private void btnEkleTxt_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter dosya = new StreamWriter(path);

                foreach (string data in lstbxGrup.Items)
                {
                    dosya.WriteLine(data);
                }
                dosya.Close();

                MessageBox.Show("Veriler eklendi. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu tekrar deneyin. :( " + ex.Message);
            }


        }
    }
}