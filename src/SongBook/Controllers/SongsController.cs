using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SongBook.Entities;
using SongBook.Repositories;
using SongBook.Services;

namespace SongBook.Controllers
{
    [Route("api/[controller]")]
    public class SongsController : Controller
    {
        ISongService SongService;

        public SongsController(ISongService songService)
        {
            SongService = songService;
        }

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return SongService.GetSongs();
        }

        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return SongService.GetSong(id);
        }


        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
