using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LaboratorioDeTestesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICar _carInterface;

        public CarController(ICar carInterface)
        {
            _carInterface = carInterface;
        }

        [HttpGet("validate/{id:guid}", Name = "ValidateChassi")]
        public async Task<IActionResult> ValidateChassi(Guid id, CancellationToken cancelToken)
        {
            bool isValid = await _carInterface.CheckIfValidAsync(id, cancelToken);
            return Ok(new { IsValid = isValid });
        }

        [HttpPost(Name = "CreateCarAsync")]
        public async Task<IActionResult> CreateAsync(CarDto carDto)
        {
            var createdCar = await _carInterface.CreateAsync(carDto);

            if (createdCar == null)
                return NotFound();

            return Ok(createdCar);

        }

        [HttpGet("{id:guid}", Name = "GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancelToken)
        {
            var car = await _carInterface.GetByIdAsync(id, cancelToken);

            if (car == null)
                return NotFound();

            return Ok(car);
        }
    }
}
