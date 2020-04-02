using CSharpFizzBuzz.Workflows.Domain;

namespace CSharpFizzBuzz.Workflows.Exceptions
{
    public class DomainWorkflowExceptionHandler : IDomainWorkflowExceptionHandler
    {
        public string Handle(IDomainWorkflow workflow)
        {
            try
            {
                return workflow.Execute();
            }
            catch (NotANumberException e)
            {
                return $"{e.Input} is not a valid integer.";
            }
            catch (InvalidNumberException e)
            {
                return $"You entered {e.ParsedInt}. Please enter a number between 1 and 4000.";
            }
        }
    }
}