namespace ElectronicCalculator.Views;

public partial class InfoPage : ContentPage
{
	public InfoPage(InfoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
