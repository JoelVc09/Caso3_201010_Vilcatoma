using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caso3_201010_Vilcatoma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DoctorCreateDTO customerDTO)
        {
            var customer = _mapper.Map<DoctorController>(customerDTO);

            var result = await _customerRepository.Insert(customer);
            if (!result)
                return BadRequest();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerRepository.GetCustomers();
            var customerList = _mapper.Map<List<DoctorDTO>>(customers);
            return Ok(customerList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _customerRepository.GetCustomerById(id);
            if (customer == null)
                return NotFound();

            var customerDTO = _mapper.Map<DoctorDTO>(customer);
            return Ok(customerDTO);
        }

    }
}
