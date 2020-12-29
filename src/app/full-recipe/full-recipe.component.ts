import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Recipe } from 'src/modals/Recipe';
import { CategoryService } from '../category.service';
import { RecipeServiceService } from '../recipe-service.service';
import { UserSerService } from '../user-ser.service';

@Component({
  selector: 'app-full-recipe',
  templateUrl: './full-recipe.component.html',
  styleUrls: ['./full-recipe.component.css']
})
export class FullRecipeComponent implements OnInit {

  myRecipe: Recipe;
  test: string;
  constructor(public active: ActivatedRoute, public router: Router, public recipeSer: RecipeServiceService, public categorySer: CategoryService, public userSer: UserSerService) {
    this.active.params.subscribe(param => {
      this.myRecipe = param["myRecipe"]
    })
    this.myFullRecipe = recipeSer.clickedRecipe;

    this.categorySer.getRecipeByCode(this.myFullRecipe.codeCategory).subscribe(p => this.nameCategoryOfMyFullRecipe = p.name, err => console.log(this.myFullRecipe.codeCategory));
    this.userSer.getAllUser().subscribe(p => {
      p.forEach(t => {
        console.log(t.name);
        if (t.code == this.myFullRecipe.userCode) {
          console.log(t.name);
          console.log("אני בתוך האיפ")
          this.test = t.name;
        }
      })
    })

  }
  myFullRecipe: Recipe;
  nameCategoryOfMyFullRecipe: String;

  getCatortyImg() {
    return "./assets/" + this.myFullRecipe.codeCategory + ".png";
  }

  counter() {
    return new Array(this.myFullRecipe.LevelDifficulty);
  }

  isTheSameUserAdded() {
    if (this.myFullRecipe.userCode == JSON.parse(localStorage.getItem('user')).code)
      return true;
    return false;
  }

  // getNameOfuserRecipe() {
  //   this.userSer.getAllUser().subscribe(p => {
  //     p.forEach(t => {
  //       console.log(t)
  //       if (t.code == this.myFullRecipe.userCode) {
  //         console.log(t.name);
  //         this.test = t.name;
  //       }
  //     })
  //   })
  // }


  ngOnInit(): void {
  }



}
