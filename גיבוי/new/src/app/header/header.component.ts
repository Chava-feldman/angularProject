import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
flag:boolean=false;
  constructor() {
    //  if(localStorage.getItem('user')!='')
      //  this.flag=true;
    
  }

  ngOnInit(): void {
  }

func(){
  console.log("sdfaf");
}
}
