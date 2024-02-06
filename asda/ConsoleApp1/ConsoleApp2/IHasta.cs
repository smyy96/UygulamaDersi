namespace ConsoleApp2
{
    public interface IHasta
    {
        public List<IRandevu> Randevular { get; set; }
        public List<IHastalık> Hastalıklar { get; set; }
    }
}
