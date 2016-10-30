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
using SObjectApplication.Views.LibraryList.AddConstellation.Change;
using SObjectApplication.Repository.SObjectModel;

namespace SObjectApplication.Views.LibraryList
{
	/// <summary>
	/// Interaction logic for ListConstellation.xaml
	/// </summary>
	public partial class ListConstellation : Window
	{
		GridViewColumnHeader _lastHeaderClicked = null;
		ListSortDirection _lastDirection = ListSortDirection.Ascending;

		private MainWindow rootElement;

		public ListConstellation( MainWindow rootElement)
		{
			this.rootElement = rootElement;
			InitializeComponent();
			listView.ItemsSource = FilmStorage.Producers.items;
		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			BackToMainWindow();
		}

		private void BackToMainWindow()
		{
			rootElement.Content = new Library(rootElement).Content;
		}

		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount == 2)
			{
				//textBox.Text = listView.SelectedIndex.ToString();
			}


		}
		private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			ListViewItem item = sender as ListViewItem;
			object obj = item.Content;
			rootElement.Content = new ListStar(rootElement, ((Producer)obj)).Content;
			
		}


		private void listView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
		}
		private void btn_add_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new AddConstellation.AddConstillation(rootElement).Content;
		}

		private void btn_delete_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			Producer Selected = (Producer)listView.SelectedItem;
			if (FilmStorage.Producers.IsIncluded(((Producer)listView.SelectedItem)))
			{
				for (int i = 0; i < Selected.Films.Length; i++)
				{
					for (int j = 0; j < Selected.Films[i].Actors.Length; j++)
					{
						Selected.Films[i].Actors[j].Films.Delete(Selected.Films[i]);
						if (Selected.Films[i].Actors[j].Films.Length <= 0)
						{
							FilmStorage.Actors.Delete(Selected.Films[i].Actors[j]);
						}
					}
					FilmStorage.Films.DeleteAt(FilmStorage.Films.IndexOf(Selected.Films[i]));
				}
				FilmStorage.Producers.DeleteAt(FilmStorage.Producers.IndexOf(Selected));
				
			}
			listView.ItemsSource = FilmStorage.Producers.items;
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
					if ((headerClicked.Column.Header as string) == "Name")
						header = "Name";
					else if ((headerClicked.Column.Header as string) == "Example")
						header = "Films.Sample";
					else if ((headerClicked.Column.Header as string) == "Films")
						header = "Films.Length";
					else if ((headerClicked.Column.Header as String) == "Year")
						header = "Info.BirthDate";
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
			if(listView.SelectedIndex != -1)
			{
				rootElement.Content = new LibraryList.AddConstellation.Change.ChangeConstellation(rootElement, ((Producer)listView.SelectedItem)).Content;
			}
			else
			{

			}
		}
	}
}
