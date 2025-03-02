namespace EventEase.Shared.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Event
    {
        [Required(ErrorMessage = "Event name is required.")]
        [StringLength(100, ErrorMessage = "Event name cannot exceed 100 characters.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters.")]
        public required string Location { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public required string Description { get; set; }
        // Add other properties as needed (e.g., ImageUrl, Price)
    }
}