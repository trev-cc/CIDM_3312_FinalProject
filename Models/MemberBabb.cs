using System;

namespace BuffteksWebsite.Models
{
    public class MemberBabb : ProjectParticipant
    {
        public string Major { get; set; }

        public override string ToString(){
            return $"Member First Name: {this.FirstName} Member Last Name: {this.LastName}";
        }
    }
}