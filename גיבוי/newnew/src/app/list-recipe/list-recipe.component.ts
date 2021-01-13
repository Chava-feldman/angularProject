import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Recipe } from 'src/modals/Recipe';
import { RecipeServiceService } from '../recipe-service.service';

@Component({
  selector: 'app-list-recipe',
  templateUrl: './list-recipe.component.html',
  styleUrls: ['./list-recipe.component.css']
})
export class ListRecipeComponent {

  arreyRecipes: Array<Recipe>;


  changeClickedRecipe(item:Recipe){
    this.RecipeSer.clickedRecipe=item;
    this.router.navigate(['fullrecipe',item.codeRecipe]);

  }

 

  constructor(public RecipeSer: RecipeServiceService,public router:Router) { 
    this.RecipeSer.getsRecipes().subscribe(p=> this.arreyRecipes=p,err=> console.log(err));

    
  }
}
