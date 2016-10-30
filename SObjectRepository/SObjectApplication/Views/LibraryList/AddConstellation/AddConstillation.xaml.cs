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
using SObjectApplication.Repository.SObjectModel.Utils;
using SObjectRepository.Repository.ChainCollection;

using SObjectRepository.Repository.SObjectModel;
using SObjectRepository.Repository.SObjectModel.Utils;

namespace SObjectApplication.Views.LibraryList.AddConstellation
{
	/// <summary>
	/// Interaction logic for AddConstillation.xaml
	/// </summary>
	public partial class AddConstillation : Window
	{
		public MainWindow rootElement;
		public AddConstillation()
		{
			InitializeComponent();
		}
		public AddConstillation(MainWindow rootElement)
		{
			this.rootElement = rootElement;
			InitializeComponent();
		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListConstellation(rootElement).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if(!(name_text.Text == "" || name_text.Text.Length <= 1 ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year-5))
			{
				FilmStorage.Producers.Add(new Producer() {Name = name_text.Text, Info = new InfoHuman() {BirthDate = new DateTime(Convert.ToInt32(year_text.Text), 1, 1)} });
				rootElement.Content = new ListConstellation(rootElement).Content;
			}
			else
			{

			}
		}
	}
}
