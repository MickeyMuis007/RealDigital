import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { ContactService } from '../../services/contact.service';
import { Contact } from 'src/app/models/contact.model';

@Component({
  templateUrl: './contact-details.component.html'
})
export class ContactDetailsComponent implements OnInit {
  constructor(private route: ActivatedRoute, private contactService: ContactService) { }

  ngOnInit() {
    this.id = this.route.snapshot.params['id'];
    this.contactService.getContactById(this.id).subscribe(
      (res: Contact) => {
        this.contact = res;
      },
      err => {
        console.error(err);
      }
    )
  }
  id: string;
  contact: Contact = new Contact();  
}
