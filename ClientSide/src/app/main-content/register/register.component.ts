import { Component, OnInit } from '@angular/core';
import { ValueService } from 'src/app/services/value.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private valueService: ValueService, ) { }

  ngOnInit(): void {
  }

  GetValue(){
    this.valueService.GetValue();
  }
}
