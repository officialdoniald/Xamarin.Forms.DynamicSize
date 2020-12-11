# Xamarin.Forms.DynamicSize
What and when should this package be used?
If you’re making a design plan and you only made it to one size and you gave everything a fixed size, so this little package is for you. This can dynamically increase the size no matter what resolution device you are running on. You don’t have to worry that it will look different on every display, it will look the same on each one.

0. Create some design for example in Figma.

1. You need to call the Init function of the DynamicSizeCalculator class. This will set a static double value.

DynamicSizeCalculator.Init(899); //899 The number you used in the design as the phone size.

2. Create some value in the App.xaml - Application Resource.

<?xml version="1.0" encoding="utf-8" ?>
<Application xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="Xamarin.Forms.DynamicSize.Mobile.App">
    <Application.Resources>
        <x:Double x:Key="testDoubleValue">50.0</x:Double>
        <x:Single x:Key="testFloatValue">2.0</x:Single>
        <Thickness x:Key="testThicknessValue">50.0</Thickness>
    </Application.Resources>
</Application>

3. Call the dynamic size calculator function:

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
