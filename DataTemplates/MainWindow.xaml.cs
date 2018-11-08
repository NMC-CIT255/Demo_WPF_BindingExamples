﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new Person { Name = "John", Age = 60 };

            _list.ItemsSource = new ObservableCollection<Person>
            {
                new Person { Name = "John", Age = 60 },
                new Person { Name = "Amy", Age = 58 },
                new Person { Name = "Emma", Age = 23 },
                new Person { Name = "Charlie", Age = 21 }
            };
        }
    }
}
