import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";

import { PlayerComponent } from "./player/player.component"

@NgModule({
    imports: [RouterModule.forRoot([
        {
            path: "",
            redirectTo: "player",
            pathMatch: "full"
        },
        {
            path: "player",
            component: PlayerComponent
        }
    ])],
    exports: [RouterModule]
})
export class AppRoutingModule { }