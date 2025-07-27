using Avalonia;
using Avalonia.Controls.Documents;

namespace BoTech.UI.Controls.Forms;

public class TextFormInput : FormInput
{
    /// <summary>
    /// The ctor will set the Default Value
    /// </summary>
    public static readonly StyledProperty<string> ResultProperty =
        AvaloniaProperty.Register<TextFormInput, string>(nameof(Result), defaultValue: "");

    /// <summary>
    /// Current selection
    /// </summary>
    public override dynamic Result
    {
        get => GetValue(ResultProperty);
        set => SetValue(ResultProperty, value);
    }

    /// <summary>
    /// The ctor will set the Default Value
    /// </summary>
    public static readonly StyledProperty<string> WatermarkProperty =
        AvaloniaProperty.Register<TextFormInput, string>(nameof(Watermark), defaultValue: "");
    /// <summary>
    /// Current selection
    /// </summary>
    public string Watermark { get => GetValue(WatermarkProperty); set => SetValue(WatermarkProperty, value); }
    public TextFormInput(string inputName, string helpText, bool isRequired, string watermark) : base(inputName, helpText, isRequired)
    {
        Watermark = watermark;
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