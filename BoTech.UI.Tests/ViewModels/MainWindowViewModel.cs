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
    public MainWindowViewModel()
    {
        RequiredInput = new TextFormInput("Is BoTech.DesignerForAvalonia a cool project? ", "Of course it is a cool project",  true,null);
        OptionalInput = new TextFormInput("Some Text input:", "Enter something", false,null);
    }
}