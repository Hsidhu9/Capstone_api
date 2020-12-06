﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shift_Picker_Api.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public ICollection<UserModel> Users { get; set; }
    }
}
