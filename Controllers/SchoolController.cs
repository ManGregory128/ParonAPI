using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParonAPI.Dto;
using ParonAPI.Interfaces;
using ParonAPI.Models;
using ParonAPI.Repositories;

namespace ParonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly ISchoolRepository _schoolRepository;
        private readonly IMapper _mapper;
        public SchoolController(ISchoolRepository schoolRepository, IMapper mapper)
        {
            _schoolRepository = schoolRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<School>))]
        public IActionResult GetSchools()
        {
            var schools = _mapper.Map<List<SchoolDto>>(_schoolRepository.GetSchools());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(schools);
        }
    }
}
