using LaboratorioDeTestesAPI.Data;
using LaboratorioDeTestesAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioDeTestesAPI.Repositories
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
    }
}
