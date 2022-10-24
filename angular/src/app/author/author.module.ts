import { NgModule } from '@angular/core';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap';
import { SharedModule } from '../shared/shared.module';
import { AuthorComponent } from './author.component';
import { AuthorRoutingModule } from './author-routing.module';

@NgModule({
  declarations: [AuthorComponent],
  imports: [SharedModule, AuthorRoutingModule, NgbDatepickerModule],
})
export class AuthorModule {}
