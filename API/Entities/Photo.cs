using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        // EF relationship properties. with these the appuuserID column will not be nullable
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}