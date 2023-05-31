using System.ComponentModel.DataAnnotations;

namespace boilerplate_aspnet.Models
{
    public class Role
    {
        [Key]
        [Required]
        public Guid id { get; set; }

        [Required]
        public string name { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
