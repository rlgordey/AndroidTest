using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class User
    {
        public int UserIntId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? PasswordExpiration { get; set; }
        public byte? ForcePwChange { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string EmailAddress { get; set; }
        public string Ssn { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? AdjHireDate { get; set; }
        public DateTime? LastDayWorked { get; set; }
        public DateTime? DateInactivated { get; set; }
        public string Reason { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string Phone1ext { get; set; }
        public string Phone2 { get; set; }
        public string Phone2ext { get; set; }
        public string Phone3 { get; set; }
        public string Phone3ext { get; set; }
        public byte? Inactive { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public string Supervisor { get; set; }
        public string Emplyid { get; set; }
        public bool? Login { get; set; }
        public string NotificationNumber { get; set; }
    }
}
