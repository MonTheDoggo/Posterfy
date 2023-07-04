using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Posterfy.Services;

namespace Posterfy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ImageService imageService;

        public IndexModel(ILogger<IndexModel> logger, ImageService imageService)
        {
            _logger = logger;
            this.imageService = imageService;
        }

        public void OnGet()
        {
            imageService.GetImageForAlbum("4aawyAB9vmqN3uQ7FjRGTy");
        }
    }
}