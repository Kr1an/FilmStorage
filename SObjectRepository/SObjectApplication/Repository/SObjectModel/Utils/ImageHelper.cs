using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SObjectRepository.Repository.SObjectModel.Utils
{
	public class ImageHelper
	{
		public String ImagePath { get; set; }
		public Byte[] ByteArray;//Convertable to BitmapArray:

		public ImageHelper()
		{
			ByteArray = null;
		}
		public override string ToString()
		{
			return ByteArray.ToString();
		}
		public BitmapImage GetBitmapImage()
		{
			if (ByteArray == null)
				return new BitmapImage();
			else
				return ToImage(this.ByteArray);
		}

		public void ChangePicture(String Path)
		{
			BitmapImage bitmapImage = new BitmapImage(new Uri(Path));
			this.ByteArray = ImageToByte(bitmapImage);
		}

		public static byte[] ImageToByte(BitmapImage imageSource)
		{
			var encoder = new JpegBitmapEncoder();
			encoder.Frames.Add(BitmapFrame.Create(imageSource));

			using (var ms = new MemoryStream())
			{
				encoder.Save(ms);
				return ms.ToArray();
			}
		}

		public BitmapImage ToImage(byte[] array)
		{
			using (var ms = new System.IO.MemoryStream(array))
			{
				var image = new BitmapImage();
				image.BeginInit();
				image.CacheOption = BitmapCacheOption.OnLoad;
				image.StreamSource = ms;
				image.EndInit();
				return image;
			}
		}
	}
}
