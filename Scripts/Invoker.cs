public class Invoker 
{
    private Command m_command;

    public void SetCommand(Command command)
    {
        m_command = command;
    }

    public void ExecuteCommand()
    {
        m_command.Execute();
    }
}
