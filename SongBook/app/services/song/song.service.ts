import { Injectable } from "@angular/core";

import { Song } from "./song"

let songs = [
    new Song(1, "Song1", "SongText1"),
    new Song(2, "Song2", "SongText2"),
    new Song(3, "Song3", "SongText3"),
    new Song(4, "Song4", "SongText4"),
    new Song(5, "Song5", "SongText5"),
    new Song(6, "Song6", "SongText6"),
    new Song(7, "Song7", "SongText7")
];

let songPromise = Promise.resolve(songs);

@Injectable()
export class SongService {
    getAll(): Promise<Song[]> {
        return songPromise;
    }

    getSong(id: number): Promise<Song> {
        return songPromise
            .then(songs => songs.find(x => x.id == id));
    }
}