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

        public List<Mail> Search(string textToSearch, 
                                int pageSize,
                                int pageIndex) {

            //TODO: Validar textToSearch, pageIndex
            //TODO: Paginar

            return _mailRepository.Search(textToSearch, 
                                          pageSize, 
                                          pageIndex); 
        }
    }
}