using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication3.Models
{
    public class DB
    {
        public static List<User> userList { get; set; }
        public static List<Category> categoryList { get; set; }
        public static List<Recipe> recipeList { get; set; }
        static DB()
        {
            userList = new List<User>() {
            new User() { code = 12, name = "yaeli", address = "geula", mail = "12@gmail.com", password = "12" },
            new User() { code = 34, name = "rivka", address = "geula", mail = "34@gmail.com", password = "34" },
            new User() { code = 56, name = "yaeli", address = "geula", mail = "56@gmail.com", password = "56" },
            new User() { code = 78, name = "yaeli", address = "geula", mail = "78@gmail.com", password = "78" }
        };
            categoryList = new List<Category>()
            {
            new Category() { name = "cake",code = 11,routing = "C:/Users/Sara/Desktop/angular/projectall/projct3/src/assets.1"},
            new Category() { name = "dessert",code = 22,routing = "C:/Users/Sara/Desktop/angular/projectall/projct3/src/assets.2"},
            new Category() { name = "FruitDesigns",code = 33 ,routing = "C:/Users/Sara/Desktop/angular/projectall/projct3/src/assets.3"},
        };

            recipeList = new List<Recipe>()
            {
                new Recipe (){codeRecipe=0,nameRecipe="עוגת גבינה",codeCategory=11,timeAtMinute=15,LevelDifficulty=1,addRecipe=DateTime.Now,ingredients="-שוקולד -גבינה -קמח -סוכר -אבקת אפיה",Preparation="-הוראות -הכנה לעוגה",userCode=12,image="https://www.10dakot.co.il/wp-content/uploads/2019/07/DSC_0041-%D7%A2%D7%95%D7%AA%D7%A7-800x532-2-785x522.jpg",isShow=true},
            new Recipe() { codeRecipe = 0, nameRecipe = "עוגת שוקלד", codeCategory = 22, timeAtMinute = 15, LevelDifficulty = 2, addRecipe = DateTime.Now, ingredients = "שוקולד גבינה קמח סוכר אבקת אפיה", Preparation = "הוראות הכנה לעוגה", userCode = 34, image = "https://www.10dakot.co.il/wp-content/uploads/2019/07/DSC_0041-%D7%A2%D7%95%D7%AA%D7%A7-800x532-2-785x522.jpg", isShow = true },
            new Recipe() { codeRecipe = 0, nameRecipe = "עוגיות חמאה", codeCategory =33, timeAtMinute = 15, LevelDifficulty = 4, addRecipe = DateTime.Now, ingredients = "שוקולד גבינה קמח סוכר אבקת אפיה", Preparation = "הוראות הכנה לעוגה", userCode = 56, image = "https://www.10dakot.co.il/wp-content/uploads/2019/07/DSC_0041-%D7%A2%D7%95%D7%AA%D7%A7-800x532-2-785x522.jpg", isShow = true },

        };


        }



        // = new List<Recipe>() {
        //    new Recipe(){codeRecipe="14",codeCategory="cake",nameRecipe="שמנת",addRecipe=DateTime.Now,LevelDifficulty=1,timeAtMinute=10,userCode="12",isShow=true,image="", ingredients={ "2 ביצים M","חצי כוס (100 ג') סוכר" ,"חצי כפית גרידת קליפת לימון","חצי כוס שמן","מיכל שמנת חמוצה" },
        //        Preparation = {"-מחממים תנור ל-180 מעלות ומשמנים תבנית אינגליש קייק.","מערבבים את כל החומרים בעזרת מטרפה ידנית או מיקסר לפי הסדר שהם רשומים, עד לקבלת תערובת אחידה."} },
        //    new Recipe(){codeRecipe="14",codeCategory="cake",nameRecipe="שמנת",addRecipe=DateTime.Now,LevelDifficulty=1,timeAtMinute=10,userCode="12",isShow=true,image="", ingredients={ "2 ביצים M","חצי כוס (100 ג') סוכר" ,"חצי כפית גרידת קליפת לימון","חצי כוס שמן","מיכל שמנת חמוצה" },
        //        Preparation = {"-מחממים תנור ל-180 מעלות ומשמנים תבנית אינגליש קייק.","מערבבים את כל החומרים בעזרת מטרפה ידנית או מיקסר לפי הסדר שהם רשומים, עד לקבלת תערובת אחידה."} },
        //    new Recipe(){codeRecipe="14",codeCategory="cake",nameRecipe="שמנת",addRecipe=DateTime.Now,LevelDifficulty=1,timeAtMinute=10,userCode="12",isShow=true,image="", ingredients={ "2 ביצים M","חצי כוס (100 ג') סוכר" ,"חצי כפית גרידת קליפת לימון","חצי כוס שמן","מיכל שמנת חמוצה" },
        //        Preparation = {"-מחממים תנור ל-180 מעלות ומשמנים תבנית אינגליש קייק.","מערבבים את כל החומרים בעזרת מטרפה ידנית או מיקסר לפי הסדר שהם רשומים, עד לקבלת תערובת אחידה."} },
        //};



    }
}
