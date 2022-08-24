using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class CompetitorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string BeltColor { get; set; }

        public int TournamentId { get; set; }


        public CompetitorModel()
        {
        }

        public CompetitorModel(string firstName, string lastName, string email, DateTime dateOfBirth, string beltColor, int tournamentId)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            BeltColor = beltColor;
            TournamentId = tournamentId;
        }
    }

    
    
}
