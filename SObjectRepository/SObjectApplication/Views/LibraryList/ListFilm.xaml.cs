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
using SObjectApplication.Views.LibraryList.AddProducer;
using SObjectApplication.Views.LibraryList.AddProducer.Change;

namespace SObjectApplication.Views.LibraryList
{
	/// <summary>
	/// Interaction logic for ListFilm.xaml
	/// </summary>
	public partial class ListFilm : Window
	{
		private MainWindow rootElement;
		private Producer ParentProducer;
		GridViewColumnHeader _lastHeaderClicked = null;
		ListSortDirection _lastDirection = ListSortDirection.Ascending;
		public ListFilm(MainWindow rootElement, Producer ParentProducer = null)
		{
			this.rootElement = rootElement;
			this.ParentProducer = ParentProducer;

			InitializeComponent();
			listView.ItemsSource = FilmStorage.Films.items.Where(x => (x.Producer == this.ParentProducer || this.ParentProducer == null));
			if(ParentProducer == null)
			{
				
				btn_add.IsEnabled = false;
				btn_add.Visibility = Visibility.Hidden;
			}

		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			if (ParentProducer == null)
				BackToMainWindow();
			else
				BackToListProducer();
			
		}

		private void BackToMainWindow()
		{
			rootElement.Content = new Library(rootElement).Content;
		}
		private void BackToListProducer()
		{
			rootElement.Content = new ListProducer(rootElement).Content;
		}

		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount == 2)
			{
			}


		}
		private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (ParentProducer != null)
			{
				ListViewItem item = sender as ListViewItem;
				object obj = item.Content;
				rootElement.Content = new ListActor(rootElement, ((Film)obj)).Content;
			}else
			{
				ListViewItem item = sender as ListViewItem;
				object obj = item.Content;
				rootElement.Content = new ListActor(rootElement, ((Film)obj), IsFromFullList:true).Content;

			}
		}

		private void btn_add_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new AddFilm(rootElement, ParentProducer).Content;
		}

		private void btn_delete_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			Film Selected = (Film)listView.SelectedItem;
			if (FilmStorage.Films.IsIncluded(Selected))
			{
				for (int i = 0; i < Selected.Actors.Length; i++)
					if (Selected.Actors[i].Films.IsIncluded(Selected))
						Selected.Actors[i].Films.Delete(Selected);
				
				Selected.Producer.Films.DeleteAt(Selected.Producer.Films.IndexOf(Selected));
				
				FilmStorage.Films.DeleteAt(FilmStorage.Films.IndexOf(Selected));
				if (ParentProducer == null)
					listView.ItemsSource = FilmStorage.Films.items;
				else
					listView.ItemsSource = ParentProducer.Films.items;
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
				rootElement.Content = new ChangeFilm(rootElement, (Film)(listView.SelectedItem), ParentProducer).Content;
			}
			else
			{

			}

		}
	}
}
