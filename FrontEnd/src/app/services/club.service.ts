import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Club} from '../interfaces/club';
import {Trainer} from '../interfaces/trainer';

@Injectable({
  providedIn: 'root'
})
export class ClubService {
  public url='https://localhost:44353/api/Club';
  constructor(public http: HttpClient) { }
  public getClubs():Observable<Club[]>{
    return this.http.get< Club[]>(`${this.url}`)
  }
  public getClubTrainers(id: number):Observable<Trainer[]>{
    return this.http.get< Trainer[]>(`${this.url}/get-trainers?id=${id}`)
  }
  public addClub(club : Club): Observable<Club[]>{
    return this.http.post<Club[]>(`${this.url}`,club);
  }

}
