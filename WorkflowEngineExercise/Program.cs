using WorkflowEngineExercise.WorkflowEngineClasses;
namespace WorkflowEngineExercise;

public class Program
{
    public static void Main()
    {
        var we = new WorkflowEngine();
        we.AppendTask(new UploadVideo());
        we.AppendTask(new EncodeVideo());
        we.AppendTask(new NotifyUser());
        we.AppendTask(new NotifySubscribers());
        we.Run();
    }
}