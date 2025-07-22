using Avalonia.Controls;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;
using BoTech.UI.Controls;
using ReactiveUI;

namespace BoTech.UI.Tests.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
 
    public Control TestGroupBox { get; set; }

    public MainWindowViewModel()
    {
        TestGroupBox = new GroupBox()
        {
            Header = "My Header",
            Content = new StackPanel()
            {
                Children =
                {
                    new Button()
                    {
                        Content = "Press me",
                    },
                    new TextBox()
                    {
                        Watermark = "Enter sth."
                    }
                }
            }
        };
    }
  
}