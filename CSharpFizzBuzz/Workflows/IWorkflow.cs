namespace CSharpFizzBuzz.Workflows
{
    public interface IWorkflow<out T>
    {
        T Execute();
    }
}