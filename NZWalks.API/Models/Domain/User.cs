﻿namespace NZWalks.API.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation property
        public List<User_Role> UserRoles { get; set; } = new List<User_Role>();
    }
}
