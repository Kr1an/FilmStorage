using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Repository.SObjectModel.Utils;
using SObjectRepository.Repository.ChainCollection;
using SObjectRepository.Repository.SObjectModel.Utils;
using SObjectApplication.Repository.SObjectModel.Abstract;

namespace SObjectRepository.Repository.SObjectModel
{
	public class Producer : IImageHandler, IEquatable<Producer>
	{
		public ImageHelper Image { get; set; }
		public Chain<Film> Films { get; set; }
		public String Name { get; set; }
		public InfoHuman Info { get; set; }
		public Producer()
		{
			Info = new InfoHuman();
			Films = new Chain<Film>();
			Image = new ImageHelper();
			Name = "";
		}

		public bool Equals(Producer Other)
		{
			if (this.Name == Other.Name &&
				this.Name == Other.Name)
				return true;
			else
				return false;
		}
	}
}