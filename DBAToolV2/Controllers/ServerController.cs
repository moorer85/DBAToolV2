using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBATool.Data;
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
    }
}