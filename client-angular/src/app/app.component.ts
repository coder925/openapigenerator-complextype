import { Component } from '@angular/core';
import { Person, PersonsService } from './person-api';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  constructor(private personsService: PersonsService)
  {
  }

  ngOnInit()
  {
    let persons: Person[] = [];
    this.personsService.personsGet().subscribe(p => 
      {
        persons = p
        console.log('got person: ', p);
      }
      );
    this.personsService.personsPost(persons[0]);
  }

}
