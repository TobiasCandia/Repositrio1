using BlazorCRUD.Model;
using BlazorCRUD.UI.Interfaces;

namespace BlazorCRUD.UI.Services
{
	public class IFilmService : IFilmsService


	{
		public Task<Film> DeleteFilm(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Film>> GetAllFilms()
		{
			throw new NotImplementedException();
		}

		public Task<Film> GetDetails(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Film> SaveFilm(Film film)
		{
			throw new NotImplementedException();
		}
	}
}
