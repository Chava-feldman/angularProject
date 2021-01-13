import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserSerService } from '../user-ser.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent  {

  sss:boolean=false;

  ifInCorrentPassword:boolean=false;
  constructor(public userSer:UserSerService,private router: Router) {
   }



   
   checkLogin(name:string,password:string){
     this.sss=true;
    
    this.userSer.ifExistName(name).subscribe(p=>{ if(p==true){this.checkLoginwithPassword(name,password)}else this.changeRoutingToRegister(name)} ,err=> { console.log(err); })
  }

  checkLoginwithPassword(name:string,password:string){
    this.userSer.ifExistNamePassword(name,password).subscribe(p=> {if (p==null){this.ifInCorrentPassword=true ;} else{ this.changeRoutingToRecipe(); this.userSer.updateCurentUser(p) }},err=> { console.log(err); })

  }
 
  changeRoutingToRegister(name:string){
      this.router.navigate(['register',name]);
  }

  changeRoutingToRecipe(){
    this.router.navigate(['listrecipe']);
  }
}
//this.router.navigate(['register',this.loginForm.controls['UserName'].value]);‏‏

