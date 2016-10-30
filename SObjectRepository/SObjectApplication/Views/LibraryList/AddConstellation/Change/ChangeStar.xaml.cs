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

namespace SObjectApplication.Views.LibraryList.AddConstellation.Change
{
	/// <summary>
	/// Interaction logic for ChangeStar.xaml
	/// </summary>
	public partial class ChangeStar : Window
	{
		private MainWindow rootElement;
		private Film ChangeCond;
		private Producer ParentConstellation;
		public ChangeStar()
		{
			InitializeComponent();
			ComponentInit();
		}
		public ChangeStar(MainWindow rootElement, Film ChangeCond, Producer ParentConstellation = null)
		{
			this.rootElement = rootElement;
			this.ChangeCond = ChangeCond;
			this.ParentConstellation = ParentConstellation;
			InitializeComponent();
			ComponentInit();
		}
		private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			ListViewItem item = sender as ListViewItem;
			object obj = item.Content;
			const_text.Text = ((Producer)obj).Name;
		}

		private void ComponentInit()
		{
			year_text.Text = ChangeCond.Info.ProductionDate.Year.ToString();
			listView.ItemsSource = FilmStorage.Producers.items;
			name_text.Text = ChangeCond.Name;
			genre_text.Text = Genres.GenreById((int) c_slider.Value);
			c_slider.Value = ChangeCond.Info.Genre;
			producer_text.Text = ChangeCond.Producer.Name;
		}

		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListStar(rootElement, ParentConstellation).Content;
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
					ParentConstellation.Films.Delete(ChangeCond);
					ChangeCond.Producer = ((Producer)listView.SelectedItem);
					ChangeCond.Producer.Films.Add(ChangeCond);
				}
				rootElement.Content = new ListStar(rootElement, ParentConstellation).Content;
			}
			else
			{

			}






		}

		private void c_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			String tmp = "";
			switch ((int)c_slider.Value)
			{
				case 0: tmp = "O Spector"; break;
				case 1: tmp = "B Spector"; break;
				case 2: tmp = "A Spector"; break;
				case 3: tmp = "F Spector"; break;
				case 4: tmp = "G Spector"; break;
				case 5: tmp = "K Spector"; break;
				case 6: tmp = "W Spector"; break;
				case 7: tmp = "L Spector"; break;
				case 8: tmp = "T Spector"; break;
				case 9: tmp = "Y Spector"; break;
				case 10: tmp = "C Spector"; break;
				case 11: tmp = "S Spector"; break;
				case 12: tmp = "D Spector"; break;
				case 13: tmp = "Q Spector"; break;
				case 14: tmp = "P Spector"; break;
			}
			spec_class.Content = tmp;

		}
	}
}
