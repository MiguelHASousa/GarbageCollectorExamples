using MediatR;

namespace GarbageCollectorExamples.Domain.StructVsClass;

public struct StructVsClassQuery : IRequest<string>
{
}