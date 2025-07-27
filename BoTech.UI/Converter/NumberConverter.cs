using System.Globalization;
using Avalonia.Data.Converters;

namespace BoTech.UI.Converter;

public class NumberConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (IsNumeric(value))
        {
            if (parameter is string param)
            {
                string[] elements = param.Split(",");
                if (elements.Length == 2)
                {
                    string operation =  elements[0];
                    dynamic number = elements[1];
                    switch (operation)
                    {
                        case "add":
                            return value + number;
                        case "sub":
                            return value - number;
                        case "mult":
                            return value * number;
                        case "div":
                            return value / number;
                    }
                }
            }
        }
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
    public static bool IsNumeric(object? obj)
    {
        if (obj == null) return false;

        var type = obj.GetType();
        return type == typeof(byte) || type == typeof(sbyte) ||
               type == typeof(short) || type == typeof(ushort) ||
               type == typeof(int) || type == typeof(uint) ||
               type == typeof(long) || type == typeof(ulong) ||
               type == typeof(float) || type == typeof(double) ||
               type == typeof(decimal);
    }
}