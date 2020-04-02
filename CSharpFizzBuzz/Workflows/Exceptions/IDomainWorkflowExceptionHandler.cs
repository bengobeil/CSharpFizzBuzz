using CSharpFizzBuzz.Workflows.Domain;

namespace CSharpFizzBuzz.Workflows.Exceptions
{
    public interface IDomainWorkflowExceptionHandler: IWorkflowExceptionHandler<IDomainWorkflow, string>
    {
        
    }
}