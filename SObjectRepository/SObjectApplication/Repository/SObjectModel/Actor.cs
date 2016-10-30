using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Repository.SObjectModel.Utils;
using SObjectRepository.Repository.ChainCollection;
using SObjectRepository.Repository.SObjectModel.Utils;

namespace SObjectRepository.Repository.SObjectModel
{
	public class Actor : IEquatable<Actor>
	{
		public ImageHelper Image { get; set; }
		public InfoHuman Info { get; set; }
		public Chain<Film> Films { get; set; }
		public String Name { get; set; }


		public Actor()
		{
			Films = new Chain<Film>();
			Image = new ImageHelper();
			Info = new InfoHuman();
			Name = "";

		}

		public bool Equals(Actor other)
		{
			if (this.Name == other.Name &&
				this.Name == other.Name)
				return true;
			else
				return false;
		}
	}
}
