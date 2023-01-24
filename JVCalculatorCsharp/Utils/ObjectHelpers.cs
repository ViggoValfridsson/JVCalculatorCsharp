namespace JVCalculatorCsharp.Utils;
public class ObjectHelpers
{
    public static object GetPropValue(object src, string propName)
    {
        return src.GetType().GetProperty(propName)!.GetValue(src, null)!;
    }
}
