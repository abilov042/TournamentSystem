﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    [Table("users")]
    public class User : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }
    }
}
