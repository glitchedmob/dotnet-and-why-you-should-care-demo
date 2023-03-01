using Newtonsoft.Json;

namespace Shared;

public class SentimentResult
{
    public static SentimentResult? FromJson(string json)
    {
        return JsonConvert.DeserializeObject<SentimentResult>(json);
    }

    public bool IsPositive { get; set; }
    public float Accuracy { get; set; }

    public string FormatForDisplay()
    {
        var sentiment = IsPositive ? "Positive" : "Negative";

        if (Accuracy >= 0.85)
        {
            return $"Definitely {sentiment}";
        }

        if (Accuracy >= 0.70)
        {
            return $"Likely {sentiment}";
        }

        if (Accuracy >= 0.50)
        {
            return $"Possibly {sentiment}";
        }

        return $"{sentiment}, but unsure";
    }
}
