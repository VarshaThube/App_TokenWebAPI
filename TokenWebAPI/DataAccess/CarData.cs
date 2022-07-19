using TokenWebAPI.Model;

namespace TokenWebAPI.DataAccess
{
    public class CarData : ICarData
    {
        /// <summary>
        /// Get a List of Cars from Database
        /// </summary>
        /// <returns></returns>
        public Cars GetCars()
        {
            // here it will call database to get the List of car data 
            return (new Cars
            {
                cars = new List<Car>
            {
                 new Car { Id = 1, Brand = "string", Model = "string", Navigation = false },
            }
            });
        }
        /// <summary>
        /// Insert car data to database
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public Car InsertCar(Car car)
        {
            // here it will call database to to insert car data to database 
            return car;
        }
    }
}
