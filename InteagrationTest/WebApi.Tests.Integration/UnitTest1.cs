using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace WebApi.Tests.Integration;

public class UnitTest1 : IClassFixture<WebApplicationFactory<IApiMarker>>
{
    private readonly HttpClient _httpClient;
    public UnitTest1(WebApplicationFactory<IApiMarker> appFactory) 
    {
        _httpClient = appFactory.CreateClient();
    }
    [Fact]
    public async Task GetAll()
    {
        var response = await _httpClient.GetAsync("http://localhost:5176/api/Products/GetAll");

        response.StatusCode.Should().Be(HttpStatusCode.OK);        
    }

    [Fact]
    public async Task Get()
    {
        var response = await _httpClient.GetAsync("http://localhost:5176/api/Products/Get");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}