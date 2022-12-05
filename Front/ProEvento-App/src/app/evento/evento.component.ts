import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-evento',
  templateUrl: './evento.component.html',
  styleUrls: ['./evento.component.scss']
})
export class EventoComponent implements OnInit {

  public eventos: any = [];
  public eventosFiltrados: any = [];
  larguraImagem: number = 150;
  margemImagem: number = 2;
  exibirImagem: boolean = true;
  private _filtroLista: string = '';

  public get filtroLista():string {
    return this._filtroLista;
  }

  public set filtroLista(value:string){
     this._filtroLista = value;
     this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }
  filtrarEventos(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
     (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
    evento.local.toLocaleLowerCase().indexOf(filtrarPor)  !== -1 ||
    evento.dataEvento.toLocaleLowerCase().indexOf(filtrarPor)  !== -1
    );
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

alterarImagem(){
  this.exibirImagem = !this.exibirImagem;
}

public getEventos(): void {
  this.http.get('https://localhost:5001/api/eventos').subscribe (
    Response => {
      this.eventos = Response;
      this.eventosFiltrados
    },
    error => console.log(error)
  );

}
}



