import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateComponent } from './pages/create/create.component';
import { ViewDragDropComponent } from './pages/view-drag-drop/view-drag-drop.component';

const routes: Routes = [
  { path: '', component: CreateComponent },
  { path: 'drag-drop', component: ViewDragDropComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CryptosRoutingModule { }
