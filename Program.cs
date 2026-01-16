// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

var handler = new HttpClientHandler
{
    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
};

using var https = new HttpClient(handler);

https.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("apiKey", "HucwZPgcHkXM9F1ktZKkM3i6kOoC.FJHoOdZzeXpTPCv.wr4M7O3kZKezd71i081hUrjU1V-E.KEWcZjR7Nmk1CzpuLTzKdDWCcebBiXEL8mJph0CWX6In2a");

// Test url
// var url = "https://www.dnd5eapi.co/api/2014/backgrounds";

var url = "http://76.190.138.96:8080";



var response = await https.GetAsync(url);

Console.WriteLine($"Status: {(int)response.StatusCode} {response.ReasonPhrase}");

var deserializedResponse = await System.Text.Json.JsonSerializer.DeserializeAsync<object>(await response.Content.ReadAsStreamAsync());

Console.WriteLine(deserializedResponse);

var content = await response.Content.ReadAsStringAsync();

Console.WriteLine(content);