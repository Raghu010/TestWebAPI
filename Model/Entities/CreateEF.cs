using System.ComponentModel.DataAnnotations;

namespace SdaemonAPIProject.Model.Entities
{
    public class CreateEF
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage="Title can not exceed 50 characters")]
        public string Title { get; set; }
        [Display(Name = "Description Given")]
        public string? Description { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public bool IsComplete { get; set; }
    }
}
