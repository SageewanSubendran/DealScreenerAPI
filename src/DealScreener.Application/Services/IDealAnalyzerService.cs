using DealScreener.Domain.Models;

namespace DealScreener.Application.Services;

public interface IDealAnalyzerService
{
    DealResult Analyze(DealInput input);
}