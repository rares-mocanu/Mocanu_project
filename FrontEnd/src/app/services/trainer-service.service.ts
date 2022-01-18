import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Trainer} from '../interfaces/trainer';
import { AddTrainer } from '../interfaces/addTrainer';
@Injectable({
  providedIn: 'root'
})
export class TrainerService {
  public url='http://localhost:35801/api/Trainer';
  constructor(public http: HttpClient) { }
  public getTrainers():Observable<Trainer[]>{
    return this.http.get< Trainer[]>(`${this.url}`)
  }
  public getTrainerById(id: any):Observable<Trainer>{
    return this.http.get< Trainer>(`${this.url}/get-by-id?id=${id}`)
  }
  public addTrainer(trainer : AddTrainer): Observable<AddTrainer[]>{
    return this.http.post<AddTrainer[]>(`${this.url}`,trainer);
  }
}
