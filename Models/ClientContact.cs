using System;

namespace BuffteksWebsite.Models
{
    public class ClientContact
    {
        public int ClientID{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Title{ get; set; }
        public string Email{ get; set; }
        public string Phone{ get; set; }
    }
}