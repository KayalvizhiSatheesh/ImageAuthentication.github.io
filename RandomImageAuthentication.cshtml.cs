using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageAuthenticationSystem.Pages;

public class RandomImageAuthentication : PageModel
{
    private readonly ILogger<RandomImageAuthentication> _logger;

    public RandomImageAuthentication(ILogger<RandomImageAuthentication> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

