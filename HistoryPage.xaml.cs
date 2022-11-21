using Calculator.ViewModels;

namespace Calculator;

public partial class HistoryPage : ContentPage
{
    public HistoryPage(HistoryViewModel h)
    {
        InitializeComponent();
        BindingContext = h;
    }
}