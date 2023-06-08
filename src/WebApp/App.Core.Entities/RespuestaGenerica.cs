using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entities
{
    public class RespuestaGenerica<T>
    {
        public int Total { get; set; }
        public List<T> Items { get; set; }
    
        public string MensajeResultado
        {
            get { return "texto a responder"; }
        }

        public RespuestaGenerica()
        {
                
        }
    }
}
