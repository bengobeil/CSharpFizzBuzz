using CSharpFizzBuzz.IO;
using CSharpFizzBuzz.IoC.Domain;
using CSharpFizzBuzz.IoC.Workflow.Domain;
using CSharpFizzBuzz.Workflows.Exceptions;

namespace CSharpFizzBuzz.IoC.Application
{
    public class ApplicationFactory
    {
        public CSharpFizzBuzz.Application Create(IInput input, IOutput output)
        {
            var domainFactory = new DomainFactory();
            var domainWorkflowFactory = new DomainWorkflowFactory(domainFactory);
            var domainWorkflowExceptionHandler = new DomainWorkflowExceptionHandler();
            return new CSharpFizzBuzz.Application(domainWorkflowFactory, domainWorkflowExceptionHandler, input, output);
        }
    }
}