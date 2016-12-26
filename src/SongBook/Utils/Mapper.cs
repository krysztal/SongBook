using System.Collections.Generic;
using SongBook.Entities;
using SongBook.Dtos;

namespace SongBook.Utils
{
    public static class Mapper
    {
        public static Song Map(SongDto songDto)
        {
            Song song = new Song()
            {
                Id = songDto.Id,
                Name = songDto.Name
            };

            return song;
        }

        public static SongDto Map(Song song)
        {
            SongDto songDto = new SongDto()
            {
                Id = song.Id,
                Name = song.Name
            };

            return songDto;
        }
    }
}
