using System.ComponentModel.DataAnnotations;

namespace BookManagement.Data
{
    public class Book
    {
        [Required]
        [Key]
        public int id { get; set; }

        public string? title { get; set; }   


        public string? author { get; set; }

        public DateTime? publishDate { get; set; }

    }
}
