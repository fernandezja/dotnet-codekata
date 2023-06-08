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


        public BusquedaGenerica<Mail> Search(BusquedaGenerica<Mail> mailBusqueda)
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