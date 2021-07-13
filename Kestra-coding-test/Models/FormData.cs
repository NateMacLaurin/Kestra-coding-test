using System.ComponentModel.DataAnnotations;

namespace Kestra_coding_test.Models
{
    public class FormData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [Required]
        public string Location { get; set; }

        public FormData()
        {

        }
    }
}
