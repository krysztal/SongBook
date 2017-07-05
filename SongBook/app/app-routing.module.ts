import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";

import { PlayerComponent } from "./player/player.component";
import { LoginComponent } from "./login/login.component";

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
        },
        {
            path: "login",
            component: LoginComponent
        }
    ])],
    exports: [RouterModule]
})
export class AppRoutingModule { }