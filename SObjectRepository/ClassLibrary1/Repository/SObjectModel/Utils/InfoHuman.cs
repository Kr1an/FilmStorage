using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SObjectApplication.Repository.SObjectModel.Utils
{
	public class InfoHuman
	{
		public String ExpHistory { get; set; }
		public DateTime BirthDate { get; set; }
		
		
		public InfoHuman()
		{
			this.ExpHistory = "History about human Expirience";
			this.BirthDate = new DateTime(1980, 12, 17, 23, 40, 0);
		}
	}
}
