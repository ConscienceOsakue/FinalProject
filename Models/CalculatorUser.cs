namespace FinalProject.Models
{
    public class CalculatorUser
    {
        /*Creating class in model to defind each user based on their gender.
           which will help me calculate the Affinity Harmony Analyzer score well as men love should
           be high than female or same but not lower in a relationship.*/
        public double UserSelfRatingPatient { get; set; }
        public double UserSelfRatingKind { get; set; }
        public double UserSelfRatingLove { get; set; }
        public double UserSelfRatingHumble { get; set; }
        public double UserSelfRatingRespectful { get; set; }
        public double UserSelfRatingGiving { get; set; }
        public double UserSelfRatingHonest { get; set; }
    }
}
