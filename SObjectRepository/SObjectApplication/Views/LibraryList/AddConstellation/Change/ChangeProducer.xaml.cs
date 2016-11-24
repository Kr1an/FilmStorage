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
using Microsoft.Win32;

namespace SObjectApplication.Views.LibraryList.AddProducer.Change
{
	/// <summary>
	/// Interaction logic for ChangeProducer.xaml
	/// </summary>
	public partial class ChangeProducer : Window
	{
		public MainWindow rootElement;
		public Producer ChangeCond;
		public ChangeProducer()
		{
			InitializeComponent();

		}

		public ChangeProducer(MainWindow rootElement, Producer ChangeCond = null)
		{
			this.ChangeCond = ChangeCond;
			this.rootElement = rootElement;
			InitializeComponent();
			ComponentInit();
		}
		private  void ComponentInit()
		{
			if (ChangeCond.Image.ByteArray != null)
			{
				image.Source = ChangeCond.Image.GetBitmapImage();
			}
			name_text.Text = ChangeCond.Name;

			name_text.Text = ChangeCond.Name.ToString();
			year_text.Text = ChangeCond.Info.BirthDate.Year.ToString();
		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListProducer(rootElement).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (!(name_text.Text == "" || name_text.Text.Length <= 1 ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year - 5))
			{
				ChangeCond.Name = name_text.Text;
				ChangeCond.Info.BirthDate = new DateTime(Convert.ToInt32(year_text.Text), ChangeCond.Info.BirthDate.Month, ChangeCond.Info.BirthDate.Day);
				rootElement.Content = new ListProducer(rootElement).Content;
			}
			else
			{

			}
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
