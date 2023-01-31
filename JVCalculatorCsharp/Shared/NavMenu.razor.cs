namespace JVCalculatorCsharp.Shared;

public partial class NavMenu
{
    public bool isHidden { get; set; } = true;

    public void OpenMenu()
    {
        if (isHidden)
        {
            isHidden = false;
        }
        else
        {
            isHidden = true;
        }
    }
}
