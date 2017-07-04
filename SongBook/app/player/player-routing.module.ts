import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";

import { SongListComponent } from "./song-list/song-list.component";
import { SongDetailsComponent } from "./song-details/song-details.component";

@NgModule({
    imports: [
        RouterModule.forChild([
            { path: "", component: SongDetailsComponent },
            { path: "song/:id", component: SongDetailsComponent }
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class PlayerRoutingModule {}