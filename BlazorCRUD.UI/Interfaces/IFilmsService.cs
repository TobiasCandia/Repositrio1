using BlazorCRUD.Model;

namespace BlazorCRUD.UI.Interfaces
{
	public interface IFilmsService
	{
		Task<IEnumerable<Film>> GetAllFilms();
		Task<Film> GetDetails(int id);
		Task<Film> DeleteFilm(int id);
		Task<Film> SaveFilm(Film film);
	}
}
