using DealScreener.Application.Services;
using DealScreener.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DealScreener.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DealsController : ControllerBase
{
    private readonly IDealAnalyzerService _dealService;

    public DealsController(IDealAnalyzerService dealService)
    {
        _dealService = dealService;
    }

    [HttpPost("analyze")]
    public IActionResult Analyze([FromBody] DealInput input)
    {
        var result = _dealService.Analyze(input);
        return Ok(result);
    }
}