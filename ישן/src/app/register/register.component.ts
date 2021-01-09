import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserSerService } from '../user-ser.service';
import {NgForm} from '@angular/forms';
import { User } from 'src/modals/User';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  name:string="";
  constructor(public userSer:UserSerService , public active:ActivatedRoute, public  router:Router) { 
    active.params.subscribe(param=>{
      console.log(param);
      this.name=param["name"];
    },err=>{})
  }
  mail:string;
  address:string="";
  password:string;

  addUser(){
     

    this.userSer.addUser(new User(0, this.name, this.address, this.mail, this.password) ).subscribe(p=> {if(p==true)console.log("נוסף בהצלחה"); this.changeRoutingToRecipe()},err=> console.log(err))
    this.userSer.getAllUser().subscribe(p=> console.log(p),err=> console.log(err))

  }

 

  sendForm(m) { 
    console.log("finish")
  }

  changeRoutingToRecipe(){
    this.router.navigate(['listrecipe']);
  }


  ngOnInit(): void {
  }

}
