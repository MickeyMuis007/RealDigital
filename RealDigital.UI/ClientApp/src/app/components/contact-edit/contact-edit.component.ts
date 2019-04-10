import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

import { ContactService } from 'src/app/services/contact.service';
import { Contact } from 'src/app/models/contact.model';

@Component({
  templateUrl: './contact-edit.component.html'
})
export class ContactEditComponent implements OnInit {
  constructor(private route: ActivatedRoute,
    private contactService: ContactService,
    private formBuilder: FormBuilder) { }

  title: string;
  private id: string;
  contact: Contact;
  contactFormGroup: FormGroup;

  ngOnInit() {
    this.id = this.route.snapshot.params['id'];
    if (this.id === "0")
      this.title = "Add";
    else {
      this.title = "Edit";
      this.contactService.getContactById(this.id).subscribe(
        (res: Contact) => {
          this.setContact(res);
        },
        err => {
          console.error(err);
        }
      );
    }
    this.buildFormGroup();
  }

  private setContact(contact: Contact) {
    this.contactFormGroup.controls.firstName.setValue(contact.firstName);
    this.contactFormGroup.controls.lastName.setValue(contact.lastName);
    this.contactFormGroup.controls.phoneNo.setValue(contact.phoneNo);
    this.contactFormGroup.controls.email.setValue(contact.email);
  }

  private buildFormGroup() {
    this.contactFormGroup = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      phoneNo: ['', Validators.required],
      email: ['', Validators.email]
    });
  }
}
