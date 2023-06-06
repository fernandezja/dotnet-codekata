using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {

        public EmailsController()
        {

        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<App.Core.Entities.Mail> Get() { 
            
            var emails = new List<App.Core.Entities.Mail>();
            
            emails.Add(new App.Core.Entities.Mail() {
                MailId = 1,
                Asunto = "Demo"
            });

            return emails;
        }


        [HttpGet("{emailId:int}")]
        public App.Core.Entities.Mail GetMail(int emailId)
        {
            if (emailId<=0)
            {
                BadRequest("Debe enviar un identificador valido");
            }

            var email1 = new App.Core.Entities.Mail()
            {
                MailId = emailId,
                Asunto = $"Demo {emailId}"
            };

            return email1;
        }


        [HttpGet("{emailId:int}/personalizado")]
        public App.Core.Entities.Mail GetMail2(int emailId)
        {
            if (emailId <= 0)
            {
                BadRequest("Debe enviar un identificador valido");
            }

            var email1 = new App.Core.Entities.Mail()
            {
                MailId = emailId,
                Asunto = $"Demo {emailId}"
            };

            return email1;
        }




        [HttpPost]
        public IActionResult Post(App.Core.Entities.Mail mail)
        {
            //_emailBusinness.IsValid(mail);


            if (mail is null)
            {
                return BadRequest();
            }

            var demoAsunto = mail.Asunto;

            return new OkResult();
        }
    }
}
