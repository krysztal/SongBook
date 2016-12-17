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

        public Song AddSong(Song song)
        {
           return SongRepository.AddSong(song);
        }

        public void RemoveSong(int id)
        {
            SongRepository.RemoveSong(id);
        }

        public Song UpdateSong(Song song)
        {
            return SongRepository.UpdateSong(song);
        }
    }
}
