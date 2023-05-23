using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{

    [Table("Actor")]
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }

    }
}