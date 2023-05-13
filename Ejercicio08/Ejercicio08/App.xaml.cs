using System;
using Ejercicio08.Services;
using Ejercicio08.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio08
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
          MainPage = new ExplicitControlDemo();
          //MainPage = new DynamicDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
