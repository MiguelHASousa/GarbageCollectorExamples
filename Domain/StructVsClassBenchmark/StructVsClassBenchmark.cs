using BenchmarkDotNet.Attributes;
using GarbageCollectorExamples.Models.ClassVsStruct;

namespace GarbageCollectorExamples.Domain.StructVsClassBenchmark;

[MemoryDiagnoser]
public class StructVsClassBenchmark
{
    private const int TotalInstancias = 10;

    [Benchmark]
    public StructExample[] CreateStructs()
    {
        return new StructExample[TotalInstancias];
    }

    [Benchmark]
    public ClassExample[] CreateClasses()
    {
        var array = new ClassExample[TotalInstancias];
        for (int i = 0; i < TotalInstancias; i++)
        {
            array[i] = new ClassExample();
        }
        return array;
    }
}