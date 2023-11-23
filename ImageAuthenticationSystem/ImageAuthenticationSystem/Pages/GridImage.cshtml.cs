using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageAuthenticationSystem.Pages;

public class GridImage : PageModel
{
    private readonly ILogger<GridImage> _logger;

    public GridImage(ILogger<GridImage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

