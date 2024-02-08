using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyCustomArrayList list = new MyCustomArrayList();

            list.Olay += ShowCount;


            list.AddWithMessage(1);
            
            list.AddWithMessage("a");
            
            list.AddWithMessage('a');
            
            list.AddWithMessage(1.2);

            /*
             
             bir araba sınıfı oluştur
            bu sınıfın içinde hız sınırı prop'u olsun ctordan al
            mevcut hız olsun  prop başlangıc sıfır

            Hızlan Methodu() hız yükseltcek mevcut hız artacak
            ama mevcut hızın set bacağında bir event olacak
            bu event mevcut hız her arrtığında arabanın hız sınırı ile
            bir mukayese yapacak ve eğer hız sınırı aşılmış ise
            yavaşla methodunu çağıracak hız düşecek bir miktar

            Yavaşla() => mevcut hızı düşürecek

             
             */


        }
       
        public  static void ShowCount(object sender, EventArgs e)
        {
            var arr = sender as ArrayList;

            var last = arr[arr.Count - 1]; 
            Console.WriteLine("elemam sayısı arttı  mevcut sayı : "+arr.Count +" eklenen en son eleman "+ last);


        }
    }


    public class MyCustomArrayList : ArrayList
    {
        public event EventHandler Olay;
        public void AddWithMessage(object data)
        {
            base.Add(data);
            Olay(this, EventArgs.Empty);

        }
    }

    
}
