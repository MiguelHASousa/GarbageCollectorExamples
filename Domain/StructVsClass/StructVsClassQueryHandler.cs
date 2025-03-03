using GarbageCollectorExamples.Models.ClassVsStruct;
using MediatR;
using System.Text;

namespace GarbageCollectorExamples.Domain.StructVsClass;

public sealed class StructVsClassQueryHandler : IRequestHandler<StructVsClassQuery, string>
{
    public Task<string> Handle(StructVsClassQuery request, CancellationToken cancellationToken)
    {
        const int totalInstances = 1_000_000;

        long memoryBeforeStruct = GC.GetTotalMemory(true);
        var structExampleArray = new StructExample[totalInstances];

        long memoryAfterStruct = GC.GetTotalMemory(true);

        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Struct - Memory Used: {memoryAfterStruct - memoryBeforeStruct} bytes");

        long memoryBeforeClass = GC.GetTotalMemory(true);
        var classExampleArray = new ClassExample[totalInstances];

        for (int i = 0; i < totalInstances; i++)
            classExampleArray[i] = new ClassExample();
        
        long memoryAfterClass = GC.GetTotalMemory(true);

        stringBuilder.AppendLine($"Class - Memory Used: {memoryAfterClass - memoryBeforeClass} bytes");

        return Task.FromResult(stringBuilder.ToString());
    }
}