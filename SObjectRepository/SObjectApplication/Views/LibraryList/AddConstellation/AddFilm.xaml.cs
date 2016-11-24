using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
using System.Windows.Shapes;

using SObjectRepository.Repository.ChainCollection;
using SObjectRepository.Repository.SObjectModel;
using SObjectRepository.Repository.SObjectModel.Utils;
using SObjectApplication.Views.LibraryList;
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Repository.SObjectModel.Utils;
using Microsoft.Win32;

namespace SObjectApplication.Views.LibraryList.AddProducer
{
	/// <summary>
	/// Interaction logic for AddFilm.xaml
	/// </summary>
	public partial class AddFilm : Window
	{
		private MainWindow rootElement;
		private Producer ParentProducer;
		public ImageHelper ImageHelper;
		public AddFilm()
		{
			InitializeComponent();
		}
		public AddFilm(MainWindow rootElement, Producer ParentProducer = null)
		{
			this.rootElement = rootElement;
			this.ParentProducer = ParentProducer;
			InitializeComponent();
			ComponentInit();

		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListFilm(rootElement, ParentProducer).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (!(name_text.Text == "" || name_text.Text.Length <= 1 ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year))
			{
				Film tmpFilm = new Film()
				{
					Producer = ParentProducer,
					Name = name_text.Text,
					Info =
						new InfoFilm()
						{
							Genre = (int) c_slider.Value,
							ProductionDate = new DateTime(Convert.ToInt32(year_text.Text), 1, 1)
						}
				};
				if(this.ImageHelper != null)
				{
					tmpFilm.Image = this.ImageHelper;
				}
				FilmStorage.Films.Add(tmpFilm);
				ParentProducer.Films.Add(tmpFilm);
				rootElement.Content = new ListFilm(rootElement, ParentProducer).Content;
			}
			else
			{

			}
		}

		public void ComponentInit()
		{
			c_slider.Value = 2;
		}
		public void c_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (GenreText != null)
				GenreText.Text = Genres.GenreById((int)c_slider.Value);
		}

		private void image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.bmp, *.jpg) | *.bmp; *.jpg";
			if (openFileDialog.ShowDialog() == true)
			{
				this.ImageHelper = new ImageHelper();
				this.ImageHelper.ChangePicture(openFileDialog.FileName);
				image.Source = this.ImageHelper.GetBitmapImage();
			}
		}
	}
}
