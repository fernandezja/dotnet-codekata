using App.Core.Business;
using App.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc.Controllers
{
    public class MailController: Controller 
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalle(int? id)
        {

            if (!id.HasValue 
                || id.Value <= 0)
            {
                return NotFound();
            }


            var mail = new Mail()
            {
                MailId = id.Value,
                Asunto = $"Asunto demo {id}",
                Contenido = $"Contenido demo {id}"
            };

            return View(mail);
        }


        public IActionResult Inbox()
        {

            var mails = (new MailBusiness()).Search("data_source");

            return View(mails);
        }
    }
}
