using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Contract.Responses
{
    public class MovieResponse
    {

        [Required]
        public Guid Id { get; init; }

        [Required]
        public string Title { get; init; }

        [Required]
        public int YearofRelease { get; init; }

        [Required]
        public IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
    }
}
