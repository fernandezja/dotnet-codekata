using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Entities
{
    [Table("Mail")]
    public class Mail
    {
        public int MailId { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
    }
}