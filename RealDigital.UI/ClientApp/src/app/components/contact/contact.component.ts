import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Contact } from '../../models/contact.model';
import { ContactService } from '../../services/contact.service';
import { faCoffee, faUserPlus } from '@fortawesome/free-solid-svg-icons';

@Component({
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  constructor(private contactService: ContactService, private router: Router) { }


  ngOnInit() {
    this.contactService.getContacts().subscribe(
      (res: Contact[]) => {
        this.contacts = res;
        
      },
      err => { }
    ).add(() => {
      this.loading = false;
    });
  }

  contacts: Contact[];
  loading: boolean = true;
  faCoffee = faCoffee;
  faUserPlus = faUserPlus;
}
