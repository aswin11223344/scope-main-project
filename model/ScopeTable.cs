﻿using System.ComponentModel.DataAnnotations;

namespace project_ScopeIndia.model
{
    public class ScopeTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        
        public int Age { get; set; }

        
        public string Country { get; set; }

     
        public string State { get; set; }

 
        public string City { get; set; }

        public string PhoneNumber { get; set; }

     
        public string Email { get; set; }

     
        public string Gender { get; set; }
        public string Hobbies { get; set; }

    }
}