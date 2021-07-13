using System.ComponentModel.DataAnnotations;

namespace Kestra_coding_test.Models
{
    public class FormDropdownOptions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string SelectorValue { get; set; }

        public FormDropdownOptions()
        {
        }
    }
}
