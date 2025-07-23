using Avalonia;

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
    public string Result { get => GetValue(ResultProperty); set => SetValue(ResultProperty, value); }
    /// <summary>
    /// The ctor will set the Default Value
    /// </summary>
    public static readonly StyledProperty<string> WatermarkProperty =
        AvaloniaProperty.Register<TextFormInput, string>(nameof(Watermark), defaultValue: "");
    /// <summary>
    /// Current selection
    /// </summary>
    public string Watermark { get => GetValue(WatermarkProperty); set => SetValue(WatermarkProperty, value); }
    public TextFormInput(string inputName, string helpText, string watermark) : base(inputName, helpText)
    {
        Watermark = watermark;
    }
}