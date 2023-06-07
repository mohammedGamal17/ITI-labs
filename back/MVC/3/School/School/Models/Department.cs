using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 20, MinimumLength = 2)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
