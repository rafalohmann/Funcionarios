import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";
import { NavbarComponent } from "./components/navbar/navbar.component";
import { FooterComponent } from "./components/footer/footer.component";
import { MensagemComponent } from "./components/mensagem/mensagem.component";
import { PageNotFoundComponent } from "./components/page-not-found/page-not-found.component";

@NgModule({
  imports: [CommonModule, RouterModule],
  declarations: [
    NavbarComponent,
    FooterComponent,
    MensagemComponent,
    PageNotFoundComponent
  ],
  exports: [
    NavbarComponent,
    FooterComponent,
    MensagemComponent,
    PageNotFoundComponent
  ]
})
export class SharedModule {}
