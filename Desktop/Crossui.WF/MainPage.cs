using Crossui.Library;
using Crossui.Library.Data;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace Crossui.WF
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            ServiceCollection services = new();

            services.AddWindowsFormsBlazorWebView();

            services.AddSingleton<WeatherForecastService>();

#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Main>("#app");
        }
    }
}