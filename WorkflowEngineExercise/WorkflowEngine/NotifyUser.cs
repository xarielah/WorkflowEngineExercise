namespace WorkflowEngineExercise.WorkflowEngineClasses;

public class NotifyUser : IWorkflowTask, INotificationService
{
    public void Notify()
    {
        Console.WriteLine("Notifying user...");
    }

    public void Execute()
    {
        Notify();
    }
}