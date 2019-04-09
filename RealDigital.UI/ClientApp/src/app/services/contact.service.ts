import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Contact } from '../models/contact.model';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  constructor(private httpClient: HttpClient) { }

  private baseUrl: string = location.origin + '/api/contact';

  getContacts(): Observable<Contact[]> {
    return this.httpClient.get<Contact[]>(this.baseUrl);
  }

  getContactById(id): Observable<Contact> {
    return this.httpClient.get<Contact>(this.baseUrl + '/' + id);
  }

  addContact(contact: Contact): Observable<Contact> {
    return this.httpClient.post<Contact>(this.baseUrl, contact);
  }

  updateContact(contact: Contact) {
    return this.httpClient.put(this.baseUrl, contact);
  }

  deleteContact(id) {
    return this.httpClient.delete<Contact>(this.baseUrl + '/' + id);
  }
}
