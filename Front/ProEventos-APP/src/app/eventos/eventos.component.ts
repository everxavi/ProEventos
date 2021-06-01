import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos : any = [
    {
      Tema: "Angular 12",
      Local: "Rio Grande do Norte"
    },

    {
      Tema: ".Net Core",
      Local: "Paraíba"
    }
  ]

  constructor() { }

  ngOnInit() {
  }

}
