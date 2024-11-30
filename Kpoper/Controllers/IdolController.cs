using Kpoper.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using Kpoper.Server.Mapper;
using Kpoper.DTOs;
using Kpoper.Entities;

namespace Kpoper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdolController : ControllerBase
    {
        private readonly DataContext _context;
        private HttpClient client = new HttpClient();
        private HttpRequestMessage request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://k-pop.p.rapidapi.com/idols/random"),
            Headers =
    {
        { "x-rapidapi-key", "dfc49f9a67mshc5ebc5f88ae5491p173298jsn8a1748ca8bf3" },
        { "x-rapidapi-host", "k-pop.p.rapidapi.com" },
    },
        };

        public IdolController(DataContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<ActionResult<List<Idol>>> AddIdol(Idol _idol)
        {
            using (var response = await client.SendAsync(request))
            {

                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadFromJsonAsync<RapidIdolDTO>();

                //ReadAsStringAsync();
                Console.WriteLine(body.data.FirstOrDefault().FullName);


                _context.Idols.Add(body.data.FirstOrDefault());  

            await _context.SaveChangesAsync();


            }

            
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdolDTO>>> GetIdols()
        {
            return await _context.Idols
                .Select(x => x.ToIdolDTO())
                .ToListAsync();
        }

        // GET: api/Cinemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IdolDTO>> GetIdol(int id)
        {
            Kpoper.Entities.Idol? idol = await _context.Idols.FindAsync(id);

            return idol == null
                ? BadRequest() :
                Ok(idol.ToIdolDTO());
        }
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Idol>>> GetIdols()
        //{
        //    return await _context.Idols.ToListAsync();
        //}

        //// GET: api/Authors/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Idol>> GetIdol(int id)
        //{
        //    var idol = await _context.Idols.FindAsync(id);

        //    if (idol == null)
        //    {
        //        return NotFound();
        //    }

        //    return idol;
        //}

        //[HttpGet]
        //public async Task<ActionResult<List<Idol>>> GetAllIdols() {
        //    return Ok(await _context.Idols.ToListAsync());
        //}

        //public IQueryable<IdolDTO> GetIdols() 
        //{   var idols= from b in sqllite
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Idol>> GetIdol(int id)         {
        //    var idol = await _context.Idols.FindAsync(id);
        //    if (idol==null)
        //    {
        //        return BadRequest("Idol не найден");
        //    }
        //    return Ok(idol);
        //}
    }
}
