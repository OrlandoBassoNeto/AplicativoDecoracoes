﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDecoracao
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ImgbuttonLogo_Clicked(object sender, EventArgs e)
        {
            NavigationPage Detail = new NavigationPage(new CadastroUsuarios());
        }

        //private void ImgbuttonUsuario_Clicked(object sender, EventArgs e)
        //{
        //  NavigationPage  Detail = new NavigationPage(new CadastroUsuarios());
        //}
    }
}
