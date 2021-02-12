using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookForm
{
    [Table("tblPeople")]
    public class People
    {
        [Key]
        public int Id { get; set; }
        private string _name;
        private string _surname;
        private string _phoneNumber;

        [Required, StringLength(100)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [Required, StringLength(100)]
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        [Required, StringLength(10)]
        public string PhoneNumber
        {
            get { return _phoneNumber;; }
            set { _phoneNumber = value; }
        }
    }
}
