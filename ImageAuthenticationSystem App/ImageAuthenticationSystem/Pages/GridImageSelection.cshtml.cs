using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageAuthenticationSystem.Pages;

public class GridImageSelection : PageModel
{
    private readonly ILogger<GridImageSelection> _logger;

    public GridImageSelection(ILogger<GridImageSelection> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

