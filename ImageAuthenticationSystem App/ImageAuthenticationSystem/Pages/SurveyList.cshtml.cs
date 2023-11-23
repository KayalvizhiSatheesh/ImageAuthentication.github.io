using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageAuthenticationSystem.Pages;

public class SurveyList : PageModel
{
    private readonly ILogger<SurveyList> _logger;

    public SurveyList(ILogger<SurveyList> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

