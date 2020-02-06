public abstract class Command
{
    protected Controller m_controller;

    public Command(Controller controller)
    {
        m_controller = controller;
    }

    public abstract void Execute();
}