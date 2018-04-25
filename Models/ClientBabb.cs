using System;

namespace BuffteksWebsite.Models
{
    public class ClientBabb : ProjectParticipant
    {
        public string CompanyName { get; set; }

        public override string ToString(){
            return $"Client First Name: {this.FirstName} Client Last Name: {this.LastName}";
        }
    }
}