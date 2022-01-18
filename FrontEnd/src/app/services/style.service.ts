import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Style } from '../interfaces/style';

@Injectable({
  providedIn: 'root'
})
export class StyleService {
  public url='http://localhost:35801/api/Style';
  constructor(public http: HttpClient) { }
  public getStyles():Observable<Style[]>{
    return this.http.get< Style[]>(`${this.url}`)
  }
}
