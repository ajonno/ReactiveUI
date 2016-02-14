using System.Windows;

namespace ReactiveUI_WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		// Since we're using the MVVM pattern, we're going to bind to our 
		// AppViewModel object in the code, and our View code-behind will be
		// concerned only with things that are solely view-based, like 
		// minimizing/maximizing a window
		public AppViewModel AppViewModel { get; private set; }

		public MainWindow()
		{
			AppViewModel = new AppViewModel();
			InitializeComponent();
		}
	}

}
