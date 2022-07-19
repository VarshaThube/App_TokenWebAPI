using TokenWebAPI.DataAccess;
using TokenWebAPI.Model;

namespace TokenWebAPI.Bussiness
{
    public class ChallengeRepo : IChallenge
    {
        private readonly ICarData _carData;
        public ChallengeRepo(ICarData carData)
        {
            _carData = carData;
        }
        /// <summary>
        /// Add new Car Deatils 
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public Car AddCar(Car car)
        {
            return _carData.InsertCar(car);
        }
        /// <summary>
        /// Get Car details
        /// </summary>
        /// <returns></returns>
        public Cars GetCars()
        {
            return _carData.GetCars();
            
        }
    }
}
