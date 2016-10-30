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

namespace SObjectApplication.Views.LibraryList.AddConstellation
{
	/// <summary>
	/// Interaction logic for AddPlanet.xaml
	/// </summary>
	public partial class AddPlanet : Window
	{
		private MainWindow rootElement;
		private Film ParentStar;

		public AddPlanet()
		{
			InitializeComponent();
		}
		private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			

		}
		public AddPlanet(MainWindow rootElement, Film ParentStar = null)
		{
			this.rootElement = rootElement;
			this.ParentStar = ParentStar;
			InitializeComponent();
			listView.ItemsSource = FilmStorage.Actors.items.Where(x => (!ParentStar.Actors.IsIncluded(x)));
		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListPlanet(rootElement, ParentStar).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (listView.SelectedIndex != -1)
			{
				Actor tmpActor = ((Actor) listView.SelectedItem);
				ParentStar.Actors.Add(tmpActor);
				tmpActor.Films.Add(ParentStar);
				rootElement.Content = new ListPlanet(rootElement, ParentStar).Content;
			}
			if (!(name_text.Text == "" || name_text.Text.Length <= 1 ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year - 5))
			{
				
				Actor tmpActor = new Actor();
				tmpActor.Films.Add(ParentStar);
				ParentStar.Actors.Add(tmpActor);
				tmpActor.Name = name_text.Text;
				tmpActor.Info = new InfoHuman() {BirthDate = new DateTime(Convert.ToInt32(year_text.Text), 1, 1)};
				FilmStorage.Actors.Add(tmpActor);
				rootElement.Content = new ListPlanet(rootElement, ParentStar).Content;
			}
			else
			{

			}
		}
	}
}
