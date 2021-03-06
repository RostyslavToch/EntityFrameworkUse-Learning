﻿using System;
using System.Collections.Generic;

namespace EntityFrameworkCoreDatabaseFirst.Models
{
    public partial class Footballer : IIdentity
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Team Team { get; set; }

        public override string ToString() => $"FirstName: {FirstName}, " +
            $"LastName: {LastName}, Id: {Id}, TeamId: {TeamId}";
    }
}
