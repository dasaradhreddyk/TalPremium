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
  public dob: Date;;
 
  public occupation: string = "";

  constructor(http: HttpClient
  ) {
    this.dob = new Date('1/1/2000');
    this.http = http;
    this.baseUrl = "";
  }
  onSubmit(f: NgForm) {

  }

  setAge(value: NgForm) {
   // this.age = calculateAge(this.dob);
    console.log(this.dob);
    
   
  }

  setValue(value: NgForm) {
    console.log(this.dob);
    this.age = calculateAge(this.dob, new Date());
    console.log(this.age);
    if (!value.valid ) { 
    this.errorMessage = "All feilds are mandatory";
    return;
    };  
    this.errorMessage = "";
    if (this.deathSumInsured < 0) {
      this.errorMessage = "Death Amount Insured should be positive value";
      return;
    }

    console.log(this.occupation);
    this.http.get<number>(this.baseUrl + "premium?name=" + this.name + "&age=" + this.age + "&amount=" + this.deathSumInsured + "&occupation=" + this.occupation).subscribe(result => {
      this.premium = result;
    }, error => console.error(error));

    
  }
  
}
function calculateAge(dob :Date,dt :Date) {
 
  dt = dt || new Date();
  var diff = dt.getTime() - new Date(dob).getTime();
  return Math.floor(diff / (1000 * 60 * 60 * 24 * 365.25));
}

function Inject(arg0: string) {
  throw new Error('Function not implemented.');
}
