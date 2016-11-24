using SObjectRepository.Repository.SObjectModel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SObjectApplication.Repository.SObjectModel.Abstract
{
	public interface IImageHandler
	{
		ImageHelper Image { get; set; }
	}
}
