using System.ComponentModel.DataAnnotations;

namespace SdaemonAPIProject.Model
{
    public class UpdateDto
    {
        public string Title { get; set; }
        [Display(Name = "Description Given")]
        public string? Description { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public bool IsComplete { get; set; }
    }
}
