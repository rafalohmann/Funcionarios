import { Component, OnInit } from "@angular/core";
import { Estado } from "../../../models/estado";
import { EstadoService } from "../../../services/estado.service";

@Component({
  selector: "app-estado-pesquisa",
  templateUrl: "./estado-pesquisa.component.html",
  styleUrls: ["./estado-pesquisa.component.css"]
})
export class EstadoPesquisaComponent implements OnInit {
  estados: Estado[];

  constructor(private estadoService: EstadoService) {}

  ngOnInit() {
    this.getEstados();
  }

  getEstados(): void {
    this.estadoService.getMany().subscribe(estados => (this.estados = estados));
  }
}
