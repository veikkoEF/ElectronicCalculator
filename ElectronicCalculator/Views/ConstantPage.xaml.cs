namespace ElectronicCalculator.Views;

public partial class ConstantPage : ContentPage
{
	public ConstantPage(ConstantViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
