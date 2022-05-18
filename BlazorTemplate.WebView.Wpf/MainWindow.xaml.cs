using BlazorTemplate.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BlazorTemplate.WebView.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
		public MainWindow()
		{
			var services = new ServiceCollection();
			services.AddWpfBlazorWebView();

			services.AddSingleton<WeatherForecastService>();

			Resources.Add("services", services.BuildServiceProvider());

			InitializeComponent();
		}
	}
}
