using LaboratorioDeTestes.Data;
using LaboratorioDeTestes.Entities;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioDeTestes.Repositories
{
    internal sealed class CarRepository : ICarRepository
    {
        private readonly ApiDbContext _context;

        public CarRepository(ApiDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckChassiExistsAsync(Guid id, CancellationToken cancelToken)
        {
            return await _context.Cars.AnyAsync(car => car.Id == id, cancellationToken: cancelToken);
        }

        public async Task<Car> AddAsync(Car car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
            return car;
        }

        public async Task<Car?> GetByIdAsync(Guid id, CancellationToken cancelToken)
        {
            return await _context.Cars
                .FirstOrDefaultAsync(car => car.Id == id, cancellationToken: cancelToken);
        }
    }
}
