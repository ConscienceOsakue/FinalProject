using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


//Models are typically responsible for retrieving and storing data
//from and to a data store, such as a database
namespace FinalProject.Models
    {
        public class Blog
        {
        // // Creating model for the blog content and will add any other properties as needed  
            public int PostId { get; set; }

            [Required]
            public required string PostTitle { get; set; }
            [Required]
            public required string PostContent { get; set; }
            public required string PostAuthor { get; set; }
    }
}



