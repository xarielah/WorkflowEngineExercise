namespace WorkflowEngineExercise.WorkflowEngineClasses;

public class WorkflowEngine
{
    private readonly IList<IWorkflowTask> _workflowActivities;

    public WorkflowEngine()
    {
        _workflowActivities = new List<IWorkflowTask>();
    }

    public void Run()
    {
        foreach (var activity in _workflowActivities)
        {
            activity.Execute();
        }
    }

    public void AppendTask(IWorkflowTask task)
    {
        _workflowActivities.Add(task);
    }
}
