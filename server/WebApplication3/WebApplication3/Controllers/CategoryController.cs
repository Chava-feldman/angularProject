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
  [RoutePrefix("api/Category")]
  public class CategoryController : ApiController
  {
    [Route("getRecipeByCode")]
    [HttpGet]

    public Category getRecipeByCode(int code)
    {
      foreach (var item in DB.categoryList)
      {
        if (item.code == code)
          return item;
      }
      return null;
      
    }
    [Route("getAllCategories")]
    [HttpGet]
    public List<Category> getAllCategories()
    {
      return DB.categoryList;
    }


  }
}
