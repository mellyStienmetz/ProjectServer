﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string HMO { get; set; }
        public List<Child> children { get; set; }
    }
}