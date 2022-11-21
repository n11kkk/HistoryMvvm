using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Calculator.ViewModels
{
    public partial class HistoryViewModel:ObservableObject
    {
        public HistoryViewModel()
        {
            Expr = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> expr;

        public static string exprString = "";

        [RelayCommand]
        public void AddExpr()
        {
            if (string.IsNullOrEmpty(exprString))
            {
                return;
            }
            Expr.Add($" ⟹ {exprString}");
        }
    }
}
