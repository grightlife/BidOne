import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: [] 
})

export class HomeComponent implements OnInit {

  formGroup: FormGroup = new FormGroup({
    firstName: new FormControl("", [
      Validators.required,
    ]),
    lastName: new FormControl("", [
      Validators.required,
    ])
  });

  constructor(private httpClient: HttpClient) {}
  
  onSubmit() {
    this.httpClient.post('create', this.formGroup.value).subscribe(result => {
    }, error => console.error(error));
  }

  ngOnInit(): void {
    
  }
}
