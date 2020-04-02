namespace CSharpFizzBuzz.Workflows.Domain
{
    public class DomainWorkflow : IDomainWorkflow
    {
        private readonly CSharpFizzBuzz.Domain _domain;
        private readonly string _input;

        public DomainWorkflow(CSharpFizzBuzz.Domain domain, string input)
        {
            _domain = domain;
            _input = input;
        }
        
        public string Execute()
        {
            var execute = _domain.Execute(_input);
            return $"Here is the output:\n{execute}";
        }
    }
}