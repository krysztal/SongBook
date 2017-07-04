import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { PlayerComponent } from "./player.component";
import { PlayerBarComponent } from "./player-bar/player-bar.component";
import { SongListComponent } from "./song-list/song-list.component";
import { SongDetailsComponent } from "./song-details/song-details.component";

//import { PlayerRoutingModule } from "./player-routing.module"

import { SongService } from "../services/song/song.service"

@NgModule({
    imports: [
        CommonModule
    ],
    declarations: [
        PlayerBarComponent
        // SongListComponent,
        // SongDetailsComponent
    ],
    providers: [SongService]
    
})
export class PlayerModule {}