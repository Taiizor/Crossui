using Crossui.Core.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Crossui.WF
{
    /// <summary>
    /// MainPage.xaml etkileşim mantığı
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            ServiceCollection serviceCollection = new();

            serviceCollection.AddWpfBlazorWebView();

            serviceCollection.AddSingleton<WeatherForecastService>();

#if DEBUG
            serviceCollection.AddBlazorWebViewDeveloperTools();
#endif

            Resources.Add("services", serviceCollection.BuildServiceProvider());

            InitializeComponent();
        }
    }
}