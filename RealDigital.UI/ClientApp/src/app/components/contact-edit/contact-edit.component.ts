import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

import { ContactService } from 'src/app/services/contact.service';
import { Contact } from 'src/app/models/contact.model';

import { NumberValidators } from 'src/app/shared/validator/number.validator'

@Component({
  templateUrl: './contact-edit.component.html',
  styleUrls: ['./contact-edit.component.css']
})
export class ContactEditComponent implements OnInit {
  constructor(private route: ActivatedRoute,
    private router: Router,
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
    this.contact = new Contact();
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
      phoneNo: ['', Validators.compose([Validators.required, NumberValidators.phoneNo])],
      email: ['', Validators.email]
    });
  }

  save() {
    if (this.contactFormGroup.valid) {
      this.contact.firstName = this.contactFormGroup.controls.firstName.value;
      this.contact.lastName = this.contactFormGroup.controls.lastName.value;
      this.contact.phoneNo = this.contactFormGroup.controls.phoneNo.value;
      this.contact.email = this.contactFormGroup.controls.email.value;

      if (this.id === "0") {
        this.contactService.addContact(this.contact).subscribe(
          res => {
            console.log(res);
            this.router.navigate(["/contact"]);
          },
          err => {
            console.error(err);
          }
        )
      } else {
        this.contactService.updateContact(this.id, this.contact).subscribe(
          res => {
            console.log("Update successfull");
            this.router.navigate(["/contact"]);
          },
          err => {
            console.error(err);
          }
        )
      }
    }
  }
}
