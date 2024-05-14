using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Contract.Request
{
    public class UpdateMovieRequest
    {
        [Required]
        public string Title { get; init; }

        [Required]
        public int YearofRelease { get; init; }

        [Required]
        public IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
    }
}
