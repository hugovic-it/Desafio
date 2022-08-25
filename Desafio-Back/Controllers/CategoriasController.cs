using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NDogs.Data;
using NDogs.Models;

namespace NDogs.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }


        
    }
}