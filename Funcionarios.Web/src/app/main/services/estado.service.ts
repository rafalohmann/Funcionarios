import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

import { Observable } from "rxjs/Observable";
import { of } from "rxjs/observable/of";
import { catchError, map, tap } from "rxjs/operators";
import { BaseService } from "../../shared/services/base/base.service";
import { Estado } from "../models/estado";
import { MensagemService } from "../../shared/services/mensagem.service";

@Injectable()
export class EstadoService extends BaseService<Estado> {
  endpointUrl = "http://localhost/Funcionarios.Api/api/estado"; // URL to web api

  constructor(
    private http: HttpClient,
    private mensagemService: MensagemService
  ) {
    super(http, mensagemService);
  }
}
