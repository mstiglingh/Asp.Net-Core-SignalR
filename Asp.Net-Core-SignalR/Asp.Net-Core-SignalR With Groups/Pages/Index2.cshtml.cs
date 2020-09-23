using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Asp.Net_Core_SignalR.Pages
{
    public class Inde2xModel : PageModel
    {
        private readonly ILogger<Inde2xModel> _logger;

        public Inde2xModel(ILogger<Inde2xModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
