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
using SObjectRepository.Repository.SObjectModel;
using SObjectRepository.Repository.SObjectModel.Utils;
using System.Collections;
using System.ComponentModel;
using System.Collections.ObjectModel;
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Views.LibraryList.AddConstellation;
using SObjectApplication.Views.LibraryList.AddConstellation.Change;

namespace SObjectApplication.Views.LibraryList
{
	/// <summary>
	/// Interaction logic for ListStar.xaml
	/// </summary>
	public partial class ListStar : Window
	{
		private MainWindow rootElement;
		private Producer ParentConstellation;
		GridViewColumnHeader _lastHeaderClicked = null;
		ListSortDirection _lastDirection = ListSortDirection.Ascending;
		public ListStar(MainWindow rootElement, Producer ParentConstellation = null)
		{
			this.rootElement = rootElement;
			this.ParentConstellation = ParentConstellation;

			InitializeComponent();
			listView.ItemsSource = FilmStorage.Films.items.Where(x => (x.Producer == this.ParentConstellation || this.ParentConstellation == null));
			if(ParentConstellation == null)
			{
				//buttonLayout.Effect = new System.Windows.Media.Effects.BlurEffect();
				//btn_info.Effect = new System.Windows.Media.Effects.BlurEffect();
				//btn_add.Effect = new System.Windows.Media.Effects.BlurEffect();
				//btn_delete.Effect = new System.Windows.Media.Effects.BlurEffect();
				//btn_delete.IsEnabled = false;
				//btn_info.IsEnabled = false;
				btn_add.IsEnabled = false;
				btn_add.Visibility = Visibility.Hidden;
			}

		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			if (ParentConstellation == null)
				BackToMainWindow();
			else
				BackToListConstillation();
			
		}

		private void BackToMainWindow()
		{
			rootElement.Content = new Library(rootElement).Content;
		}
		private void BackToListConstillation()
		{
			rootElement.Content = new ListConstellation(rootElement).Content;
		}

		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount == 2)
			{
			}


		}
		private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (ParentConstellation != null)
			{
				ListViewItem item = sender as ListViewItem;
				object obj = item.Content;
				rootElement.Content = new ListPlanet(rootElement, ((Film)obj)).Content;
			}else
			{
				ListViewItem item = sender as ListViewItem;
				object obj = item.Content;
				rootElement.Content = new ListPlanet(rootElement, ((Film)obj), IsFromFullList:true).Content;

			}
		}

		private void btn_add_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new AddStar(rootElement, ParentConstellation).Content;
		}

		private void btn_delete_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			Film Selected = (Film)listView.SelectedItem;
			if (FilmStorage.Films.IsIncluded(Selected))
			{
				for (int i = 0; i < Selected.Actors.Length; i++)
					if (Selected.Actors[i].Films.IsIncluded(Selected))
						Selected.Actors[i].Films.Delete(Selected);
				if (ParentConstellation.Films.IsIncluded(Selected))
					ParentConstellation.Films.Delete(Selected);
				
				FilmStorage.Films.Delete(Selected);
				if (ParentConstellation == null)
					listView.ItemsSource = FilmStorage.Films;
				else
					listView.ItemsSource = ParentConstellation.Films.items;
			}
		}
		void GridViewColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
		{
			GridViewColumnHeader headerClicked = e.OriginalSource as GridViewColumnHeader;
			ListSortDirection direction;

			if (headerClicked != null)
			{
				if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
				{
					if (headerClicked != _lastHeaderClicked)
					{
						direction = ListSortDirection.Ascending;
					}
					else
					{
						if (_lastDirection == ListSortDirection.Ascending)
						{
							direction = ListSortDirection.Descending;
						}
						else
						{
							direction = ListSortDirection.Ascending;
						}
					}
					string header = "";
					if ((headerClicked.Column.Header as string) == "Title")
						header = "Name";
					else if ((headerClicked.Column.Header as string) == "Genre")
						header = "Info.GetGenre";
					else if ((headerClicked.Column.Header as String) == "Actors")
						header = "Actors.Length";
					else if ((headerClicked.Column.Header as String) == "Year")
						header = "ProductionDate.Year";
					else
						header = "Name";


					Sort(header, direction);

					_lastHeaderClicked = headerClicked;
					_lastDirection = direction;
				}
			}
		}
		private void Sort(string sortBy, ListSortDirection direction)
		{
			ICollectionView dataView =
			  CollectionViewSource.GetDefaultView(listView.ItemsSource);

			dataView.SortDescriptions.Clear();
			SortDescription sd = new SortDescription(sortBy, direction);
			dataView.SortDescriptions.Add(sd);
			dataView.Refresh();
		}

		private void btn_info_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			if (listView.SelectedIndex != -1)
			{
				rootElement.Content = new ChangeStar(rootElement, (Film)(listView.SelectedItem), ParentConstellation).Content;
			}
			else
			{

			}

		}
	}
}
