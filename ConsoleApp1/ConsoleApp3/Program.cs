using System.Threading.Channels;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ÜrünYönetimi ürünYönetimi = new();

            ürünYönetimi.SatışYap();

            ürünYönetimi.DepoyaÜrünEkle();

        }
    }

    public class ÜrünYönetimi
    {
        public void SatışYap()
        {
            Console.WriteLine("satış yap methodu"); 
            var logger = new LogManager(new SmsLogger());
            logger.LogEkle("satış yapıldı 123");
        }
        public void DepoyaÜrünEkle()
        {
            Console.WriteLine("depoya ürün ekle methodu methodu");
            var logger = new LogManager(new FileLogger());
            logger.LogEkle("depoya ürün eklendi 567");
        }
    }
    public class LogManager
    {
        private ILogger Logger { get; set; }

        public LogManager(ILogger logger)
        {
            Logger = logger;
        }

        public void LogEkle(string data)
        {
            Logger.AddLog(data);
        }
        public void Logİzle() => Logger.ViewAllLog();
    }



    public interface ILogger
    {
        public List<string> Logs { get; set; }
        public string Cs { get; set; }
        public void AddLog(string data);
        public void ViewAllLog();
    }
    public class SmsLogger : ILogger
    {
        public string Cs { set; get; }
        public List<string> Logs { get; set; } = new();

        public void AddLog(string data)
        {
            Console.WriteLine("sms logger  => "+data+" bilgisini logladı");
        }

        public void ViewAllLog()=>Logs.ForEach(x => Console.WriteLine(x));
        
    }

    public class DatabaseLogger : ILogger
    {
        public string Cs { set; get; }
        public List<string> Logs { get; set; } = new();

        public void AddLog(string data)
        {
            Console.WriteLine("database logger  => " + data + " bilgisini logladı");
        }

        public void ViewAllLog() => Logs.ForEach(x => Console.WriteLine(x));

    }

    public class FileLogger : ILogger
    {
        public string Cs { set; get; }
        public List<string> Logs { get; set; } = new();

        public void AddLog(string data)
        {
            Console.WriteLine("file logger  => " + data + " bilgisini logladı");
        }

        public void ViewAllLog() => Logs.ForEach(x => Console.WriteLine(x));

    }
}
