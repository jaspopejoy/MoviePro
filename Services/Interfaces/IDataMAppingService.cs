using MoviePro.Models.Database;
using MoviePro.Models.TMDB;

namespace MoviePro.Services.Interfaces
{
    public interface IDataMAppingService
    {
        Task<Movie> MapMovieDetailAsync(MovieDetail movie);
        ActorDetail MapActorDetail(ActorDetail actor);
        string BuildCastImage(string profilePath);
    }
}
