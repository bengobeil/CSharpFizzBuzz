namespace CSharpFizzBuzz.Workflows.Exceptions
{
    public interface IWorkflowExceptionHandler<TWorkflow, out T> where TWorkflow : IWorkflow<T>
    {
        T Handle(TWorkflow workflow);
    }
}