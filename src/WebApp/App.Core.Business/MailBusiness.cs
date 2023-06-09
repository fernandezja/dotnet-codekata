using App.Core.Data;
using App.Core.Entities;

namespace App.Core.Business
{
    public class MailBusiness
    {
        private MailRepository _mailRepository;
        private ContactRepository _contactRepository;


        public MailBusiness(MailRepository mailRepository,
                            ContactRepository contactRepository)
        {
            _mailRepository = mailRepository;
            _contactRepository = contactRepository;
        }


        public RespuestaGenerica<Mail> Search(BusquedaGenerica<Mail> mailBusqueda)
        {
            //TODO: Validar textToSearch, pageIndex
            if (mailBusqueda is null)
            {
                throw new ArgumentException("Filter invalid");
            }

            //TODO: Paginar

            return _mailRepository.Search(mailBusqueda);
        }

    }
}