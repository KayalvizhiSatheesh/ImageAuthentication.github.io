using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageAuthenticationSystem.Pages;

public class RandomImageSelection : PageModel
{
    private readonly ILogger<RandomImageSelection> _logger;

    public RandomImageSelection(ILogger<RandomImageSelection> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

