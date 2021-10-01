using System;

namespace DependencyInjectionBlazorWasm.Abstractions
{
    public interface IGuidProviderTransientService
    {
        Guid Guid { get; }
    }
}
