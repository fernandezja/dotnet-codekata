using App.Core.Data;
using App.Core.Entities;

namespace App.Core.Business
{
    public class MailBusiness
    {
        public MailRepository _mailRepository { get; set; }

        public MailBusiness()
        {
            _mailRepository = new MailRepository(); //TODO: DI Inyectar 
        }

        public List<Mail> Search(string textToSearch) {

            //TODO: Validar textToSearch
            //TODO: Paginar


            return _mailRepository.Search(textToSearch); ;
        }
    }
}