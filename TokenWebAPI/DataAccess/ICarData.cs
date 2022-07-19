using TokenWebAPI.Model;

namespace TokenWebAPI.DataAccess
{
    public interface ICarData
    {
        Cars GetCars();
        Car InsertCar(Car car);
    }
}
