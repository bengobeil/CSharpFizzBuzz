using CSharpFizzBuzz.Workflows;

namespace CSharpFizzBuzz.IoC.Workflow
{
    public interface IWorkflowFactory<out TWorkflow, T> where TWorkflow : IWorkflow<T>
    {
        TWorkflow Create(string input);
    }
}