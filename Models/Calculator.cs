using System.Collections.Generic;

namespace FinalProject.Models
{

    //Models are typically responsible for retrieving and storing data
    //from and to a data store, such as a database

    public enum Gender
    {
        Male,
        Female
    }
    public class Calculator
    {
        
            /*Creating class in model to defind each user based on their gender.
            which will help me calculate the Affinity Harmony Analyzer score well as women love should
            be equal a bit lower than men but not higher or very lower in a relationship.*/
            public Gender Gender { get; set; }
            public double UserPartnerRatingPatient { get; set; }
            public double UserPartnerRatingKind { get; set; }
            public double UserPartnerRatingLove { get; set; }
            public double UserPartnerRatingHumble { get; set; }
            public double UserPartnerRatingRespectful { get; set; }
            public double UserPartnerRatingGiving { get; set; }
            public double UserPartnerRatingHonest { get; set; }

    }
}
