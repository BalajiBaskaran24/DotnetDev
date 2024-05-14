using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Contract.Responses
{
    internal class MoviesResponse
    {
        public IEnumerable<MovieResponse> Responses { get; init; } = Enumerable.Empty<MovieResponse>();
    }
}
