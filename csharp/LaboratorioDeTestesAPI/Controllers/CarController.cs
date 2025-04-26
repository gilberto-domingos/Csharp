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

        [HttpGet("validate/{id}")]
        public async Task<IActionResult> ValidateChassi(Guid id, CancellationToken cancelToken)
        {
            bool isValid = await _carInterface.CheckIfValidAsync(id, cancelToken);
            return Ok(new { IsValid = isValid });
        }
    }
}
