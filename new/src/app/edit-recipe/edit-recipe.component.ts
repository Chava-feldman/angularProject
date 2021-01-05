import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/modals/Category';
import { Recipe } from 'src/modals/Recipe';
import { CategoryService } from '../category.service';
import { RecipeServiceService } from '../recipe-service.service';

@Component({
  selector: 'app-edit-recipe',
  templateUrl: './edit-recipe.component.html',
  styleUrls: ['./edit-recipe.component.css']
})
export class EditRecipeComponent implements OnInit {
  allCategories: Category[] = [];

  code:number;
  constructor(public categorySer: CategoryService, public RecipeSer:RecipeServiceService, public active:ActivatedRoute) {
    
    active.params.subscribe(param=>{
      console.log(param);
      this.code=parseInt(param["code"]);
    },err=>{})
    console.log(this.code);
    this.categorySer.getAllCategories().subscribe(p =>{ this.allCategories = p;console.log(this.allCategories);}, err => console.log("cant got categories"));
    this.RecipeSer.getRecipeByCode(this.code).subscribe(p=>{this.myEditRecipe=p;this.arringredients=this.myEditRecipe.ingredients.split('-');}, err=>console.log(err+"             sharattttt"));
    
    
   
   }
   arringredients:string[]=[];
   myEditRecipe:Recipe;

  

  getCategoryByCode(){
  this.allCategories.forEach(p=>
    {
      console.log(p);
      if (p.code==this.myEditRecipe.codeCategory)
      return p.name;
    })
  }
  
  trackByFn(index, item) {
    return index;
  }

  addIndexArringredients(str: string) {
    if (this.arringredients[this.arringredients.length - 1] != "")
      this.arringredients.push("");
  }
  checkIfEmptyIngredient(e, i) {
    if (e.target.value == "") {

      this.arringredients.splice(i, i);

    }

  }

  ngOnInit(): void {
  }
}
