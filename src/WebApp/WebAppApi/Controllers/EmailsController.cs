using App.Core.Business;
using App.Core.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private MailBusiness _mailBusiness;

        public EmailsController()
        {
            _mailBusiness = new MailBusiness();
        }

        [EnableCors]
        [HttpGet]
        public IActionResult Get() { 
            
            var emails = new List<App.Core.Entities.Mail>();
            
            emails.Add(new App.Core.Entities.Mail() {
                MailId = 1,
                Asunto = "Demo"
            });


            return Ok(emails);
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


        [EnableCors]
        [HttpPost("search")]
        public IActionResult Search([FromBody]MailFilter filter)
        {
            
            if (filter is null 
                || !filter.IsValid) {
                return BadRequest();            
            }


            ///Request.Form[]

            var mails = _mailBusiness.Search(filter);

            //Response.StatusCode = 200;
            //Response.Body

            return Ok(mails);
        }


        [EnableCors]
        [HttpGet("search2")]
        public IActionResult Search2([FromQuery] MailFilter filter)
        {

            if (filter is null
                || !filter.IsValid)
            {
                return BadRequest();
            }


            ///Request.Form[]

            var mails = _mailBusiness.Search(filter);

            return Ok(mails);
        }
    }
}
