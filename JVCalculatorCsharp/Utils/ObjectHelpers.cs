namespace JVCalculatorCsharp.Utils;

public class ObjectHelpers
{
    //Get property value from string name
    public static object GetPropValue(object src, string propName)
    {
        return src.GetType().GetProperty(propName)!.GetValue(src, null)!;
    }
}
