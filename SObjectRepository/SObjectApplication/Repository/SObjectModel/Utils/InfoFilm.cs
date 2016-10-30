using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace SObjectApplication.Repository.SObjectModel.Utils
{
	public class InfoFilm
	{
		public String Description { get; set; }
		public Int32 Genre { get; set; }
		public DateTime ProductionDate { get; set; }

		public InfoFilm()
		{
			this.ProductionDate = new DateTime(2010, 8, 8, 8, 8, 8);
			this.Description = "Film Description";
			this.Genre = Genres.Adventure;
		}
		public String GetGenre
		{
			get { return Genres.GenreById(Genre); }
		}
	}

	public static class Genres
	{
		public static int Horror = 0;
		public static int Comedy = 1;
		public static int Drama = 2;
		public static int Western = 3;
		public static int Adventure = 4;

		public static  String GenreById(int genreId)
		{
			switch (genreId)
			{
				case 0:
					return "Horror";
					break;
				case 1:
					return "Comedy";
					break;
				case 2:
					return "Drama";
					break;
				case 3:
					return "Western";
					break;
				case 4:
					return "Adventure";
					break;
				default:
					return "";
					break;
			}


		}
	}
}
