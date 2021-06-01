﻿using System;

namespace MmtDigital.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string Email { get; set; }
        public bool Website { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastLoggedIn { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string PreferredLanguage { get; set; }
    }
}
