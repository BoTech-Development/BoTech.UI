using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Material.Icons;

namespace BoTech.UI.Controls.Forms;

public abstract class FormInput : ContentControl, IFormInput
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
    public static readonly StyledProperty<bool> IsRequiredProperty =
        AvaloniaProperty.Register<FormInput, bool>(nameof(HelpText));
    /// <summary>
    /// When true, the box will appear red when the User does not enter something else the box will be colored blue
    /// </summary>
    public bool IsRequired { get => GetValue(IsRequiredProperty); set =>  SetValue(IsRequiredProperty, value); }
    /// <summary>
    /// Result of the input
    /// </summary>
    public abstract dynamic Result { get; set; }
    
    public static readonly StyledProperty<bool> IsInfoVisibleProperty =
        AvaloniaProperty.Register<FormInput, bool>(nameof(IsInfoVisible));
    /// <summary>
    /// When true, the Info text is visible
    /// </summary>
    public bool IsInfoVisible
    {
        get =>  GetValue(IsInfoVisibleProperty); 
        set =>  SetValue(IsInfoVisibleProperty, value);
    }
    public static readonly StyledProperty<string> InfoTextProperty =
        AvaloniaProperty.Register<FormInput, string>(nameof(InfoText));
    /// <summary>
    /// The Text is visible above the input block 
    /// </summary>
    public string InfoText
    {
        get => GetValue(InfoTextProperty); 
        set =>  SetValue(InfoTextProperty, value);
    }
    
    public static readonly StyledProperty<IBrush> InputBoxBrushProperty =
        AvaloniaProperty.Register<FormInput, IBrush>(nameof(InputBoxBrush));
    /// <summary>
    /// The color of the input box
    /// </summary>
    public IBrush InputBoxBrush
    {
        get =>  GetValue(InputBoxBrushProperty); 
        set =>  SetValue(InputBoxBrushProperty, value);
    }
    public static readonly StyledProperty<MaterialIconKind> IconNextToTheInputBoxProperty =
        AvaloniaProperty.Register<FormInput, MaterialIconKind>(nameof(InputBoxBrush));
    public MaterialIconKind IconNextToTheInputBox
    {
        get => GetValue(IconNextToTheInputBoxProperty);
        set => SetValue(IconNextToTheInputBoxProperty, value);
    }

    public FormInput(string inputName, string helpText, bool isRequired)
    {
      
        IsRequired = isRequired;
        InputName = inputName;
        if(IsRequired)
             InputName += "*";
        HelpText = helpText;
        UpdateInfoText();
    }
  
    internal void UpdateInfoText()
    {
        if (IsRequired)
        {
            if (Result == null || string.IsNullOrEmpty(Result))
            {
                InputBoxBrush = Brushes.Red;
                InfoText = "You must enter sth.";
                IsInfoVisible = true;
                IconNextToTheInputBox = MaterialIconKind.AlertCircle;
            }
            else
            {
                IconNextToTheInputBox = MaterialIconKind.Check;
                InputBoxBrush = Brushes.Green;
                IsInfoVisible = false;
            }
        }
        else
        {
            if (Result == null || string.IsNullOrEmpty(Result))
            {
                InputBoxBrush = Brushes.Blue;
                IconNextToTheInputBox = MaterialIconKind.ButtonPointer;
            }
            else
            {
                IconNextToTheInputBox = MaterialIconKind.Check;
                InputBoxBrush = Brushes.Green;
                IsInfoVisible = false;
            }
        }
    }
    // AlertCircle, Check
}
