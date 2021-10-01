using DependencyInjectionBlazorWasm.Abstractions;
using System;

namespace DependencyInjectionBlazorWasm.Services
{
    public class GuidProviderService : IGuidProviderScopedService, IGuidProviderTransientService, IGuidProviderSingletonService
    {
        public Guid Guid { get; } = Guid.NewGuid();
    }
}
