using Avalonia;
using Avalonia.Controls;

namespace BoTech.UI.Controls.Forms;

public class NumberFormInput : FormInput
{
    private NumericUpDownConfiguration _conf;
    public static readonly StyledProperty<decimal> IncrementProperty =
        AvaloniaProperty.Register<NumberFormInput, decimal>(nameof(Increment), defaultValue: 0);
    
    public decimal Increment
    {
        get => GetValue(IncrementProperty);
        set => SetValue(IncrementProperty, value);
    }
    public static readonly StyledProperty<decimal> MinimumProperty =
        AvaloniaProperty.Register<NumberFormInput, decimal>(nameof(Minimum), defaultValue: 0);
    
    public decimal Minimum
    {
        get => GetValue(MinimumProperty);
        set => SetValue(MinimumProperty, value);
    }
    public static readonly StyledProperty<decimal> MaximumProperty =
        AvaloniaProperty.Register<NumberFormInput, decimal>(nameof(Maximum), defaultValue: 0);
    
    public decimal Maximum
    {
        get => GetValue(MaximumProperty);
        set => SetValue(MaximumProperty, value);
    }
    public static readonly StyledProperty<string> FormatStringProperty =
        AvaloniaProperty.Register<NumberFormInput, string>(nameof(FormatString), defaultValue: "");
    
    public string FormatString
    {
        get => GetValue(FormatStringProperty);
        set => SetValue(FormatStringProperty, value);
    }
    /// <summary>
    /// The ctor will set the Default Value
    /// </summary>
    public static readonly StyledProperty<decimal> ResultProperty =
        AvaloniaProperty.Register<NumberFormInput, decimal>(nameof(Result), defaultValue: 0);

    /// <summary>
    /// Current selection
    /// </summary>
    public decimal Result
    {
        get => GetValue(ResultProperty); 
        set => SetValue(ResultProperty, value);
    }
    
    public NumberFormInput(string inputName, string helpText, NumericUpDownConfiguration configuration) : base(inputName, helpText)
    {
        Result = configuration.Value;
        _conf = configuration;
    }
    /// <summary>
    /// Configuration of the NumericUpDown Control
    /// </summary>
    public class NumericUpDownConfiguration
    {

        /// <summary>
        /// The default Value
        /// </summary>
        public decimal Value { get; set; }
        public decimal Increment { get; set; }
        public decimal Minimum { get; set; }
        public decimal Maximum { get; set; }
        public string FormatString { get; set; }
    
    }
}
