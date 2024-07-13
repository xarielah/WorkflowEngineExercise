namespace WorkflowEngineExercise.WorkflowEngineClasses;

public interface IWorkflowTask
{
    void Execute();
}

public class NotifySubscribers : IWorkflowTask, INotificationService
{
    public void Notify()
    {
        Console.WriteLine("Notifying subscribers...");
    }

    public void Execute()
    {
        Notify();
    }
}