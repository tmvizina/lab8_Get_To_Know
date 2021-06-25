using System;
using System.Collections.Generic;

#nullable disable

namespace Lab8_Get_To_Know.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hometown { get; set; }
        public string Homestate { get; set; }
        public string FavoriteFood { get; set; }
    }
}
