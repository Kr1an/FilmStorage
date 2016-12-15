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
		public Chain<Producer> Pruducers;
		public Chain<Film> Films;
		public Chain<Actor> Actors;
	}
	class FilmStorage
	{
		public static Entities Entities;
		static public Chain<Producer> Producers;
		static public Chain<Film> Films;
		static public Chain<Actor> Actors;
		public StreamWriter SavingFile;
		public StreamReader LoadingFile;
		static public String FileName = "FilmDB.dat";//can be changed
		static public String ZipName = "FilmDB.dat.gz";//can be changed
		static public String FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FilmStorage");
		static public String FullPath = Path.Combine(FolderPath, FileName);

		public void SaveStorage(String saveFormString)
		{
			char[] temp = new char[saveFormString.Length];
			for (int i = 0; i < saveFormString.Length; i++)
				temp[i] = Convert.ToChar(Convert.ToInt32(saveFormString[i]) + 5);


			SavingFile = new StreamWriter(FullPath, false);
			SavingFile.Write(new String(temp));
			SavingFile.Flush();
			SavingFile.Close();




		}
		public static void Compress(DirectoryInfo directorySelected)
		{
			foreach (FileInfo fileToCompress in directorySelected.GetFiles())
			{
				using (FileStream originalFileStream = fileToCompress.OpenRead())
				{
					if ((File.GetAttributes(fileToCompress.FullName) &
					   FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
					{
						using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
						{
							using (GZipStream compressionStream = new GZipStream(compressedFileStream,
							   CompressionMode.Compress))
							{
								originalFileStream.CopyTo(compressionStream);

							}
						}
						FileInfo info = new FileInfo(FolderPath + "\\" + fileToCompress.Name + ".gz");
						Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
						fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString());
					}

				}
			}
		}
		public static void Decompress(FileInfo fileToDecompress)
		{
			using (FileStream originalFileStream = fileToDecompress.OpenRead())
			{
				string currentFileName = fileToDecompress.FullName;
				string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

				using (FileStream decompressedFileStream = File.Create(newFileName))
				{
					using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
					{
						decompressionStream.CopyTo(decompressedFileStream);
						Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
					}
				}
			}
		}
		static public void StorageWrite()
		{
			File.Delete(Path.Combine(FolderPath, ZipName));
			File.Delete(Path.Combine(FolderPath, FullPath));
			string str = "";

			Entities.Pruducers = Producers;
			Entities.Films = Films;
			Entities.Actors = Actors;
			str = Repository.Serializer.Serializer.ToBin(Entities);
			new FilmStorage().SaveStorage(str);
			DirectoryInfo directorySelected = new DirectoryInfo(FolderPath);
			Compress(directorySelected);
			File.Delete(FullPath);
		}
		static public void StorageRead()
		{
			FilmStorage.Actors = new Chain<Actor>();
			FilmStorage.Films = new Chain<Film>();
			FilmStorage.Producers = new Chain<Producer>();
			FilmStorage.Entities = new Entities();

			if (!File.Exists(Path.Combine(FolderPath, ZipName)))
			{
				if (!Directory.Exists(FolderPath))
					Directory.CreateDirectory(FolderPath);
				if (!File.Exists(FullPath))
					File.Delete(FullPath);
				AddRecords();
			}
			else
			{
				DirectoryInfo directorySelected = new DirectoryInfo(FolderPath);
				foreach (FileInfo fileToDecompress in directorySelected.GetFiles("*.gz"))
				{
					Decompress(fileToDecompress);
				}
				string str = new FilmStorage().LoadStorage();

				Entities = Repository.Serializer.Serializer.ToObj<Entities>(str);

				Producers = Entities.Pruducers;
				Films = Entities.Films;
				Actors = Entities.Actors;


				//Planets = PlanetFormatter.GetPlanetList(str);
				//Stars = StarFormatter.GetStarList(str);
				//Constellations = ConstellationFormatter.GetConstellationList(str);
				//EntitiesFormatter.MakeEntity(str);
			}
		}
		public string LoadStorage()
		{
			LoadingFile = new StreamReader(FullPath);
			string result = LoadingFile.ReadLine();
			LoadingFile.Close();
			File.Delete(FullPath);
			char[] temp = new char[result.Length];
			for (int i = 0; i < result.Length; i++)
				temp[i] = Convert.ToChar(Convert.ToInt32(result[i]) - 5);
			result = new string(temp);
			return result;

		}

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
