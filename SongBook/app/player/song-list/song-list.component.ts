import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

import { Song } from "../../services/song/song";
import { SongService } from "../../services/song/song.service";

@Component({
    moduleId: module.id,
    selector: "song-list",
    templateUrl: "song-list.component.html",
    styleUrls: ["song-list.component.css"]
})
export class SongListComponent implements OnInit {
    songs;

    constructor(private router: Router, private songService: SongService) {}

    ngOnInit() {
        this.songService
            .getAll()
            .then(result => this.songs = result);
    }

    onSelect(selected: Song) {
        this.router.navigate(["/song", selected.id])
    }
}