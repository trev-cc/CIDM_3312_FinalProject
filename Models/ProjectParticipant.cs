using System;

namespace BuffteksWebsite
{
    public class ProjectParticipant
    {
        /*
        public int ProjectParticipantID { get; set; }
        public int ClientID {get; set;}
        public int MemberID {get; set;}
 `      */
        public string ParticipantID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString(){
            return $"First Name: {this.FirstName} Last Name: {this.LastName}";
        }
    }
}