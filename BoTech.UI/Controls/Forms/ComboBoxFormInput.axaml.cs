using Avalonia;
using Avalonia.Controls;

namespace BoTech.UI.Controls.Forms;

public class ComboBoxFormInput : FormInput
{
    
    /// <summary>
    /// The ctor will set the Default Value
    /// </summary>
    public static readonly StyledProperty<ComboBoxItem> ResultProperty =
        AvaloniaProperty.Register<ComboBoxFormInput, ComboBoxItem>(nameof(Result));

    /// <summary>
    /// Current selection
    /// </summary>
    public override dynamic Result
    {
        get => GetValue(ResultProperty); 
        set => SetValue(ResultProperty, value);
    }
    public static readonly StyledProperty<List<ComboBoxItem>> ItemsProperty =
        AvaloniaProperty.Register<ComboBoxFormInput, List<ComboBoxItem>>(nameof(Items));

    /// <summary>
    /// Items of the GroupBox
    /// </summary>
    public List<ComboBoxItem> Items
    {
        get => GetValue(ItemsProperty); 
        set => SetValue(ItemsProperty, value);
    } 
    /// <summary>
    /// Creates an combobox
    /// </summary>
    /// <param name="inputName"></param>
    /// <param name="helpText"></param>
    /// <param name="items"></param>
    /// <param name="defaultValue"></param>
    public ComboBoxFormInput(string inputName, string helpText,bool isRequired, List<ComboBoxItem> items, ComboBoxItem defaultValue) : base(inputName, helpText, isRequired)
    {
        Result = defaultValue;
        Items = items;
        _defaultValue = defaultValue;
        InfoText = "Please select.";
        UpdateInfoText();
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