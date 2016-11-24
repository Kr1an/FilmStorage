using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// 


	public partial class MainWindow : Window
	{
		BitmapImage bitmap;
		BitmapImage bitmap2;
		
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnOpenFile_Click(object sender, RoutedEventArgs e)
		{
			
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.bmp, *.jpg) | *.bmp; *.jpg";
			if (openFileDialog.ShowDialog() == true)
			{
				 
				image.Source = imghelp.GetBitmapImage();
			}
				
				
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
				image.CacheOption = BitmapCacheOption.OnLoad; // here
				image.StreamSource = ms;
				image.EndInit();
				return image;
			}
		}
	}
}
