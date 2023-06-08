using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entities
{
    /// <summary>
    /// Generic Filter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BusquedaGenerica<T>
    {
       
        public string TextToSearch { get; set; }

        [DefaultValue(10)]
        public int PageSize { get; set; }

        [DefaultValue(1)]
        public int PageIndex { get; set; }
       
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

        public BusquedaGenerica()
        {
            PageIndex = 1;
            PageSize = 10;
        }
    }
}
