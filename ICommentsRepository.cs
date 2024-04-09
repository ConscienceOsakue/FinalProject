using FinalProject.Models;

namespace FinalProject
{
    public interface ICommentsRepository
    {
        //For mu comments table in my DB
        public IEnumerable<Comments> GetAllChronicleEBComments();
        public IEnumerable<Comments> GetChronicleEBComments();
        public Comments GetChronicleEBComments(int id);
        public Comments AssignUsername();
        public void InsertChronicleEBComments(Comments chronicleebcommentsToInsert);
        public void UpdateChronicleEBComments(Comments chronicleebcomments);
        public void DeleteChronicleEBComments(Comments chronicleebcomments);
    }
}
