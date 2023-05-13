using System;
using System.Collections.Generic;
using System.ComponentModel;
using Ejercicio08.Models;
using Ejercicio08.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio08.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}