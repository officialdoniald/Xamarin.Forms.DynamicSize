using System;

namespace Xamarin.Forms.DynamicSize.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            DynamicSizeCalculator.Init(899);
            Application.Current.Resources["testDoubleValue"] = DynamicSizeCalculator.GetDinamycNumber(Convert.ToDouble(Application.Current.Resources["testDoubleValue"]));
            Application.Current.Resources["testFloatValue"] = DynamicSizeCalculator.GetDinamycNumber(Convert.ToDouble(Application.Current.Resources["testFloatValue"]));
            Application.Current.Resources["testThicknessValue"] = DynamicSizeCalculator.GetDinamycNumber(Convert.ToDouble(Application.Current.Resources["testThicknessValue"]));
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
