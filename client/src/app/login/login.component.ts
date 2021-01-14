import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { User } from 'src/modals/User';
import { UserSerService } from '../user-ser.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnDestroy {
  subscription: Subscription = null;
  arrUser: User[] = [];
  sss: boolean = false;

  ifInCorrentPassword: boolean = false;
  constructor(public userSer: UserSerService, private router: Router) {
    console.log(userSer.getFlag())
    sessionStorage.setItem('user', null);
    localStorage.setItem('user', null);
    this.subscription = this.userSer.getAllUser().subscribe(p => { this.arrUser = p; console.log(this.arrUser) }, err => console.log(err));
    
  }

  newFlag1: boolean = false;
  checkLogin(name: string, password: string) {
    if (name[name.length - 1] == ' ')
      name = name.substr(0, name.length - 1)
    this.sss = true;
    this.arrUser.forEach((item) => {
      console.log(item.code + "item")
      if (item.name == name) {
        this.checkLoginwithPassword(name, password);
        this.newFlag1 = true;
        // return true;
      }
    })
    if (!this.newFlag1)
      this.changeRoutingToRegister(name);
  }

  checkLoginwithPassword(name: string, password: string) {
    this.arrUser.forEach((item) => {
      if (item.name == name && item.password == password) {
        this.changeRoutingToRecipe();
        this.userSer.updateCurentUser(item);
      }
    })
    this.ifInCorrentPassword = true;

  }
  changeRoutingToRegister(name: string) {
    this.router.navigate(['register', name]);

  }
  changeRoutingToRecipe() {
    this.userSer.flag = true;
    this.router.navigate(['listrecipe']);
  }
  ngOnDestroy(): void {
    if (this.subscription)
      this.subscription.unsubscribe();
  }
}



