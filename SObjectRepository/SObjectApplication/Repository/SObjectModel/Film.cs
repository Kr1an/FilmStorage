using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Repository.SObjectModel.Utils;
using SObjectRepository.Repository.ChainCollection;
using SObjectRepository.Repository.SObjectModel;
using SObjectRepository.Repository.SObjectModel.Utils;

namespace SObjectApplication.Repository.SObjectModel
{
	public class Film : IEquatable<Film>
	{
		public ImageHelper Image { get; set; }
		public Chain<Actor> Actors { get; set; }
		public String Name { get; set; }
		public InfoFilm Info { get; set; }
		public Producer Producer { get; set; }

		public Film()
		{
			Image = new ImageHelper();
			Actors = new Chain<Actor>();
			Info = new InfoFilm();
			Name = "";
			Producer = new Producer();

		}

		public bool Equals(Film other)
		{
			if (this.Name == other.Name &&
				this.Name == other.Name)
				return true;
			else
				return false;
		}

		public override string ToString()
		{
			return Name + "(" + Info.ProductionDate.Year + ")";
		}
	}
}
