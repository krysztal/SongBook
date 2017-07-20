import { Component, OnInit } from "@angular/core";
import { AudioService } from "../shared/audio.service";

@Component({
    moduleId: module.id,
    selector: "player-bar",
    templateUrl: "player-bar.component.html",
    styleUrls: ["player-bar.component.css"]
})
export class PlayerBarComponent implements OnInit {
    duration: string = "00:00";
    elapsed: string = "00:00";
    positionInProc:number;
    playing:boolean = false;

    constructor(private audioService:AudioService ) {
    }

    ngOnInit() {
        this.audioService.audio.onended = this.handleEnded.bind(this);
        this.audioService.audio.ontimeupdate = this.handleTimeUpdate.bind(this);
    }

    handleEnded() {
        this.playing = false;
    }

    handleTimeUpdate() {
        const elapsed = this.audioService.audio.currentTime;
        const duration = this.audioService.audio.duration;

        this.positionInProc = elapsed / duration * 100;
        this.elapsed = this.audioService.formatTime(elapsed);
        this.duration = this.audioService.formatTime(duration);
    }
    

    play() {
        this.audioService.play();
        this.playing = true;
    }

    pause() {
        this.audioService.pause();
        this.playing = false;
    }

    stop() {
        this.audioService.stop();
        this.playing = false;
    }

    changePosition(event) {
        const duration = this.audioService.audio.duration;
        const processBarWidth = document.getElementById("progressBar").offsetWidth;

        if(duration) {
            const position = event.offsetX / processBarWidth;
            this.audioService.audio.currentTime = Math.round(duration * position);
        }
        

        
    }

}