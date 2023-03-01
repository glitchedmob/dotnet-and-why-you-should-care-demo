using Microsoft.AspNetCore.Mvc;
using SentimentModel;
using Shared;

namespace Api.Controllers;

[ApiController]
[Route("/sentiment")]
public class SentimentController
{
    [HttpGet]
    public SentimentResult Get([FromQuery] string review)
    {
        var modelInput = new Model.ModelInput
        {
            Col0 = review,
        };

        var score = Model.PredictAllLabels(modelInput).First();

        var result =  new SentimentResult
        {
            IsPositive = score.Key == "1",
            Accuracy = score.Value,
        };

        Console.WriteLine(result.FormatForDisplay());

        return result;
    }
}
