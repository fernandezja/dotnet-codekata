using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entities
{
    public class BusquedaGenerica<T>
    {
        public int Total { get; set; }
        public List<T> Items { get; set; }
        public string TextToSearch { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string MensajeResultado
        {
            get { return "texto a responder"; }
        }

        public bool IsValid
        {
            get
            {

                if (PageSize <= 0)
                {
                    return false;
                }

                if (PageIndex <= 0)
                {
                    return false;
                }

                return true;

            }
        }
    }
}
