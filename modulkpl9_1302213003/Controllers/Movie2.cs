using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Numerics;
using System.Reflection.Metadata;

namespace modulkpl9_1302213003.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movie2 : ControllerBase
    {
        public static List<Movie> a = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont","Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler","Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion." ),
            new Movie("The Godfather","Frank Darabont"," Marlon Brando","Al Pacino", "James Caan","Diane Keaton", "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie("The Dark Knight","Frank Darabont","Christian Bale","Heath Ledger", "Aaron Eckhart", "Michael Caine", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };
        // GET: api/<Movie2>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return a;
        }

        // GET api/<Movie2>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            return a[id];
        }

        // POST api/<Movie2>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            a.Add(value);
        }

        // DELETE api/<Movie2>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            a.RemoveAt(id);
        }
    }
}

