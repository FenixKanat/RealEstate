namespace RealEstate
{
    internal class Estate : IEstate
    {
        public int ID { get; set; }
        public Address Address { get; set; }
        public double Size { get; set; }
        public int Rooms { get; set; }
        public double Rent { get; set; }
    }
}
