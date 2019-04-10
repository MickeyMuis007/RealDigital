import { Component, OnInit } from '@angular/core';
import { Contact } from '../models/contact.model';
import { ContactService } from '../services/contact.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  constructor(private contactService: ContactService) {}


  ngOnInit() {
    this.contactService.getContacts().subscribe(
      (res: Contact[]) => {
        this.contacts = res;
      },
      err => { }
    );
  }

  contacts: Contact[];
}
