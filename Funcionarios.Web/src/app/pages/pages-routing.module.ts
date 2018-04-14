import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { SimplePageComponent } from "./simple-page/simple-page.component";

const routes: Routes = [
  {
    path: "",
    children: [
      {
        path: "simple-page",
        component: SimplePageComponent,
        data: {
          breadcrumb: "Simple Page"
        }
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PagesRoutingModule {}
