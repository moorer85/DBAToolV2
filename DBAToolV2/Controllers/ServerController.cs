using System.Linq;
using DBATool.Data;
using DBATool.Data.Models;
using DBAToolV2.Models.Server;
using Microsoft.AspNetCore.Mvc;

namespace DBAToolV2.Controllers
{
    public class ServerController : Controller
    {

        private readonly IServer __serverService;

        public ServerController(IServer serverService)
        {
            __serverService = serverService;
        }

        public IActionResult Index()
        {

            var allServers = __serverService.GetAll();

            var serverModels = allServers
                .Select(p => new ServerDetailModel
                {
                    Id = p.Id,
                    Name = p.Name ?? "No First Name Provided",
                    CpuCore = p.CpuCore,
                    CpuSpeed = p.CpuSpeed,
                    ImageUrl = p.ImageUrl,
                    Memory = p.Memory
                }).ToList();

            var model = new ServerIndexModel
            {
                Servers = serverModels
            };

            return View(model);

        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Server server)
        {
            if (ModelState.IsValid)
            {
              __serverService.Add(server);
            }

                return View(server);
        }

      
    }
}