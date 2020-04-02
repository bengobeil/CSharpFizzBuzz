using CSharpFizzBuzz.IO;
using CSharpFizzBuzz.IoC.Domain;
using CSharpFizzBuzz.IoC.Workflow.Domain;
using CSharpFizzBuzz.Workflows.Exceptions;

namespace CSharpFizzBuzz
{
    public class Application
    {
        private readonly IDomainWorkflowFactory _workflowFactory;
        private readonly IInput _input;
        private readonly IOutput _output;
        private readonly IDomainWorkflowExceptionHandler _exceptionHandler;

        public Application(IDomainWorkflowFactory workflowFactory, IDomainWorkflowExceptionHandler exceptionHandler, IInput input, IOutput output)
        {
            _workflowFactory = workflowFactory;
            _input = input;
            _output = output;
            _exceptionHandler = exceptionHandler;
        }

        public void Execute()
        {
            _output.Set("Enter a number between 1 and 4000: ");
            var input = _input.Get();
            var workflow = _workflowFactory.Create(input);
            var result = _exceptionHandler.Handle(workflow);
            _output.Set(result);
        }
    }
}