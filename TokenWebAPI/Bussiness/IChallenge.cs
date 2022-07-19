using TokenWebAPI.Model;

namespace TokenWebAPI.Bussiness
{
    public interface IChallenge
    {
        Cars GetCars();
        Car AddCar(Car car);
    }
}
