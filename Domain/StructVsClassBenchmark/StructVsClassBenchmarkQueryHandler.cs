using BenchmarkDotNet.Running;
using MediatR;

namespace GarbageCollectorExamples.Domain.StructVsClassBenchmark;

public sealed class StructVsClassBenchmarkQueryHandler : IRequestHandler<StructVsClassBenchmarkQuery>
{
    public Task Handle(StructVsClassBenchmarkQuery request, CancellationToken cancellationToken)
    {
        var summary = BenchmarkRunner.Run<StructVsClassBenchmark>();

        return Task.CompletedTask;
    }
}