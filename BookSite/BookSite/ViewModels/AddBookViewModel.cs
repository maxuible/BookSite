using System.ComponentModel.DataAnnotations;

namespace BookSite.ViewModels
{
    public class AddBookViewModel
    {

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Isbn is required")]
        public string Isbn { get; set; }

        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Url is required")]
        public string Url { get; set; }



    }
}
