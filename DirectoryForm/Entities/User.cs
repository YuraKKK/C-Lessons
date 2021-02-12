using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DirectoryForm.Entities
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int  Id { get; set; }
        [Required, StringLength(30)]
        public string LastName { get; set; }
        [Required, StringLength(30)]
        public string FirstName { get; set; }
    }
}
