using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using static FinalProject.Models.Calculator;

namespace FinalProject.Controllers
{
    //Creating a controller that handles the user requests and response for the AHA calculation
    
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculatorUser()
        {
            return View();
        }


        //using this to view the page of the AH Calculator
        [Authorize]
        public IActionResult CalculatorScores(Calculator ahanalyzeruserpartner, CalculatorUser userself)
        {

            // Calculating scores based on ratings and gender

            

            double ahanalyzeruserpartnerScore = AHAnalyzerUserPartnerScores(ahanalyzeruserpartner);

            double userselfScore = UserSelfScores(userself);
            double userSumPatnerSelf = AHAnalyzerUserPartnerScores(ahanalyzeruserpartner) + UserSelfScores(userself);



            //ensuring the female score is not more than the male by checking for true.
            if ((ahanalyzeruserpartner.Gender == Gender.Female && ahanalyzeruserpartnerScore >= 25) || ahanalyzeruserpartnerScore == userselfScore)  
            {

                // Calculate average score
                double userAverageScore = Math.Round(userSumPatnerSelf / 140 * 100);

                // Pass average score to the view
                ViewData["UserAverageScore"] = userAverageScore;

                return View("CalculatorScores");

            }
            if ((ahanalyzeruserpartner.Gender == Gender.Male && ahanalyzeruserpartnerScore >= 15) || ahanalyzeruserpartnerScore == userselfScore)
            {
                double userAverageScore = Math.Round(userSumPatnerSelf / 140 * 100);

                // Pass average score to the view
                ViewData["UserAverageScore"] = userAverageScore;

                return View("CalculatorScores");
            }
            else { return View("CalculatorError"); }
           
        }
       

        private double AHAnalyzerUserPartnerScores(Calculator ahanalyzeruserpartner)
        {
                // Calculating the user patner score Affinity Harmony score based on ratings response
                return (ahanalyzeruserpartner.UserPartnerRatingPatient + ahanalyzeruserpartner.UserPartnerRatingKind
                    + ahanalyzeruserpartner.UserPartnerRatingLove + ahanalyzeruserpartner.UserPartnerRatingHumble
                    + ahanalyzeruserpartner.UserPartnerRatingRespectful + ahanalyzeruserpartner.UserPartnerRatingGiving
                    + ahanalyzeruserpartner.UserPartnerRatingHonest);
        }

            private double UserSelfScores(CalculatorUser userself)
            {
                // Calculating the user self score Affinity Harmony score based on their ratings response
                return (userself.UserSelfRatingPatient + userself.UserSelfRatingKind
                    + userself.UserSelfRatingLove + userself.UserSelfRatingHumble
                    + userself.UserSelfRatingRespectful + userself.UserSelfRatingGiving
                    + userself.UserSelfRatingHonest);
            }

        
    }     
}