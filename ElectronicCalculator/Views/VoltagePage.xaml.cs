namespace ElectronicCalculator.Views;

public partial class VoltagePage : ContentPage
{
	public VoltagePage(VoltageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
