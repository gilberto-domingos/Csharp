using DevLabs.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace DevLabs.Api.Repositories;

public class CarChassiValidatorRepository: ICarChassiValidatorRepository
{
    private readonly ApiDbContext _context;

    public CarChassiValidatorRepository(ApiDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> CheckIfValidAsync(int chassi, CancellationToken cancelToken)
    {
        return await _context.Cars.AnyAsync(car => car.Chassi == chassi, cancelToken);
    }
}