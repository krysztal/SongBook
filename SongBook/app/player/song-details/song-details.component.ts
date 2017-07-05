import { Component, OnInit } from "@angular/core";
import { Router, ActivatedRoute, Params } from "@angular/router";
import { Song } from "../../services/song/song";
import { SongService } from "../../services/song/song.service";

@Component({
    moduleId: module.id,
    selector: "song-details",
    templateUrl: "song-details.component.html",
    styleUrls: ["song-details.component.css"]
})
export class SongDetailsComponent implements OnInit {
    song: Song;

    constructor(private router: Router, 
        private activatedRoute: ActivatedRoute,
        private songService: SongService) {}

    ngOnInit() {
        this.activatedRoute.params.forEach((params: Params) => {
            let id = +params["song"];
            this.songService
                .getSong(id)
                .then(result => this.song = result);
        });
    }
} 