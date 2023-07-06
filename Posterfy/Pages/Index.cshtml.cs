using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Posterfy.Services;

namespace Posterfy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ImageService imageService;
        private TokenService tokenService;
        public string accessToken;

        public IndexModel(ILogger<IndexModel> logger, ImageService imageService, TokenService tokenService)
        {
            _logger = logger;
            this.imageService = imageService;
            this.tokenService = tokenService;
            this.accessToken = tokenService.Token.Access_Token;
        }

        public void OnGet()
        {
            
        }
    }
}