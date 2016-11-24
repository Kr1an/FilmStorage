using System;
using System.Collections.Generic;
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
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Repository.SObjectModel.Utils;
using SObjectRepository.Repository.ChainCollection;
using SObjectRepository.Repository.SObjectModel;
using SObjectRepository.Repository.SObjectModel.Utils;
using Microsoft.Win32;

namespace SObjectApplication.Views.LibraryList.AddProducer
{
	/// <summary>
	/// Interaction logic for AddActor.xaml
	/// </summary>
	public partial class AddActor : Window
	{
		private MainWindow rootElement;
		private Film ParentFilm;
		public ImageHelper ImageHelper;

		public AddActor()
		{
			InitializeComponent();
		}
		private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			

		}
		public AddActor(MainWindow rootElement, Film ParentFilm = null)
		{
			this.rootElement = rootElement;
			this.ParentFilm = ParentFilm;
			InitializeComponent();
			listView.ItemsSource = FilmStorage.Actors.items.Where(x => (!ParentFilm.Actors.IsIncluded(x)));
		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListActor(rootElement, ParentFilm).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (listView.SelectedIndex != -1)
			{
				Actor tmpActor = ((Actor) listView.SelectedItem);
				ParentFilm.Actors.Add(tmpActor);
				tmpActor.Films.Add(ParentFilm);
				rootElement.Content = new ListActor(rootElement, ParentFilm).Content;
			}
			if (!(name_text.Text == "" || name_text.Text.Length <= 1 ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year - 5))
			{
				
				Actor tmpActor = new Actor();
				if (ImageHelper != null)
				{
					tmpActor.Image = this.ImageHelper;

				}
				tmpActor.Films.Add(ParentFilm);
				ParentFilm.Actors.Add(tmpActor);
				tmpActor.Name = name_text.Text;
				tmpActor.Info = new InfoHuman() {BirthDate = new DateTime(Convert.ToInt32(year_text.Text), 1, 1)};
				FilmStorage.Actors.Add(tmpActor);
				rootElement.Content = new ListActor(rootElement, ParentFilm).Content;
			}
			else
			{

			}
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
