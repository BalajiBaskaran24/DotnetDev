using Movies.Application.Models;
using Movies.Contract.Request;
using Movies.Contract.Responses;
using System.Runtime.CompilerServices;

namespace Movies.Api.Mapping
{
    public static class ContractMapping
    {

        //Write all mapping
        public static Movie MapToMovie(this CreateMovieRequest request)
        {
            var movie = new Movie
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                YearOfRelease = request.YearofRelease,
                Genres = request.Genres.ToList()
            };
            return movie;
        }

    }
}
