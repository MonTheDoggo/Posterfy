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

        public async void OnGet()
        {
            //await imageService.GetImageForSong("1tgofMvzgqtrVAx2YGkhzb");
            await imageService.GetImageForSong("5hqxBvQJ3XJDSbxT9vyyqA");
            //await imageService.GetImageForAlbum("3mebR1rG8L34EOFaw3zRCz");
        }
    }
}