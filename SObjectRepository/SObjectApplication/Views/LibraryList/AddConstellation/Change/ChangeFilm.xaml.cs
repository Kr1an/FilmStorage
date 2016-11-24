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

namespace SObjectApplication.Views.LibraryList.AddProducer.Change
{
	/// <summary>
	/// Interaction logic for ChangeFilm.xaml
	/// </summary>
	public partial class ChangeFilm : Window
	{
		private MainWindow rootElement;
		private Film ChangeCond;
		private Producer ParentProducer;
		public ChangeFilm()
		{
			InitializeComponent();
			ComponentInit();
		}
		public ChangeFilm(MainWindow rootElement, Film ChangeCond, Producer ParentProducer = null)
		{
			this.rootElement = rootElement;
			this.ChangeCond = ChangeCond;
			this.ParentProducer = ParentProducer;
			InitializeComponent();
			ComponentInit();
		}
		private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			ListViewItem item = sender as ListViewItem;
			object obj = item.Content;
			producer_text.Text = ((Producer)obj).Name;
		}

		private void ComponentInit()
		{
			if(ChangeCond.Image.ByteArray != null)
			{
				image.Source = ChangeCond.Image.GetBitmapImage();
			}
			year_text.Text = ChangeCond.Info.ProductionDate.Year.ToString();
			listView.ItemsSource = FilmStorage.Producers.items;
			name_text.Text = ChangeCond.Name;
			genre_text.Text = Genres.GenreById((int) c_slider.Value);
			c_slider.Value = ChangeCond.Info.Genre;
			producer_text.Text = ChangeCond.Producer.Name;
		}

		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListFilm(rootElement, ParentProducer).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (!(name_text.Text == "" || name_text.Text == "NAME" ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year - 5))
			{
				ChangeCond.Name = name_text.Text;
				ChangeCond.Info.Genre = (int)c_slider.Value;
				if (listView.SelectedIndex != -1)
				{
					ChangeCond.Producer.Films.Delete(ChangeCond);
					ChangeCond.Producer = ((Producer)listView.SelectedItem);
					ChangeCond.Producer.Films.Add(ChangeCond);
				}
				rootElement.Content = new ListFilm(rootElement, ParentProducer).Content;
			}
			else
			{

			}






		}

		private void c_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			

			genre_text.Text = Genres.GenreById((int)c_slider.Value);

		}

		private void image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.bmp, *.jpg) | *.bmp; *.jpg";
			if (openFileDialog.ShowDialog() == true)
			{
				this.ChangeCond.Image.ChangePicture(openFileDialog.FileName);
				image.Source = ChangeCond.Image.GetBitmapImage();
			}
		}
	}
}
