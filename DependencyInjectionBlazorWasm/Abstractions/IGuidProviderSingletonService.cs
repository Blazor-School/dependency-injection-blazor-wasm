using System;

namespace DependencyInjectionBlazorWasm.Abstractions
{
    public interface IGuidProviderSingletonService
    {
        Guid Guid { get; }
    }
}
