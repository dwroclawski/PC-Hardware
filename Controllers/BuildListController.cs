using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class BuildListController : ControllerBase
    {

        private readonly PCContext context = new();

        CaseController caseController = new();
        CPUController cpuController = new();
        GPUController gpuController = new();
        MotherboardController motherboardController = new();
        PSUController psuController = new();
        RAMController ramController = new();
        HDDController hddController = new();
        SSDController ssdController = new();
        CaseCoolerController caseCoolerController = new();
        CPUCoolerController cpuCoolerController = new();


        [HttpGet("Build/Get")]
        public IActionResult GetBuilds(string userId)
        {
            if (string.IsNullOrEmpty(userId)) return BadRequest();

            var builds = context.BuildList.Where(b => b.UserId == userId).ToList();
            var resultList = new List<object>();

            foreach (var build in builds)
            {
                var result = new Dictionary<string, object>
                {
                    { "id", build.Id },
                    { "name", build.Name }
                };

                if (build.Case != null) result.Add("case", caseController.Filter(name: build.Case).FirstOrDefault());
                if (build.CPU != null) result.Add("cpu", cpuController.Filter(name: build.CPU).FirstOrDefault());
                if (build.GPU != null) result.Add("gpu", gpuController.Filter(name: build.GPU).FirstOrDefault());
                if (build.Motherboard != null) result.Add("motherboard", motherboardController.Filter(name: build.Motherboard).FirstOrDefault());
                if (build.PSU != null) result.Add("psu", psuController.Filter(name: build.PSU).FirstOrDefault());
                if (build.RAM != null) result.Add("ram", ramController.Filter(name: build.RAM).FirstOrDefault());
                if (build.HDD != null) result.Add("hdd", hddController.Filter(name: build.HDD).FirstOrDefault());
                if (build.SSD != null) result.Add("ssd", ssdController.Filter(name: build.SSD).FirstOrDefault());
                if (build.CaseCooler != null) result.Add("casecooler", caseCoolerController.Filter(name: build.CaseCooler).FirstOrDefault());
                if (build.CPUCooler != null) result.Add("cpucooler", cpuCoolerController.Filter(name: build.CPUCooler).FirstOrDefault());

                resultList.Add(result);
            }

            return Ok(resultList);
        }

        [HttpGet("Build/GetCount")]
        public IActionResult GetBuildCount(string userId)
        {
            if (string.IsNullOrEmpty(userId)) return BadRequest();

            var builds = context.BuildList.Where(b => b.UserId == userId).ToList();
            return Ok(builds.Count);
        }


        [HttpDelete("Build/Delete")]
        public IActionResult DeleteBuild(int id) { 
            
            var build = context.BuildList.Find(id);
            if (build == null) return NotFound();
            context.BuildList.Remove(build);
            context.SaveChanges();
            return Ok();
        }

        public class BuildRequest
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public Dictionary<string, string> BuildList { get; set; }
        }

        [HttpPost("Build/Add")]
        public IActionResult AddBuild([FromBody] BuildRequest request)
        {
            if (string.IsNullOrEmpty(request.Id) || string.IsNullOrEmpty(request.Name) || request.BuildList == null || !request.BuildList.Any()) return BadRequest();

            var newBuild = new BuildList
            {
                UserId = request.Id,
                Name = request.Name,
                Case = request.BuildList.ContainsKey("case") ? request.BuildList["case"] : null,
                CPU = request.BuildList.ContainsKey("cpu") ? request.BuildList["cpu"] : null,
                GPU = request.BuildList.ContainsKey("gpu") ? request.BuildList["gpu"] : null,
                Motherboard = request.BuildList.ContainsKey("motherboard") ? request.BuildList["motherboard"] : null,
                PSU = request.BuildList.ContainsKey("psu") ? request.BuildList["psu"] : null,
                RAM = request.BuildList.ContainsKey("ram") ? request.BuildList["ram"] : null,
                HDD = request.BuildList.ContainsKey("hdd") ? request.BuildList["hdd"] : null,
                SSD = request.BuildList.ContainsKey("ssd") ? request.BuildList["ssd"] : null,
                CaseCooler = request.BuildList.ContainsKey("casecooler") ? request.BuildList["casecooler"] : null,
                CPUCooler = request.BuildList.ContainsKey("cpucooler") ? request.BuildList["cpucooler"] : null
            };
            context.BuildList.Add(newBuild);
            context.SaveChanges();

            return Ok(newBuild);
        }

    }
}
