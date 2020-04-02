using CSharpFizzBuzz.IoC.Domain;
using CSharpFizzBuzz.Workflows;
using CSharpFizzBuzz.Workflows.Domain;

namespace CSharpFizzBuzz.IoC.Workflow.Domain
{
    public class DomainWorkflowFactory : IDomainWorkflowFactory
    {
        private readonly DomainFactory _domainFactory;

        public DomainWorkflowFactory(DomainFactory domainFactory)
        {
            _domainFactory = domainFactory;
        }
        
        public IDomainWorkflow Create(string input)
        {
            var domain = _domainFactory.Create();
            return new DomainWorkflow(domain, input);    
        }
    }
}