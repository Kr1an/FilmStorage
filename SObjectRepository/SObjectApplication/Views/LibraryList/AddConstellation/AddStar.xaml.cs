﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
using SObjectApplication.Views.LibraryList;
using SObjectApplication.Repository.SObjectModel;
using SObjectApplication.Repository.SObjectModel.Utils;

namespace SObjectApplication.Views.LibraryList.AddConstellation
{
	/// <summary>
	/// Interaction logic for AddStar.xaml
	/// </summary>
	public partial class AddStar : Window
	{
		private MainWindow rootElement;
		private Producer ParentConstellation;
		public AddStar()
		{
			InitializeComponent();
		}
		public AddStar(MainWindow rootElement, Producer ParentConstellation = null)
		{
			this.rootElement = rootElement;
			this.ParentConstellation = ParentConstellation;
			InitializeComponent();
			ComponentInit();

		}
		private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
		{
			rootElement.Content = new ListStar(rootElement, ParentConstellation).Content;
		}
		private void imgNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (!(name_text.Text == "" || name_text.Text.Length <= 1 ||
				Convert.ToInt32(year_text.Text) < 1900 || Convert.ToInt32(year_text.Text) > DateTime.Now.Year))
			{
				Film tmpFilm = new Film()
				{
					Producer = ParentConstellation,
					Name = name_text.Text,
					Info =
						new InfoFilm()
						{
							Genre = (int) c_slider.Value,
							ProductionDate = new DateTime(Convert.ToInt32(year_text.Text), 1, 1)
						}
				};
				FilmStorage.Films.Add(tmpFilm);
				ParentConstellation.Films.Add(tmpFilm);
				rootElement.Content = new ListStar(rootElement, ParentConstellation).Content;
			}
			else
			{

			}
		}

		public void ComponentInit()
		{
			c_slider.Value = 2;
		}
		public void c_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (GenreText != null)
				GenreText.Text = Genres.GenreById((int)c_slider.Value);
		}
	}
}