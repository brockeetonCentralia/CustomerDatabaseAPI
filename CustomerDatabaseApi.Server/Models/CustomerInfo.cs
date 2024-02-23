﻿using System.ComponentModel.DataAnnotations;

namespace CustomerDatabaseApi.Server.Models
{
    public class CustomerInfo
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }
}
