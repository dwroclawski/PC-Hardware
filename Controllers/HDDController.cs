using Microsoft.AspNetCore.Mvc;
using System.Text;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class HDDController : BaseController
    {
        private readonly PCContext context = new();

        [HttpGet("HDD/Get")]
        public IActionResult GetAll()
        {
            var result = GetAsList();
            return Ok(result);
        }
        public IEnumerable<object> GetAsList()
        {
            var result = context.HDD
                .Select(c => new
                {
                    c.Name,
                    c.Price,
                    Producer = context.Enum_Producers
                            .Where(em => em.Id == c.ProducerId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    c.Length,
                    c.Width,
                    c.Height,
                    Capacity = context.Enum_Capacity
                            .Where(em => em.Id == c.CapacityId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    InterFace = context.Enum_Connectors
                            .Where(em => em.Id == c.InterfaceId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    FormFactor = context.Enum_FormFactor
                            .Where(em => em.Id == c.FormFactorId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    RPM = context.Enum_RPM
                            .Where(em => em.Id == c.RPMId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    Cache = context.Enum_Cache
                            .Where(em => em.Id == c.CacheId)
                            .Select(em => em.Name)
                            .FirstOrDefault()
                });
            return result;
        }
    

        [HttpGet("HDD/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
            string? name = null,
            int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
            int? minLength = null, int? maxLength = null, int? exactLength = null,
            int? minWidth = null, int? maxWidth = null, int? exactWidth = null,
            int? minHeight = null, int? maxHeight = null, int? exactHeight = null,
            IEnumerable<string>? producer = null,
            IEnumerable<string>? capacity = null,
            IEnumerable<string>? interFace = null,
            IEnumerable<string>? formFactor = null,
            IEnumerable<string>? rpm = null,
            IEnumerable<string>? cache = null
            )

        {
#nullable disable

            IEnumerable<object> result = GetAsList();

            result = FilterDimensions(result, name, minPrice, maxPrice, exactPrice, minLength, maxLength, exactLength, minWidth, maxWidth, exactWidth, minHeight, maxHeight, exactHeight, producer);

            if (capacity != null && capacity.Any())
            {
                result = result.Where(item => capacity.Contains(item.GetType().GetProperty("Capacity").GetValue(item).ToString()));
            }
            if (interFace != null && interFace.Any())
            {
                result = result.Where(item => interFace.Contains(item.GetType().GetProperty("InterFace").GetValue(item).ToString()));
            }
            if (formFactor != null && formFactor.Any())
            {
                result = result.Where(item => formFactor.Contains(item.GetType().GetProperty("FormFactor").GetValue(item).ToString()));
            }
            if (rpm != null && rpm.Any())
            {
                result = result.Where(item => rpm.Contains(item.GetType().GetProperty("RPM").GetValue(item).ToString()));
            }
            if (cache != null && cache.Any())
            {
                result = result.Where(item => cache.Contains(item.GetType().GetProperty("Cache").GetValue(item).ToString()));
            }



            return result;
        }

        [HttpGet("HDD/Compability/Case")]

        public string CaseCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    var formFactor = data["formFactor"];
                    var drivebay = context.Enum_Drivebay
                           .Select(em => em.Name)
                           .ToList();

                    foreach(var db in drivebay) {
                        if (db.Contains(formFactor.ToString()))
                        {
                            string result = db.Replace(" ", "%20");
                            urlBuilder.Append($"driveBay={result}&");
                        }
                    }


                    if (urlBuilder.Length > 0)
                    {
                        urlBuilder.Length--;
                    }

                    return urlBuilder.ToString();
                }
                catch (Exception)
                {
                    return string.Empty;
                }

            }
            return string.Empty;
        }

        [HttpGet("HDD/Compability/Motherboard")]

        public string MotherboardCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    string interFace = data["interFace"];
                    interFace = interFace.Substring(0, interFace.Length - 2);
                    var drivebay = context.Enum_Connectors
                                   .Select(em => em.Name)
                                   .ToList();

                    foreach (var db in drivebay)
                    {
                        if (db.Contains(interFace))
                        {
                            string result = db.Replace(" ", "%20");
                            urlBuilder.Append($"internalConnectors={result}&");
                        }
                    }


                    if (urlBuilder.Length > 0)
                    {
                        urlBuilder.Length--;
                    }

                    return urlBuilder.ToString();
                }
                catch (Exception)
                {
                    return string.Empty;
                }

            }
            return string.Empty;
        }
        [HttpGet("HDD/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<HDD>(id);
            return Ok(result);
        }

        [HttpGet("HDD/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<HDD>();
            return Ok(result);
        }

        [HttpPost("HDD/Add")]
        public IActionResult Add([FromBody] HDD newItem)
        {
            if (Add<HDD>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid HDD data");
        }

        [HttpDelete("HDD/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<HDD>(id);
        }

        [HttpPut("HDD/Update")]
        public IActionResult Update(int id, [FromBody] HDD newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}