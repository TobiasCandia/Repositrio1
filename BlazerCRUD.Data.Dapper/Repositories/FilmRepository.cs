using BlazorCRUD.Model;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerCRUD.Data.Dapper.Repositories
{
	public class FilmRepository : IFilmRepository
	{
		private string ConnectionString;

		public FilmRepository(string ConnectionString)

		{
			ConnectionString = ConnectionString;
		}

		protected SqlConnection dbConnection()
		{ 
		 return new SqlConnection (ConnectionString);
		}
		public Task<bool> DeleteFilm(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Film>> GetAllFlims()
		{
			throw new NotImplementedException();
		}

		public Task<Film> GetFlimDetails(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> InsertFilm(Film film)
		{
			var db = dbConnection();

			var sql = @"
				        INSERT INTO Films(Title, Director, ReleaseDate)
                        VALUES(@Title, @Director, @ReleaseDate)";
			var result = await db.ExecuteAsync(sql.ToString(),
									  new { film.Title, film.Director, film.ReleaseDate });

			return result > 0;

		}

		public Task<bool> UpdateFilm(Film film)
		{
			throw new NotImplementedException();
		}
	}
}
