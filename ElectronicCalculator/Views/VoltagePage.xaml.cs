namespace ElectronicCalculator.Views;

public partial class VoltagePage : ContentPage
{
	private VoltageViewModel _viewModel;
    public VoltagePage(VoltageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel= viewModel;
		BindingContext = viewModel;

	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (RadioButtonR2.IsChecked)
		{
			EntryR2.IsReadOnly = true;
			EntryVoltage.IsReadOnly = false;
            _viewModel.VoltageMode = false;
        }
		else
		{
			EntryR2.IsReadOnly = false;
            EntryVoltage.IsReadOnly = true;
			_viewModel.VoltageMode = true;
        }
    }
}
