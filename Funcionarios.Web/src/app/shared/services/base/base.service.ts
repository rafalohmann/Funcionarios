import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

import { Observable } from "rxjs/Observable";
import { of } from "rxjs/observable/of";
import { catchError, map, tap } from "rxjs/operators";
import { MensagemService } from "../mensagem.service";

export abstract class BaseService<T> {
  public abstract endpointUrl = "api/base_url"; // URL to web api
  httpOptions = {
    headers: new HttpHeaders({ "Content-Type": "application/json" })
  };

  constructor(
    private _http: HttpClient,
    private _mensagemService: MensagemService
  ) {}

  /** GET from the server */
  getMany(): Observable<T[]> {
    return this._http.get<T[]>(this.endpointUrl).pipe(
      // tap(bases => this.log(`fetched bases`)),
      catchError(this.handleError("getMany", []))
    );
  }

  /** GET base by id. Will 404 if id not found */
  get(id: any): Observable<T> {
    const url = `${this.endpointUrl}/${id}`;
    return this._http.get<T>(url).pipe(
      // tap(_ => this.log(`fetched base id=${id}`)),
      catchError(this.handleError<T>(`get id=${id}`))
    );
  }

  /** PUT: update the base on the server */
  update(base: T): Observable<any> {
    return this._http.put(this.endpointUrl, base, this.httpOptions).pipe(
      // tap(_ => this.log(`updated base id=${base.id}`)),
      catchError(this.handleError<any>("update"))
    );
  }

  /** POST: add a new base to the server */
  add(base: T): Observable<T> {
    return this._http.post<T>(this.endpointUrl, base, this.httpOptions).pipe(
      //   tap((base: T) => this.log(`added base w/ id=${base.id}`)),
      catchError(this.handleError<T>("add"))
    );
  }

  /** DELETE: delete the base from the server */
  delete(base: T): Observable<T> {
    return this._http
      .request<T>("delete", this.endpointUrl, {
        ...{ body: base },
        ...this.httpOptions
      })
      .pipe(
        // tap(_ => this.log(`deleted base id=${id}`)),
        catchError(this.handleError<T>("delete"))
      );
  }

  /** Log a BaseService mensagem with the MensagemService */
  private log(mensagem: string) {
    this._mensagemService.add("BaseService: " + mensagem);
  }

  /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
  // tslint:disable-next-line:no-shadowed-variable
  private handleError<T>(operation = "operation", result?: T) {
    return (error: any): Observable<T> => {
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.mensagem}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
