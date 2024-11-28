﻿using System;
using System.Collections.Generic;

namespace ASI.Basecode.Data.Models
{
    public partial class MUser
    {
        public int UserId { get; set; }
        public string InsBy { get; set; }
        public DateTime InsDt { get; set; }
        public string UpdBy { get; set; }
        public DateTime UpdDt { get; set; }
        public bool Deleted { get; set; }
        public string UserCode { get; set; }
        public string Password { get; set; }
        public string TemporaryPassword { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string LastNameKana { get; set; }
        public string FirstNameKana { get; set; }
        public string Mail { get; set; }
        public int? UserRole { get; set; }
        public string Remarks { get; set; }
    }
}
