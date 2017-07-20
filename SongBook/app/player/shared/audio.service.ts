import { Injectable } from '@angular/core';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/debounceTime';
import 'rxjs/add/operator/distinctUntilChanged';


@Injectable()
export class AudioService {

  audio:HTMLAudioElement;

  constructor() {
    this.audio = new Audio();
    this.audio.volume = 0.6;
    this.load("http://e-spiewnik.da.redemptor.pl/music/Wierze%20w%20Ciebie%20Panie/Wierze%20w%20Ciebie%20Panie%20-%2078%20-%20RAZEM(minus).mp3");
  }

  load(url) {
    this.audio.src = url;
    this.audio.load();
  }


  play(url?:string) {
    if(url) {
      this.load(url);
    }
    this.audio.play()
  }

  pause() {
    this.audio.pause();
  }

  stop() {
    this.audio.pause();
    this.audio.currentTime = 0;
  }

  formatTime(seconds):string {
    if(seconds) {
      let minutes:any = Math.floor(seconds / 60);
      minutes = (minutes >= 10) ? minutes : "0" + minutes;
      seconds = Math.floor(seconds % 60);
      seconds = (seconds >= 10) ? seconds : "0" + seconds;
      return minutes + ":" + seconds;
    }
    else {
      return "00:00"
    }
  }
}