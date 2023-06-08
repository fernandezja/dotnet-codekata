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

        public List<Mail> Search(MailFilter filter) {

            //TODO: Validar textToSearch, pageIndex
            if (filter is null)
            {
                throw new ArgumentException("Filter invalid");
            }

            //TODO: Paginar

            return _mailRepository.Search(filter.TextToSearch, 
                                          filter.PageSize,
                                          filter.PageIndex); 
        }
    }
}