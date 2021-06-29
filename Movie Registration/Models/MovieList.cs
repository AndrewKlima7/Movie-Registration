using System;
using System.Collections.Generic;

#nullable disable

namespace Movie_Registration.Models
{
    public partial class MovieList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int? Year { get; set; }
        public int? Runtime { get; set; }
    }
}
