import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { HttpClient, HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";

import { DashboardComponent } from "./components/dashboard/dashboard.component";
import { EstadosComponent } from "./components/estados/estados.component";
import { EstadoPesquisaComponent } from "./components/estados/estado-pesquisa/estado-pesquisa.component";
import { EstadoDetalheComponent } from "./components/estados/estado-detalhe/estado-detalhe.component";
import { CidadePesquisaComponent } from "./components/cidades/cidade-pesquisa/cidade-pesquisa.component";
import { CidadeDetalheComponent } from "./components/cidades/cidade-detalhe/cidade-detalhe.component";
import { CidadesComponent } from "./components/cidades/cidades.component";

import { MensagemService } from "../shared/services/mensagem.service";
import { EstadoService } from "./services/estado.service";

@NgModule({
  imports: [CommonModule, HttpClientModule, RouterModule],
  declarations: [
    DashboardComponent,
    EstadosComponent,
    EstadoPesquisaComponent,
    EstadoDetalheComponent,
    CidadesComponent,
    CidadeDetalheComponent,
    CidadePesquisaComponent
  ],
  providers: [HttpClient, EstadoService, MensagemService]
})
export class MainModule {}
