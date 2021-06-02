using Microsoft.AspNetCore.Mvc;
using ishare.Models;

namespace Ishare.Controllers
{
    public class FileManagerController : Controller
    {
        public IActionResult AzureClientBinding()
        {
            AzureStorageAccount.Load();
            return View(AzureStorageAccount.FileManager);
        }
    }
}