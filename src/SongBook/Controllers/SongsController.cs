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
        public void Post([FromBody]Song song)
        {
            SongService.UpdateSong(song);
        }

        [HttpPut("{id}")]
        public Song Put(int id, [FromBody]Song song)
        {
            return SongService.AddSong(song);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SongService.RemoveSong(id);
        }
    }
}
