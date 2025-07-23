using Avalonia;
using Avalonia.Controls;

namespace BoTech.UI.Controls.Forms;

public class FormInput : ContentControl
{
    public static readonly StyledProperty<string> InputNameProperty =
        AvaloniaProperty.Register<FormInput, string>(nameof(InputName));
    /// <summary>
    /// The displayed name of this Input
    /// </summary>
    public string InputName { get => GetValue(InputNameProperty); set => SetValue(InputNameProperty, value); }
    
    public static readonly StyledProperty<string> HelpTextProperty =
        AvaloniaProperty.Register<FormInput, string>(nameof(HelpText));
    /// <summary>
    /// Text that appears when the user clicks on the Help Button.
    /// </summary>
    public string HelpText { get => GetValue(HelpTextProperty); set =>  SetValue(HelpTextProperty, value); }

    public FormInput(string inputName, string helpText)
    {
        InputName = inputName;
        HelpText = helpText;
    }

    
}
