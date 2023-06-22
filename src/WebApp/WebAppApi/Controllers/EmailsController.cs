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

        public EmailsController(MailBusiness mailBusiness)
        {
            _mailBusiness = mailBusiness;
        }


        [EnableCors]
        [HttpGet]
        [HttpGet("listado-completo")]
        public IActionResult Get() { 
            
            var emails = new List<App.Core.Entities.Mail>();

            for (int i = 1; i <= 100; i++)
            {
                emails.Add(new App.Core.Entities.Mail()
                {
                    MailId = i,
                    Asunto = $"Mail demo #{i}"
                });
            }
           


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
        public IActionResult Search([FromBody] BusquedaGenerica<Mail> mailBusqueda)
        {
            
            if (mailBusqueda is null 
                || !mailBusqueda.IsValid) {
                return BadRequest();            
            }


            ///Request.Form[]

            var respuesta = _mailBusiness.Search(mailBusqueda);

            //Response.StatusCode = 200;
            //Response.Body

            return Ok(respuesta);
        }


        [EnableCors]
        [HttpGet("search2")]
        public IActionResult Search2([FromQuery] BusquedaGenerica<Mail> mailBusqueda)
        {

            if (mailBusqueda is null
                || !mailBusqueda.IsValid)
            {
                return BadRequest();
            }


            ///Request.Form[]

            var respuesta = _mailBusiness.Search(mailBusqueda);

            return Ok(respuesta);
        }
    }
}
