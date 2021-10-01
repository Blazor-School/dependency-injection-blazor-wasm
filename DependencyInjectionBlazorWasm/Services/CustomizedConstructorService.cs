namespace DependencyInjectionBlazorWasm.Services
{
    public class CustomizedConstructorService
    {
        private readonly string _resourceLocation;
        private readonly SimpleService _simpleService;

        public CustomizedConstructorService(string resourceLocation, SimpleService simpleService)
        {
            _resourceLocation = resourceLocation;
            _simpleService = simpleService;
        }

        public string TellResourceLocation() => $"The resource location is {_resourceLocation}. {_simpleService.Greeting("Blazor School")}";
    }
}