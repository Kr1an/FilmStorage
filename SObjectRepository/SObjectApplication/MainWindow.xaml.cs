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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SObjectRepository.Repository.SObjectModel.Utils;
using SObjectRepository.Repository.SObjectModel;
using SObjectRepository.Repository.ChainCollection;
using System.IO;

namespace SObjectApplication
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	public partial class MainWindow : Window
	{
		public MainWindow rootElement;
		public double RuOpacity=1;
		public double EnOpacity;
		public MainWindow()
		{

			//System.Threading.Thread.CurrentThread.CurrentUICulture = Properties.Settings.Default.Lang;
			//LangChange();

			FilmStorage.StorageRead();

			
			
			rootElement = this;

			this.DataContext = this;
			InitializeComponent();
			
		}
		public MainWindow(MainWindow rootElement)
		{
			this.rootElement = rootElement;
			//DataContext = this;



			InitializeComponent();
			
		}
		public void LangChange()
		{
			if(System.Threading.Thread.CurrentThread.CurrentUICulture == System.Globalization.CultureInfo.GetCultureInfoByIetfLanguageTag("ru-RU"))
			{
				this.RuOpacity = 0.5;
				this.EnOpacity = 0.3;
			}else
			{
				this.RuOpacity = 0.3;
				this.EnOpacity = 0.5;
			}
		}

		private void btnLibrary_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new Library(rootElement).Content;
			
		}
		private void btnAdd_MouseUp(object sender, MouseButtonEventArgs e)
		{
			
		}

		private void name_text_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void btn_Exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			FilmStorage.StorageWrite();
			Application.Current.MainWindow.Close();
			
		}

		private void label1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)//ru
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfoByIetfLanguageTag("ru-RU");
			Properties.Settings.Default.Lang = System.Threading.Thread.CurrentThread.CurrentUICulture;
			LangChange();
		}

		private void label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)//en
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfoByIetfLanguageTag("en-US");
			Properties.Settings.Default.Lang = System.Threading.Thread.CurrentThread.CurrentUICulture;
			LangChange();
		}
	}
}
