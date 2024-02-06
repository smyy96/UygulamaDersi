using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hastane hastane = new Hastane();


            hastane.RandevuAl(1, 2, new DateTime(2024, 2, 15, 13, 13, 0));
            Console.WriteLine("---- ikinci ------");
            hastane.RandevuAl(1, 2, new DateTime(2024, 2, 15, 13, 43, 0));



        }
    }


    public class Hastane
    {

        private  List<Hasta> Hastalar =new List<Hasta>();
        private  List<Doktor> Doktorlar =new();


        public Hastane()
        {
            Hastalar.Add(new Hasta(1) { Ad = "hasan" });
            Doktorlar.Add(new Doktor(2) { Ad = "ali" });
        }

        public void HastaKayıt(Hasta h) => Hastalar.Add(h);
        public void DoktorKayıt(Doktor h) => Doktorlar.Add(h);


        public void RandevuAl(int hastaId,int doktorId, DateTime tarih)
        {
            var Hastakontrol = false;
            var doktorKontrol = false;
            var doktor = new Doktor();
            var hasta = new Hasta();

            foreach (var item in Hastalar)
            {
                if (item.Id == hastaId)
                {
                    Hastakontrol = true;
                    hasta = item;
                    break;
                }
            }
            foreach (var item in Doktorlar)
            {
                if (item.Id == doktorId)
                {
                    doktorKontrol = true;
                    doktor = item;
                    break;
                }
            }

            if (!(doktorKontrol && Hastakontrol))
            {
                Console.WriteLine("doktor veya hasta bulunamadı");
                return;
            }

            var control = true;
            foreach (var item in doktor.Randevular)
            {
                if ( Math.Abs((int)(tarih - item.RandevuTarih).TotalMinutes) <30 )
                {
                    //13.30
                    //12.30
                    //11.30
                    //13.45 ben item 

                    control = false;
                }
            }


            if (!control)
            {
                Console.WriteLine("seçtiğiniz tarihe randevu alınamaz !!");
                return;
            }

            var randomNumber = new Random().Next(1, 999999999);

            doktor.Randevular.Add(new Randevu()
            {
                RandevuStatus = RandevuStatus.Gelecek,
                RandevuTarih = tarih,
                RandevuID = randomNumber
            });

            hasta.Randevular.Add(new Randevu()
            {
                RandevuStatus = RandevuStatus.Gelecek,
                RandevuTarih = tarih,
                RandevuID = randomNumber
            });


            Console.WriteLine("randevu oluşturuldu id : "+ randomNumber+ " tarhi : "+tarih.ToString());

        }










    }
    public enum Cinsiyet
    {
        Erkek = 1,
        Kadın = 2
    }
    public enum KanGrubu
    {
        a = 1,
        b = 2,
        ab = 3
    }
    public enum Alan
    {
        Dahiliye = 1,
        Kbb = 2,
        Cildiye = 3,
        AileHekimi = 4
    }
    public enum RandevuStatus
    {
        Yapıldı=1,
        Gelecek=2,
        İptal=3,
        Ertelendi=4
    }
}
