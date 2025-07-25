using Avalonia.Controls;

namespace BoTech.UI.Controls.Forms;

public interface IFormInput
{
    public string InputName { get; set; }
    public string HelpText { get; set; }
}