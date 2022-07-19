namespace TokenWebAPI.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool Navigation { get; set; }
    }
    public class Cars
    {
        public List<Car> cars { get; set; }
    }
}
