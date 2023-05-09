import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CryptosRoutingModule } from './cryptos-routing.module';
import { CreateComponent } from './pages/create/create.component';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { MatRadioModule } from '@angular/material/radio';
import { MatCardModule } from '@angular/material/card';
import { ReactiveFormsModule } from '@angular/forms';
import { ViewDragDropComponent } from './pages/view-drag-drop/view-drag-drop.component';
import { DragDropModule } from '@angular/cdk/drag-drop';


@NgModule({
  declarations: [
    CreateComponent,
    ViewDragDropComponent
  ],
  imports: [
    CommonModule,
    CryptosRoutingModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule,
    MatRadioModule,
    MatCardModule,
    ReactiveFormsModule,
    DragDropModule
  ]
})
export class CryptosModule { }
