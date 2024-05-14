using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Models
{
    public class Movie
    {
        [Required]
        public Guid Id { get; init; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int YearOfRelease { get; set; }
        [Required]
        public List<string> Genres { get; init; } = new();
    }
}
