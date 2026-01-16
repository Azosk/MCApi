namespace MCApi.Infrustracture;

// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;


class ApiService
{
    HttpClient http = new HttpClient();

    public ApiService( HttpClientHandler handler, string apiKey)
    {
        using var http = new HttpClient(handler);

        handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };

        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Z80iesHEvIs-Mz4oDBrM4jK-8.5vl5WuhE.T9GaXbKumpluqvsU-VtOescWLpuT6epC5AooPHukZHwypxCnDJwuqhm0ckM1wx8ZXfKyoRCBvNISoFG0MtfqN");

    }
}


