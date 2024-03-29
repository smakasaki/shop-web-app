﻿namespace ShopWebApp.Models.DTO
{
    public class ProfileDTO
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;
    }
}
