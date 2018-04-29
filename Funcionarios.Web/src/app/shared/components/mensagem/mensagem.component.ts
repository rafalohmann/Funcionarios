import { Component, OnInit } from "@angular/core";
import { MensagemService } from "../../services/mensagem.service";

@Component({
  selector: "app-mensagem",
  templateUrl: "./mensagem.component.html",
  styleUrls: ["./mensagem.component.css"]
})
export class MensagemComponent implements OnInit {
  constructor(public messageService: MensagemService) {}

  ngOnInit() {}
}
