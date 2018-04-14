import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { PagesRoutingModule } from "./pages-routing.module";
import { SimplePageComponent } from "./simple-page/simple-page.component";

@NgModule({
  imports: [CommonModule, PagesRoutingModule],
  declarations: [SimplePageComponent]
})
export class PagesModule {}
