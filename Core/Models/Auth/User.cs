using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core.Models.Auth
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string NID { get; set; }
        public DateTime? NIDVerifiedDate { get; set; }
        public Guid? NIDVerifiedBy { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public int GendersId { get; set; }
        public int DistrictsId { get; set; }
        public int? StoresId { get; set; }
        public string Image { get; set; }
    }
}
