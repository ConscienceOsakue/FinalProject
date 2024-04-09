namespace FinalProject.Models
{
    public class Comments
    {
        // creating the model for the blog commets 
        public int CommentId { get; set; }
        public required string CommentUsername { get; set; }
        public int PostId { get; set; }
        public required string Comment { get; set; }
        public DateTime CommentCreatedDate { get; set; }
    }
}
