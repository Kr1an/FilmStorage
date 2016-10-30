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

namespace SObjectApplication.Views.LibraryList.AddConstellation.Change
{
	/// <summary>
	/// Interaction logic for ChangeConstellation.xaml
	/// </summary>
	public partial class ChangeConstellation : Window
	{
		public MainWindow rootElement;
		public Producer ChangeCond;
		public ChangeConstellation()
		{
			InitializeComponent();

		}

		public ChangeConstellation(MainWindow rootElement, Producer ChangeCond = null)
		{
			this.ChangeCond = ChangeCond;
			this.rootElement = rootElement;
			InitializeComponent();
			ComponentInit();
		}
		private  void ComponentInit()
		{
			name_text.Text = ChangeCond.Name;

			name_text.Text = ChangeCond.Name.ToString();
			year_text.Text = ChangeCond.Info.BirthDate.Year.ToString();
		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListConstellation(rootElement).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (!(name_text.Text == "" || name_text.Text.Length <= 1 ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year - 5))
			{
				ChangeCond.Name = name_text.Text;
				ChangeCond.Info.BirthDate = new DateTime(Convert.ToInt32(year_text.Text), ChangeCond.Info.BirthDate.Month, ChangeCond.Info.BirthDate.Day);
				rootElement.Content = new ListConstellation(rootElement).Content;
			}
			else
			{

			}
		}
	}
		
}
