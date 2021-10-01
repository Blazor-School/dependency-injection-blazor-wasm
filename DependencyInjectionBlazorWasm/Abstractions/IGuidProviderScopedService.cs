using System;

namespace DependencyInjectionBlazorWasm.Abstractions
{
    public interface IGuidProviderScopedService
    {
        Guid Guid { get; }
    }
}
