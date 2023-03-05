namespace ElectronicCalculator.ViewModels;

public partial class VoltageViewModel : BaseViewModel
{
    [ObservableProperty]
    private double voltage;

    [ObservableProperty]
    private double resistor1 = 240;

    [ObservableProperty]
    private double resistor2;

    [ObservableProperty]
    private bool voltageMode = true;

    [RelayCommand]
    private void Calculate()
    {
        if (voltageMode)
        {
            Voltage = 1.25 * (1 + Resistor2 / Resistor1);
        }
        else
        {
            Resistor2 = Resistor1 * (Voltage / 1.25 - 1);
        }
    }


    }
