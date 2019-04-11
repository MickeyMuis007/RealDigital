import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  templateUrl: './contact-delete.component.html',
  styleUrls: ['./contact-delete.component.css']
})
export class ContactDeleteComponent implements OnInit {
  constructor(private router: Router, private route: ActivatedRoute, private contactService: ContactService) { }

  private id: string;

  ngOnInit() {
    this.id = this.route.snapshot.params['id'];
  }

  delete() {
    this.contactService.deleteContact(this.id).subscribe(
      res => {
        this.router.navigate(['/contact']);
      },
      err => {
        console.error(err);
      }
    )
  }
}
