using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerCRUD.Data.Dapper.Repositories
{
	public interface IFilmRepository
	{
		Task<IEnumerable<Film>> GetAllFlims();
		Task<Film> GetFlimDetails(int id);
		Task<bool> InsertFilm(Film film);
		Task<bool> UpdateFilm(Film film);
		Task<bool> DeleteFilm(int id);

	}
}
