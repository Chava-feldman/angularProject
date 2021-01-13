import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { Category } from 'src/modals/Category';
import { Recipe } from 'src/modals/Recipe';
import { CategoryService } from '../category.service';
import { RecipeServiceService } from '../recipe-service.service';
import { UserSerService } from '../user-ser.service';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {
  allCategories: Category[] = [];

  constructor(public categorySer: CategoryService, public recipeSer: RecipeServiceService, public userSer: UserSerService) {
    this.categorySer.getAllCategories().subscribe(p => this.allCategories = p, err => console.log("cant got categories"))
  }

  ngOnInit(): void {
  }
  arringredients: string[] = [""];
  arrPreparation: string[] = [""];

  myNewRecipe: Recipe;
  str: string;


  addIndexArringredients(str: string) {
    if (this.arringredients[this.arringredients.length - 1] != "")
      this.arringredients.push("");
  }
  addIndexArrPreparation(str: string) {
    if (this.arrPreparation[this.arrPreparation.length - 1] != "")
      this.arrPreparation.push("");
  }

  trackByFn(index, item) {
    return index;
  }

  checkIfEmptyIngredient(e, i) {
    if (e.target.value == "") {

      this.arringredients.splice(i, i);

    }

  }
  checkIfEmptyPreparation(e, i) {
    if (e.target.value == "") {

      this.arrPreparation.splice(i, i);

    }
  }

  AddRecipe(nameRecipe: string, codeCategory: number, timeAtMinute: number, image: string, isShow: boolean) {
    this.myNewRecipe = new Recipe(
      codeCategory,
      nameRecipe,
      codeCategory,
      timeAtMinute,
      this.getLevelDiffulty(),
      new Date(),
      this.getIngredients(),
      this.getPreparation(),
      JSON.parse(localStorage.getItem('user')).code,
      image,
      isShow
    );
    console.log(this.myNewRecipe.LevelDifficulty);
    this.recipeSer.AddRecipe(this.myNewRecipe).subscribe(p => console.log(p), e => console.log(e));
    this.recipeSer.getsRecipes().subscribe(p => console.log(p), err => console.log(err));
  }
  getIngredients() {
    this.str = "";
    this.arringredients.splice(this.arringredients.length - 1);
    this.arringredients.forEach(p => {
      this.str += p + "-";
    });
    return this.str.substring(0, this.str.length - 1);
  }

  getPreparation() {
    this.str = "";
    this.arrPreparation.splice(this.arrPreparation.length - 1);
    this.arrPreparation.forEach(p => {
      this.str += p + "-";
    });
    return this.str.substring(0, this.str.length - 1);
  }

  getLevelDiffulty() {
    if (this.arrPreparation.length < 10) 
      return 1;
      if (this.arrPreparation.length < 20) 
        return 2;
        if (this.arrPreparation.length > 20)
          return 3;
      
    }

  }
