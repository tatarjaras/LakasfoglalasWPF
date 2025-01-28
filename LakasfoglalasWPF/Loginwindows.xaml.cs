﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace LakasfoglalasWPF
{
    /// <summary>
    /// Interaction logic for Loginwindows.xaml
    /// </summary>
    public partial class Loginwindows : Window
    {
        public HttpClient client;
        public Loginwindows()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var response = await client.PostAsync($"api/Login/GetSalt/{tbxLoginName.Text}",new StringContent(tbxLoginName.Text,Encoding.UTF8,"text/plain");
        }

        private void btnEsc_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
