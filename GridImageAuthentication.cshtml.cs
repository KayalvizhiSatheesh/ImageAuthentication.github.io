using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageAuthenticationSystem.Pages;

public class GridImageAuthentication : PageModel
{
    private readonly ILogger<GridImageAuthentication> _logger;

    public GridImageAuthentication(ILogger<GridImageAuthentication> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

