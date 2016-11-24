using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SObjectRepository.Repository.ChainCollection;
using SObjectRepository.Repository.SObjectModel.Utils;
using SObjectRepository.Repository.SObjectModel;
using System.IO;
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Repository.SObjectModel.Utils;
using System.IO.Compression;


namespace SObjectApplication
{
	class Entities
	{
		public Chain<Producer> Prudocers;
		public Chain<Film> Films;
		public Chain<Actor> Actors;
	}
	class FilmStorage
	{
		static public Chain<Actor> Actors = new Chain<Actor>();
		static public Chain<Film> Films = new Chain<Film>();
		static public Chain<Producer> Producers = new Chain<Producer>();
		
		public static void AddRecords()
		{
				
			
			FilmStorage.Actors.Add(new Actor() { Name = "Jack Nicholson", Info = new InfoHuman() { ExpHistory = "" } });
			FilmStorage.Actors.Add(new Actor() { Name = "Ralph Fiennes", Info = new InfoHuman() { ExpHistory = "" } });
			FilmStorage.Actors.Add(new Actor() { Name = "Daniel Lewis", Info = new InfoHuman() { ExpHistory = "" } });
			FilmStorage.Actors.Add(new Actor() { Name = "Robert De Niro", Info = new InfoHuman() { ExpHistory = "" } });
			FilmStorage.Actors.Add(new Actor() { Name = "Al Pacino", Info = new InfoHuman() { ExpHistory = "" } });
			FilmStorage.Actors.Add(new Actor() { Name = "Dustin Hoffman", Info = new InfoHuman() { ExpHistory = "" } });
			FilmStorage.Actors.Add(new Actor() { Name = "Tom Hanks", Info = new InfoHuman() { ExpHistory = "" } });
			FilmStorage.Actors.Add(new Actor() { Name = "Brad Pitt", Info = new InfoHuman() { ExpHistory = "" } });




			FilmStorage.Films.Add(new Film() { Info = new InfoFilm(), Name = "film1" });
			FilmStorage.Films.Add(new Film() { Info = new InfoFilm(), Name = "film2" });
			FilmStorage.Films.Add(new Film() { Info = new InfoFilm(), Name = "film3" });
			FilmStorage.Films.Add(new Film() { Info = new InfoFilm(), Name = "film4" });

			FilmStorage.Producers.Add(new Producer() { Info = new InfoHuman(), Name = "Producers1" });
			FilmStorage.Producers.Add(new Producer() { Info = new InfoHuman(), Name = "Producers2" });
			FilmStorage.Producers.Add(new Producer() { Info = new InfoHuman(), Name = "Producers3" });
			FilmStorage.Producers.Add(new Producer() { Info = new InfoHuman(), Name = "Producers4" });

			FilmStorage.Films[0].Producer = FilmStorage.Producers[0];
			FilmStorage.Films[1].Producer = FilmStorage.Producers[1];
			FilmStorage.Films[2].Producer = FilmStorage.Producers[2];
			FilmStorage.Films[3].Producer = FilmStorage.Producers[3];


			FilmStorage.Actors[0].Films.Add(FilmStorage.Films[0]);
			FilmStorage.Actors[3].Films.Add(FilmStorage.Films[0]);
			FilmStorage.Actors[2].Films.Add(FilmStorage.Films[1]);
			FilmStorage.Actors[1].Films.Add(FilmStorage.Films[1]);
			FilmStorage.Actors[1].Films.Add(FilmStorage.Films[2]);
			FilmStorage.Actors[2].Films.Add(FilmStorage.Films[2]);
			FilmStorage.Actors[2].Films.Add(FilmStorage.Films[3]);
			FilmStorage.Actors[3].Films.Add(FilmStorage.Films[3]);
			
			FilmStorage.Films[0].Actors.Add(FilmStorage.Actors[0]);
			FilmStorage.Films[0].Actors.Add(FilmStorage.Actors[3]);
			FilmStorage.Films[1].Actors.Add(FilmStorage.Actors[1]);
			FilmStorage.Films[1].Actors.Add(FilmStorage.Actors[2]);
			FilmStorage.Films[2].Actors.Add(FilmStorage.Actors[1]);
			FilmStorage.Films[2].Actors.Add(FilmStorage.Actors[2]);
			FilmStorage.Films[3].Actors.Add(FilmStorage.Actors[2]);
			FilmStorage.Films[3].Actors.Add(FilmStorage.Actors[3]);

			FilmStorage.Producers[0].Films.Add(FilmStorage.Films[0]);			
			FilmStorage.Producers[1].Films.Add(FilmStorage.Films[1]);			
			FilmStorage.Producers[2].Films.Add(FilmStorage.Films[2]);			
			FilmStorage.Producers[3].Films.Add(FilmStorage.Films[3]);
		}
	}
}
