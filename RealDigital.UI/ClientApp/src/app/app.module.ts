import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
//import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatProgressSpinnerModule } from '@angular/material';
import { DragDropModule } from '@angular/cdk/drag-drop';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { CdkTableModule } from '@angular/cdk/table';
import { CdkTreeModule } from '@angular/cdk/tree';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ContactDetailsComponent } from './components/contact-details/contact-details.component';
import { ContactComponent } from './components/contact/contact.component';
import { ContactEditComponent } from './components/contact-edit/contact-edit.component';
import { LoaderComponent } from './components/loader/loader.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ContactComponent,
    ContactDetailsComponent,
    ContactEditComponent,
    LoaderComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatProgressSpinnerModule,
    BrowserAnimationsModule,
    DragDropModule,
    ScrollingModule,
    CdkTableModule,
    CdkTreeModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'contact', component: ContactComponent },
      { path: 'contact/:id', component: ContactDetailsComponent },
      { path: 'contact/:id/edit', component: ContactEditComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
