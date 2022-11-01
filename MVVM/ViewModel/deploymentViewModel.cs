namespace TEPSClientManagementConsole_V1.MVVM.ViewModel
{
    internal class deploymentViewModel
    {
    }
}

public class deploymentInfo
{
    public string clientName { get; set; }
    public string currentlyRunning { get; set; }
    public int currentNumber { get; set; }
    public int totalNumber { get; set; }
    public bool errorsFound { get; set; }
}