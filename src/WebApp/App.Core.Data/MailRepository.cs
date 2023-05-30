using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Data
{
    public class MailRepository
    {
        public MailRepository()
        {
                
        }

        public List<Mail> Search(string textToSearch)
        {

            using (var context = new MailsContext())
            {
                var query = from m in context.Mails
                            where m.Asunto.Contains(textToSearch)
                            select m;

                return query.ToList();
            }

        }
    }
}
