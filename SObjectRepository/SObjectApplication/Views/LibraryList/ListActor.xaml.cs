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

using SObjectRepository.Repository.ChainCollection;

using SObjectRepository.Repository.SObjectModel;
using SObjectRepository.Repository.SObjectModel.Utils;
using System.ComponentModel;
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Views.LibraryList.AddProducer;
using SObjectApplication.Views.LibraryList.AddProducer.Change;

namespace SObjectApplication.Views.LibraryList
{
	/// <summary>
	/// Interaction logic for ListActor.xaml
	/// </summary>
	public partial class ListActor : Window
	{
		private bool IsFromFullList;
		private MainWindow rootElement;
		private Film ParentFilm;
		GridViewColumnHeader _lastHeaderClicked = null;
		ListSortDirection _lastDirection = ListSortDirection.Ascending;

		public ListActor(MainWindow rootElement, Film ParentFilm = null, bool IsFromFullList = false)
		{
			this.IsFromFullList = IsFromFullList;
			this.rootElement = rootElement;
			this.ParentFilm = ParentFilm;

			InitializeComponent();
			listView.ItemsSource = FilmStorage.Actors.items.Where(x => (x.Films.IsIncluded(ParentFilm) || this.ParentFilm == null));
			if (ParentFilm == null)
			{
				//buttonLayout.Effect = new System.Windows.Media.Effects.BlurEffect();
				//btn_info.Effect = new System.Windows.Media.Effects.BlurEffect();
				//btn_add.Effect = new System.Windows.Media.Effects.BlurEffect();
				//btn_delete.Effect = new System.Windows.Media.Effects.BlurEffect();
				//btn_delete.IsEnabled = false;
				//btn_add.IsEnabled = false;
				//btn_info.IsEnabled = false;
				btn_add.IsEnabled = false;
				btn_add.Visibility = Visibility.Hidden;
			}
		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			if (IsFromFullList)
			{
				rootElement.Content = new ListFilm(rootElement).Content;
			}else if (ParentFilm == null)
				BackToMainWindow();
			else
				BackToListFilm();

		}

		private void BackToMainWindow()
		{
			rootElement.Content = new Library(rootElement).Content;
		}
		private void BackToListFilm()
		{
			rootElement.Content = new ListFilm(rootElement, ParentFilm.Producer).Content;
		}

		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount == 2)
			{
			}


		}
		private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
		}


		private void listView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
		}
		private void btn_add_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new AddActor(rootElement, ParentFilm).Content;
		}

		private void btn_delete_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			Actor Selected = (Actor)listView.SelectedItem;
			if (FilmStorage.Actors.IsIncluded(Selected))
			{
				for (int i = 0; i < Selected.Films.Length; i++)
					Selected.Films[i].Actors.DeleteAt(Selected.Films[i].Actors.IndexOf(Selected));
				FilmStorage.Actors.DeleteAt(FilmStorage.Actors.IndexOf(Selected));
			}
			if(ParentFilm == null)
				listView.ItemsSource = FilmStorage.Actors.items;
			else
				listView.ItemsSource = FilmStorage.Actors.items.Where(x => (x.Films.IsIncluded(ParentFilm)));
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
					else if ((headerClicked.Column.Header as string) == "Type")
						header = "Feature.ActorTypeString";
					else if((headerClicked.Column.Header as String) == "Parent Film")
						header = "ParentFilm.Name";
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
			if(ParentFilm == null)
			{
				rootElement.Content = new ChangeActor(rootElement, (Actor)(listView.SelectedItem)).Content;

			}
			else if (IsFromFullList)
			{
				rootElement.Content = new ChangeActor(rootElement, (Actor)(listView.SelectedItem), IsFromFullList:this.IsFromFullList).Content;
			}
			else if (listView.SelectedIndex != -1)
			{
				rootElement.Content = new ChangeActor(rootElement, (Actor)(listView.SelectedItem), ParentFilm, ParentFilm.Producer).Content;
			}
			else
			{

			}
		}
	}
}
