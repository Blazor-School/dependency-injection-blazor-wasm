using DependencyInjectionBlazorWasm.Abstractions;

namespace DependencyInjectionBlazorWasm.Services
{
    public class MutipleConstructorsService : IFirstConstructor, ISecondConstructor
    {
        public string ServiceDetail { get; }

        public MutipleConstructorsService(SimpleService simpleService) => ServiceDetail = "Constructed with first constructor";

        public MutipleConstructorsService(NestedService nestedService) => ServiceDetail = "Constructed with second constructor";
    }
}
