// import { NgModule } from "@angular/core";
// import { RouterModule } from "@angular/router";

// import { PlayerComponent } from "./player.component";
// import { SongListComponent } from "./song-list/song-list.component";
// import { SongDetailsComponent } from "./song-details/song-details.component";

// @NgModule({
//     imports: [
//         RouterModule.forChild([
//             { 
//                 path: "songs", 
//                 component: PlayerComponent, 
//                 children: [
//                     {
//                         path: ":id",
//                         component: SongDetailsComponent,
//                     },
//                     {
//                         path: "",
//                         component: SongDetailsComponent,
//                     }
                    
//                 ]
//             }
//         ])
//     ],
//     exports: [
//         RouterModule
//     ]
// })
// export class PlayerRoutingModule {}