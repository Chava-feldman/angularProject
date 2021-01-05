using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "*")]
  [RoutePrefix("api/Recipe")]


  public class RecipeController : ApiController
  {
    [Route("getsRecipes")]
    [HttpGet]
    public List<Recipe> getsRecipes()
    {
      return DB.recipeList;
    }

    [Route("AddRecipe")]
    [HttpPost]

    public bool AddRecipe(Recipe r)
    {
      DB.recipeList.Add(new Recipe(){ codeRecipe=0,nameRecipe=r.nameRecipe,codeCategory=r.codeCategory,
        timeAtMinute=r.timeAtMinute,LevelDifficulty=r.LevelDifficulty,addRecipe=r.addRecipe,ingredients=r.ingredients,
        Preparation=r.Preparation,userCode=r.userCode,image=r.image,isShow=r.isShow});
      return true;
      }
    [Route("RecipeByCode")]
    [HttpGet]
    public Recipe RecipeByCode(int code)
    {
      foreach(var item in DB.recipeList)
      {
        if (item.codeRecipe==code)
          return item;
        
      }
      return null;
    }
  }
  

  



}
