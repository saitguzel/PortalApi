using System;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Portal.Application.Categories.Queries.Model;
using Portal.Domain.Entities;
using Portal.Infrastructure.Persistence;

namespace Portal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryController(IRepository<Category> categoryRepository,IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCategory()
        {
            var categories = _categoryRepository.GetAll.ProjectTo<CategoryDTO>(_mapper.ConfigurationProvider).ToList();
            return Ok(categories);
        }
    }
}
