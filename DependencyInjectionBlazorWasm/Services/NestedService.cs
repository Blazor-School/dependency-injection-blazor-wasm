namespace DependencyInjectionBlazorWasm.Services
{
    public class NestedService
    {
        private readonly SimpleService _simpleService;

        public NestedService(SimpleService simpleService) => _simpleService = simpleService;

        public string ServePeople() => $"{_simpleService.Greeting("customer")}, how can I help?";
    }
}
