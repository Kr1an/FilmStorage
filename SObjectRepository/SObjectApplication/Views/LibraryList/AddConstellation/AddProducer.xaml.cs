﻿using System;
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
using Microsoft.Win32;

namespace SObjectApplication.Views.LibraryList.AddProducer
{
	/// <summary>
	/// Interaction logic for AddConstillation.xaml
	/// </summary>
	public partial class AddConstillation : Window
	{
		public MainWindow rootElement;
		public ImageHelper ImageHelper;
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
			rootElement.Content = new ListProducer(rootElement).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if(!(name_text.Text == "" || name_text.Text.Length <= 1 ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year-5))
			{
				Producer tmpProducer = new Producer() { Name = name_text.Text, Info = new InfoHuman() { BirthDate = new DateTime(Convert.ToInt32(year_text.Text), 1, 1) } };
				if (this.ImageHelper != null)
					tmpProducer.Image = this.ImageHelper;
				FilmStorage.Producers.Add(tmpProducer);
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
				this.ImageHelper = new ImageHelper();
				this.ImageHelper.ChangePicture(openFileDialog.FileName);
				image.Source = this.ImageHelper.GetBitmapImage();
			}
		}
	}
}
