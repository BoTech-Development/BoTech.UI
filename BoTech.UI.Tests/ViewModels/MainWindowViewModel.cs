using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;
using BoTech.UI.Controls;
using BoTech.UI.Controls.Forms;
using ReactiveUI;

namespace BoTech.UI.Tests.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    public Control RequiredInput { get; set; }
    public Control OptionalInput { get; set; }
    public Control NumberInput { get; set; }
    public Control ComboInput { get; set; }
    public Control BoolInput { get; set; }
    public MainWindowViewModel()
    {
        RequiredInput = new TextFormInput("Is BoTech.DesignerForAvalonia a cool project? ", "Of course it is a cool project",  true,"");
        OptionalInput = new TextFormInput("Some Text input:", "Enter something", false,"");
        NumberInput = new NumberFormInput("Number Input:", "Enter something", true, new NumberFormInput.NumericUpDownConfiguration()
        {
            FormatString = "0.00",
            Minimum = 0,
            Maximum = 1,
            Increment = (decimal)0.01,
            Value = (decimal)0.5,
        });
        ComboInput = new ComboBoxFormInput("Combo Input:", "Enter something", true, new List<ComboBoxItem>()
        {
            new ComboBoxItem() { Content = "Option1" },
            new ComboBoxItem() { Content = "Option2" },
            new ComboBoxItem() { Content = "Option3" }    
        }, new ComboBoxItem() { Content = "Option1" });
        BoolInput = new BoolFormInput("Bool Input:", "Enter something", true, false);
    }
}