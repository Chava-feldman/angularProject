using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication3.Models;



namespace WebApplication3.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "*")]
  [RoutePrefix("api/Category")]
  public class CategoryController : ApiController
  {
        public object txtMessage { get; private set; }

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


    //    [Route("sendEmail")]
    //    [HttpPost]
    //    public static void sendEmail(Email email)
    //{
            
    //    try
    //    {
    //        MailMessage mail = new MailMessage();
    //        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

    //        mail.From = new MailAddress("2meatrestaurant@gmail.com");
    //        mail.To.Add(email.email);
    //        mail.Subject = email.Subject;
    //        mail.IsBodyHtml = true;
    //        mail.Body = "<br />" + "<b>" + email.Body + "</b>"
    //        + "<img src=@'C:\\Users\\user-pc\\Documents\\GitHub\\finalPoject\\server\\WEB_API\\BL\\title.png'/>";

    //        SmtpServer.Port = 587;
    //        SmtpServer.Credentials = new System.Net.NetworkCredential("2meatrestaurant@gmail.com", "prcn8531");
    //        SmtpServer.EnableSsl = true;

    //        SmtpServer.Send(mail);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw (ex);
    //    }
    //}


        //[HttpGet]
        //[Route("sendEmailCommit")]
        //public IHttpActionResult SendEmailCommit( string email)
        //{
        //    try
        //    {
        //        ////פרטים שאת רוצה...
        //        var fromAddress = new MailAddress("ch159503@gmail.com", "Name");
        //        var toAddress = new MailAddress(email, "To User");
        //        const string fromPassword = "c0533159503";
        //        const string subject = "MyProject - הרשמה";
        //        const string body = "ההרשמה למערכת נקלטה בהצלחה! כעת הכניסה לאיזור האישי תתאפשר אוטומטית באמצעות ת.ז וסיסמא";
        //        ////
        //        var smtp = new SmtpClient
        //        {
        //            Host = "smtp.gmail.com",
        //            Port = 587,
        //            EnableSsl = true,
        //            DeliveryMethod = SmtpDeliveryMethod.Network,
        //            UseDefaultCredentials = false,
        //            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        //        };
        //        using (var message = new MailMessage(fromAddress, toAddress)
        //        {
        //            Subject = subject,
        //            Body = body
        //        })
        //        {
        //            smtp.Send(message);
        //        }
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest();
        //    }
        //}

        //public static void SendMail(string subjecct, string body, string Address, string from = null, string PathToFile = null)
        //{
        //    MailMessage msg = new MailMessage() { From = new MailAddress("abc@gmail.com", "abc") };
        //    if (from != null)
        //    {
        //        msg.ReplyToList.Add(from);
        //    }
        //    msg.To.Add(Address);
        //    msg.Subject = subjecct;
        //    msg.Body = body;
        //    msg.IsBodyHtml = true;

        //    //msg.Priority = MailPriority.High;
        //    if (PathToFile != null)
        //    {
        //        try
        //        {
        //            Attachment attach;
        //            attach = new Attachment(PathToFile, "application/pdf");
        //            msg.Attachments.Add(attach);
        //        }
        //        catch (Exception e)
        //        {

        //            throw e;
        //        }

        //    }
        //    try
        //    {
        //        using (SmtpClient client = new SmtpClient())
        //        {
        //            client.EnableSsl = true;
        //            client.UseDefaultCredentials = false;
        //            client.Credentials = new NetworkCredential("abc@gmail.com", "123456");
        //            client.Host = "smtp.gmail.com";
        //            client.Port = 587;
        //            client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //            client.Send(msg);
        //        }
        //        if (PathToFile != null)
        //        {
        //            msg.Attachments.Dispose();

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;

        //    }
        //}


        
        [Route("myTry")]
        [HttpGet]
        public bool myTry(string sub, string body)
        {


            //יצירת אוביקט MailMessage
            MailMessage mail = new MailMessage();

            //למי לשלוח (יש אפשרות להוסיף כמה נמענים) 
            mail.To.Add("8667572@gmail.com");

            //כתובת מייל לשלוח ממנה
            mail.From = new MailAddress("contact.from.recipe.project@gmail.com");

            // נושא ההודעה
            mail.Subject = sub;

            //תוכן ההודעה ב- HTML
            mail.Body = body;

            //הגדרת תוכן ההודעה ל - HTML 
            mail.IsBodyHtml = true;

            // Smtp יצירת אוביקט 
            SmtpClient smtp = new SmtpClient();

            //הגדרת השרת של גוגל
            smtp.Host = "smtp.gmail.com";


            //הגדרת פרטי הכניסה לחשבון גימייל
            smtp.Credentials = new NetworkCredential(
                "contact.from.recipe.project@gmail.com", "recipe123456");
            //אפשור SSL (חובה(
            smtp.EnableSsl = true;
            try
            {
                //שליחת ההודעה
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                //תפיסה וטיפול בשגיאות 
                txtMessage = ex.ToString();
                
                return false;
                
            }
            
        }











    }
}
