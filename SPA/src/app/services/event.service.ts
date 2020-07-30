import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { EventModel } from '../models/event.model';

@Injectable({
  providedIn: 'root'
})
export class EventService {

  constructor(private httpClient: HttpClient) {
  }

  public getAll(): Observable<Array<EventModel>> {
    return this.httpClient.get<Array<EventModel>>(`${environment.apiBaseUrl}/event`);
  }

  public getById(id: number): Observable<EventModel> {
    return this.httpClient.get<EventModel>(`${environment.apiBaseUrl}/event/${id}`);
  }

}
