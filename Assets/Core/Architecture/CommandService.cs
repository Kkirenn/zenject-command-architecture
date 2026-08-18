
public class CommandService
{    public void Execute(ICommand command)
    {
        command?.Execute();
    }
}
