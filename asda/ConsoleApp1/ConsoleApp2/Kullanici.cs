namespace ConsoleApp2
{
    public abstract class  Kullanici
    {

        public Kullanici()
        {
            _id = new Random().Next(300, 9999);

           
        }

        public Kullanici(int id)
        {
            _id = id;
        }
        //
        private string _ad;
        private string _tc;
        private int _id;
        public int Id { get {return _id; } }
        public string Ad { 
            get { 
                return _ad; 
            }
            set
            {
                if (value.Length >30)
                {
                    throw new Exception("kullanıcı adı sınırı");
                }
                _ad = value;    
            }
        
        }
        public string SoyAd { get; set; }

        public string TCNumara {
            get
            {
                return TcSansürle(_tc);
            } 
            set
            {
                _tc = value;
            }
        
        }
        public DateTime  DoğumTarihi { get; set; }
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public KanGrubu KanGrubu { get; set; }

        private string TcSansürle(string tc) => tc.Substring(0, 7) + "****";


            

    }
}
