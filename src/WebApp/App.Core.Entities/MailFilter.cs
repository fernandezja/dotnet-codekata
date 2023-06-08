using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Entities
{
    
    public class MailFilter
    {
        public string TextToSearch { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public bool IsValid { 
            get {

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