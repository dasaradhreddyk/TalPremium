import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

import { HttpClient } from '@angular/common/http';



@Component({
  selector: 'example-app',
  templateUrl: './simple-form-component.html'

   
})
export class SimpleFormComp {
  errorMessage: string = "";
  public http: HttpClient;
  public baseUrl: string;
  public premium: number = 0;
  public myInput: string = "";
  public name: string = "";
  public age: number = 0;
  public deathSumInsured: number = 0;
 
  public occupation: string = "";

  constructor(http: HttpClient
  ) {
    this.http = http;
    this.baseUrl = "";
  }
  onSubmit(f: NgForm) {

  }

  setValue(value: NgForm) {
    if (!value.valid ) { 
    this.errorMessage = "All feilds are mandatory";
    return;
    };  
    this.errorMessage = "";
    console.log(this.occupation);
    this.http.get<number>(this.baseUrl + "premium?name=" + this.name + "&age=" + this.age + "&amount=" + this.deathSumInsured + "&occupation=" + this.occupation).subscribe(result => {
      this.premium = result;
    }, error => console.error(error));
  }
}

function Inject(arg0: string) {
  throw new Error('Function not implemented.');
}
