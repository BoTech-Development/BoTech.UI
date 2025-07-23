using Avalonia.Controls;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;
using BoTech.UI.Controls;
using BoTech.UI.Controls.Forms;
using ReactiveUI;

namespace BoTech.UI.Tests.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    public Control TestControl { get; set; }
    public MainWindowViewModel()
    {
        TestControl =  new BoolFormInput("Is BoTech.DesignerForAvalonia a cool project? ", "Of course it is a cool project", true);
    }
}