using GarbageCollectorExamples.Domain.StructVsClass;
using GarbageCollectorExamples.Domain.StructVsClassBenchmark;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GarbageCollectorExamples.Controllers;

[ApiController]
[Route("[controller]")]
public class GarbageCollectorController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("StructVsClass")]
    public async Task<string> GetStructVsClass()
    {
        return await _mediator.Send(new StructVsClassQuery());
    }

    [HttpPost("StructVsClass/Benchmark")]
    public async Task GetStructVsClassBenchMark()
    {
        await _mediator.Send(new StructVsClassBenchmarkQuery());
    }
}
