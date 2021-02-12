using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DirectoryForm
{
    [Table("tblGirls")]
    public class Girl
    {
        [Key]
        public int Id { get; set; }
        private string _name;
        private int _age;
        private int _weight;

        [Required, StringLength(30)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [Required, StringLength(3)]
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
                else
                {
                    _age = 0;
                    throw new Exception("Вік не можу бути меншим 0");
                    //Console.WriteLine("Вік не можу бути меншим 0");
                }
            }
        }
        [Required, StringLength(3)]
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

    }
}
