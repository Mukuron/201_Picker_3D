public class OnLevelDestroyCommand : ICommand
{
    private trandsform _levelHolder;

    public OnLevelDestroyCommand(Transform levelHolder)
    {
        _levelHolder = levelHolder;
    }

    public void Execute()
    {
        Object.Destroy(_levelHolder.GetChild(0).gameObject);
    }

    public void Execute(int value)
}
