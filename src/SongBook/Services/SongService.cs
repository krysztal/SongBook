using System;
using System.Collections.Generic;
using SongBook.Entities;
using SongBook.Repositories;

namespace SongBook.Services
{
    public class SongService : ISongService
    {
        ISongRepository SongRepository;
        public SongService(ISongRepository songRepository)
        {
            SongRepository = songRepository;
        }

        public Song GetSong(int id)
        {
            return SongRepository.GetSong(id);
        }

        public IEnumerable<Song> GetSongs()
        {
            return SongRepository.GetSongs();
        }

        public void RemoveSong(Song song)
        {
            SongRepository.RemoveSong(song);
        }

        public Song UpdateSong(Song song)
        {
            return SongRepository.UpdateSong(song);
        }
    }
}
