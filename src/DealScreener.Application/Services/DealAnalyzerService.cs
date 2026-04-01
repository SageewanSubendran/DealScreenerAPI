using DealScreener.Domain.Models;

namespace DealScreener.Application.Services;

public class DealAnalyzerService : IDealAnalyzerService
{
    public DealResult Analyze(DealInput input)
    {
        return new DealResult
        {
            MonthlyCashFlow = 1000 // temp test value
        };
    }
}