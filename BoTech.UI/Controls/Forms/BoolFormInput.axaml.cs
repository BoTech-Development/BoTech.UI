using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace BoTech.UI.Controls.Forms;

public class BoolFormInput : FormInput
{
    /// <summary>
    /// The ctor will set the Default Value
    /// </summary>
    public static readonly StyledProperty<bool> ResultProperty =
        AvaloniaProperty.Register<BoolFormInput, bool>(nameof(Result), defaultValue: false);
    /// <summary>
    /// Current selection
    /// </summary>
    public override dynamic Result { get => GetValue(ResultProperty); set => SetValue(ResultProperty, value); }
    
    public BoolFormInput(string inputName, string helpText, bool isRequired, bool defaultValue) : base(inputName, helpText, isRequired)
    {
        Result = defaultValue;
    }
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);

        // if the changed property is the ResultProperty, we need to update the Icon and the color etc.
        if (change.Property == ResultProperty) 
        {
            UpdateInfoText();
        }
    }

}