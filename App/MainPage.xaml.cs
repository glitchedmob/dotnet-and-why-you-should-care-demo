using System.Web;
using Shared;

namespace App;

public partial class MainPage : ContentPage
{
    private static readonly Uri BaseUrl = new Uri("http://localhost:5113");

    private readonly HttpClient _client;

    public MainPage()
    {
        InitializeComponent();
        _client = new HttpClient();
        _client.BaseAddress = BaseUrl;
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        await SubmitReview();
    }

    private async void OnEntryCompleted(object sender, EventArgs e)
    {
        await SubmitReview();
    }

    private async Task SubmitReview()
    {
        var reviewText = ReviewEntry.Text;

        if (string.IsNullOrWhiteSpace(reviewText))
        {
            return;
        }

        var urlSafeReviewText = HttpUtility.UrlEncode(reviewText);

        using var res = await _client.GetAsync($"/sentiment?review={urlSafeReviewText}");
        var json = await res.Content.ReadAsStringAsync();

        var result = SentimentResult.FromJson(json);

        if (result == null)
        {
            return;
        }

        ReviewEntry.Text = "";

        await DisplayAlert("Result", result.FormatForDisplay(), "OK");
    }
}
