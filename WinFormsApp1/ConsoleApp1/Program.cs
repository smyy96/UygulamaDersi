using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ConsoleApp1
{

    public delegate void ParametresizVoidMethod();
    public delegate bool ControlDelegate(int a);
    public delegate int İslem(int a);
    public delegate int İslem2(int a, int b);
    public delegate bool ControlStr(string s);
    internal class Program
    {
        static void Main(string[] args)
        {
            //ILDASM
            ParametresizVoidMethod d1 = delegate ()
            {

                Console.WriteLine("merhaba dünya");
            };

            İslem d2 = a =>
            {

                return a * 2;
            };
            İslem2 d3 = (a, b) => a * b;

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9, 10 };
            Filtre(list, x => x >= 5);

            MyClass myClass = new();

            myClass.Olay += MyEventWorker;



            //myClass.MySalary = 20;
            //myClass.MySalary = 30;
            //myClass.MySalary = 10;
            //myClass.MySalary = 40;


            /*
                
            bir delegate tasarla [DelegateNAme]

            bu delegate şöyle bir method saklayabilsin

            string parametre alıp geriye bool dönen bir method olsun

            daha sonra elidne bir string list olsun kullanacağın (mainde)
            ↓
            içerisine bazı datalar gir



            daha sonra bir method tasarla
                ↓
            control(List<string> data, DelegateNAme p )
             control methodunun işlevi şu
            delegate geçilen işlev ne ise onu data isimli listenin
            tüm elemanlarına uygulasın ve 'p' delegatetinden geçen tüm sonuçları
            ekrana yazdırsın
             
             */

            /*
            
            int sayi =2;
            int KareAl(2) =>4
            int KareAl(sayi) =>4

         
                public void test(data,xDelegate y)

                test(data,x=>x[0]=='a')

                foreach  data gez ve kuralı sağlayanları 
             
             */

            // public delegate bool ControlStr(string s);
            //List<string> data = new List<string>();
            //data.Add("ali");
            //data.Add("veli");
            //data.Add("hasan");
            //data.Add("ayşe");
            //data.Add("mervee");
            //StrIslem(data, x => x.Length > 5);


            Öğrenci ö1 = new();
            ö1.Olay += OgrenciNotGoster;

            ö1.Not1 = 20;
            ö1.Not2 = 50;
            ö1.Not3 = 30;


        }
        public static void OgrenciNotGoster(object sndr, EventArgs e)
        {
            var o = sndr as Öğrenci;

            if (o.Not1 >= 0 && o.Not2 >= 0 && o.Not3 >= 0)
            {
                var result = (o.Not1 + o.Not2 + o.Not3) / 3.0f;
                Console.WriteLine("tüm sınavlar girildi ortalama : " + result);
            }
        }
        public static void StrIslem(List<string> data, ControlStr s)
        {
            foreach (var item in data)
            {
                if (s(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void MyEventWorker(object sender, EventArgs e)
        {
            Console.WriteLine("maaş değiştirildi");

            var myclass = sender as MyClass;
            Console.WriteLine(myclass.MySalary);

        }

        public static void Merhaba()
        {
            Console.WriteLine("merhaba");
        }
        public static void Test()
        {
            Console.WriteLine("test");
        }

        public static void Operasyon(ParametresizVoidMethod d1)
        {

            d1.Invoke();

        }
        public static bool Test2(int a)
        {
            return a % 2 == 0;
        }

        public static void Filtre(List<int> data, ControlDelegate control)
        {

            foreach (var item in data)
            {
                if (control(item))
                {
                    Console.WriteLine(item);
                }
            }

        }

    }

    public class MyClass
    {

        public event EventHandler Olay;

        private int mySalary;
        public int MySalary
        {
            get
            {
                return mySalary;

            }
            set
            {
                //maaş değiştiği zaman bir event tetiklensin

                mySalary = value;
                //Change();
                if (Olay != null)
                {

                    Olay(this, EventArgs.Empty);

                }
            }
        }

        public void Change()
        {
            if (Olay != null)
            {
                Olay(this, EventArgs.Empty);
            }

        }


    }



    public class Öğrenci
    {
        public event EventHandler Olay;
        public string Ad { get; set; }
        public int Not1 { get; set; } = -1;
        public int Not2 { get; set; } = -1;

        private int not3 = -1;
        public int Not3
        {
            get
            {
                return not3;
            }

            set
            {
                not3 = value;
                Olay(this, EventArgs.Empty);
            }

        }

    }

}
/*
 
    öğrenci isimli bir sınııf yaz

        ad soyad prop olsun string
        not1 not2 not3 isimli int
    
        bu sınıfta bir event tanımla
        öğrenciye not3 girişi yapıldığı anda (daha öncesinde not1 ve not2 girildiğini kontrol et)
        öğrecinin ortalamasını ekran yazdır
        
         public event EventHandler Olay; => event tanımlaması

        
    öğrenci hasan = new();

    hasan.olay = method bağla => methodun imzası ne olacak(bu mehoduda tanıma)

    
 
 
 */