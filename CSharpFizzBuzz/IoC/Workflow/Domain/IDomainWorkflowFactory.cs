using CSharpFizzBuzz.Workflows.Domain;

namespace CSharpFizzBuzz.IoC.Workflow.Domain
{
    public interface IDomainWorkflowFactory : IWorkflowFactory<IDomainWorkflow, string>
    {
    }
}