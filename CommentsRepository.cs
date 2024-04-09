using FinalProject.Models;
using System.Data;
using Dapper;
using Org.BouncyCastle.Crypto.Prng.Drbg;
using System.Collections.Generic;

namespace FinalProject
{
    public class CommentsRepository : ICommentsRepository
    {
        private readonly IDbConnection _conn;

        public CommentsRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Comments> GetAllChronicleEBComments()
        {
            throw new NotImplementedException();
        }

        public Comments GetChronicleEBComments(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteChronicleEBComments(Comments chronicleebcomments)
        {
            throw new NotImplementedException();
        }

        public void InsertChronicleEBComments(Comments chronicleebcommentsToInsert)
        {
            throw new NotImplementedException();
        }

        public void UpdateChronicleEBComments(Comments chronicleebcomments)
        {
            throw new NotImplementedException();
        }

        public void AssignChronicleEBComments(int postid, IEnumerable<Comments> comments)
        {
            foreach (var comment in comments)
            {
                // Assign postId to each comment
                comment.PostId = postid;

                // Save the comment to the database (assuming you have a method to do this)
                InsertChronicleEBComments(comment);
            }
        }

        public IEnumerable<Comments> GetChronicleEBComments()
        {
            throw new NotImplementedException();
        }

        public Comments AssignUsername()
        {
            throw new NotImplementedException();
        }
    }

}
