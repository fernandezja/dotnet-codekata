using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{

    [Table("Movie")]
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

    }
}