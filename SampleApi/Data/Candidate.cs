using System.Collections.Generic;

namespace SampleApi.Data
{
    public class Candidate
    {

        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; }
        public int  CandidateId { get; set; }
        public Candidate()
        { }
        public Candidate(string firstName, string lastName, int candidateId, string email)
        {   
            FirstName = firstName;
            LastName = lastName;
            CandidateId = candidateId;
            Email = email; 
        }
        
         
    }
}
