using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageAuthenticationSystem.Pages;

public class GridImageSplit : PageModel
{
    private readonly ILogger<GridImageSplit> _logger;

    public GridImageSplit(ILogger<GridImageSplit> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

