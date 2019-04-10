import { Component, OnInit } from '@angular/core';
import { Contact } from '../../models/contact.model';
import { ContactService } from '../../services/contact.service';

@Component({
  templateUrl: './contact.component.html',
})
export class ContactComponent implements OnInit {
  constructor(private contactService: ContactService) { }


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
