using Domain.Entites;
using Infrastructure.DataContext;
using System.Collections.Generic;
using System.Linq;

public class CarRepository
{
    private readonly AppDbContext _dbContext;

    public CarRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Car> GetAllCars()
    {
        return _dbContext.Cars.ToList();
    }

    public Car GetCarById(int carId)
    {
        return _dbContext.Cars.FirstOrDefault(c => c.CarId == carId);
    }

    public void AddCar(Car car)
    {
        _dbContext.Cars.Add(car);
        _dbContext.SaveChanges();
    }

    public void UpdateCar(Car car)
    {
        _dbContext.Cars.Update(car);
        _dbContext.SaveChanges();
    }

    public void DeleteCar(Car car)
    {
        _dbContext.Cars.Remove(car);
        _dbContext.SaveChanges();
    }
}
