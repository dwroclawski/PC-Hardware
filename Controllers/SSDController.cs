using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class SSDController : BaseController
    {
        private readonly PCContext context = new();

        [HttpGet("SSD/Get")]
        public IActionResult GetAll()
        {
            var result = GetAsList();


            return Ok(result);

        }
     public IEnumerable<object> GetAsList()
        {
            var result = context.SSD
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
                   c.ReadSpeed,
                   c.WriteSpeed,
                   c.RandomRead,
                   c.RandomWrite,
                   c.TBW,
                   c.MTBF,
                   FormFactor = context.Enum_FormFactor
                              .Where(em => em.Id == c.FormFactorId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                   InterFace = context.Enum_Connectors
                         .Where(em => em.Id == c.InterfaceId)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                   Capacity = context.Enum_Capacity
                              .Where(em => em.Id == c.CapacityId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                   Cache = context.Enum_Cache
                              .Where(em => em.Id == c.CacheId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                   CellType = context.Enum_CellType
                              .Where(em => em.Id == c.CellTypeId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                   Heatsink = context.Enum_Heatsink
                              .Where(em => em.Id == c.HeatsinkId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                   Encryption = context.Enum_Encryption
                              .Where(em => em.Id == c.EncryptionId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                   Key = context.Enum_Key
                              .Where(em => em.Id == c.KeyId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                   Color = c.Color.Select(c => new { c.Name })

               });
            return result;
        }
        [HttpGet("SSD/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
        string? name = null,
        int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
        int? minLength = null, int? maxLength = null, int? exactLength = null,
        int? minWidth = null, int? maxWidth = null, int? exactWidth = null,
        int? minHeight = null, int? maxHeight = null, int? exactHeight = null,
          decimal? minWattage = null, decimal? maxWattage = null, decimal? exactWattage = null,
    decimal? minReadSpeed = null, decimal? maxReadSpeed = null, decimal? exactReadSpeed = null,
    decimal? minWriteSpeed = null, decimal? maxWriteSpeed = null, decimal? exactWriteSpeed = null,
    decimal? minRandomRead = null, decimal? maxRandomRead = null, decimal? exactRandomRead = null,
    decimal? minRandomWrite = null, decimal? maxRandomWrite = null, decimal? exactRandomWrite = null,
    decimal? minTBW = null, decimal? maxTBW = null, decimal? exactTBW = null,
    decimal? minMTBF = null, decimal? maxMTBF = null, decimal? exactMTBF = null,

        IEnumerable<string>? producer = null,
        IEnumerable<string>? capacity = null,
        IEnumerable<string>? interFace = null,
        IEnumerable<string>? formFactor = null,
        IEnumerable<string>? cache = null,
        IEnumerable<string>? cellType = null,
        IEnumerable<string>? heatsink = null,
        IEnumerable<string>? encryption = null,
        IEnumerable<string>? key = null,
        IEnumerable<string>? color = null

         )

        {
#nullable disable

            IEnumerable<object> result = GetAsList();

            result = FilterDimensions(result, name, minPrice, maxPrice, exactPrice, minLength, maxLength, exactLength, minWidth, maxWidth, exactWidth, minHeight, maxHeight, exactHeight, producer);

            if (minWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("Wattage").GetValue(item)) >= minWattage);
            }
            if (maxWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("Wattage").GetValue(item)) <= maxWattage);
            }
            if (exactWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("Wattage").GetValue(item)) == exactWattage);
            }
            if (minReadSpeed != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("ReadSpeed").GetValue(item)) >= minReadSpeed);
            }
            if (maxReadSpeed != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("ReadSpeed").GetValue(item)) <= maxReadSpeed);
            }
            if (exactReadSpeed != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("ReadSpeed").GetValue(item)) == exactReadSpeed);
            }

            if (minWriteSpeed != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("WriteSpeed").GetValue(item)) >= minWriteSpeed);
            }
            if (maxWriteSpeed != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("WriteSpeed").GetValue(item)) <= maxWriteSpeed);
            }
            if (exactWriteSpeed != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("WriteSpeed").GetValue(item)) == exactWriteSpeed);
            }

            if (minRandomRead != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RandomRead").GetValue(item)) >= minRandomRead);
            }
            if (maxRandomRead != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RandomRead").GetValue(item)) <= maxRandomRead);
            }
            if (exactRandomRead != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RandomRead").GetValue(item)) == exactRandomRead);
            }

            if (minRandomWrite != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RandomWrite").GetValue(item)) >= minRandomWrite);
            }
            if (maxRandomWrite != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RandomWrite").GetValue(item)) <= maxRandomWrite);
            }
            if (exactRandomWrite != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RandomWrite").GetValue(item)) == exactRandomWrite);
            }

            if (minTBW != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("TBW").GetValue(item)) >= minTBW);
            }
            if (maxTBW != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("TBW").GetValue(item)) <= maxTBW);
            }
            if (exactTBW != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("TBW").GetValue(item)) == exactTBW);
            }

            if (minMTBF != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MTBF").GetValue(item)) >= minMTBF);
            }
            if (maxMTBF != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MTBF").GetValue(item)) <= maxMTBF);
            }
            if (exactMTBF != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MTBF").GetValue(item)) == exactMTBF);
            }


            if (capacity != null && capacity.Any())
            {
                result = result.Where(item => capacity.Contains(item.GetType().GetProperty("Capacity").GetValue(item).ToString()));
            }
            if (interFace != null && interFace.Any())
            {
                result = result.Where(item => interFace.Contains(item.GetType().GetProperty("Interface").GetValue(item).ToString()));
            }
            if (formFactor != null && formFactor.Any())
            {
                result = result.Where(item => formFactor.Contains(item.GetType().GetProperty("FormFactor").GetValue(item).ToString()));
            }
            if (cache != null && cache.Any())
            {
                result = result.Where(item => cache.Contains(item.GetType().GetProperty("Cache").GetValue(item).ToString()));
            }
            if (cellType != null && cellType.Any())
            {
                result = result.Where(item => cellType.Contains(item.GetType().GetProperty("CellType").GetValue(item).ToString()));
            }
            if (heatsink != null && heatsink.Any())
            {
                result = result.Where(item => heatsink.Contains(item.GetType().GetProperty("Heatsink").GetValue(item).ToString()));
            }
            if (encryption != null && encryption.Any())
            {
                result = result.Where(item => encryption.Contains(item.GetType().GetProperty("Encryption").GetValue(item).ToString()));
            }
            if (key != null && key.Any())
            {
                result = result.Where(item => key.Contains(item.GetType().GetProperty("Key").GetValue(item).ToString()));
            }

            if (color != null && color.Any())
            {
                result = result.Where(item => {
                    var itemColors = item.GetType().GetProperty("Color").GetValue(item) as IEnumerable<object>;
                    if (itemColors != null)
                    {
                        foreach (var colorItem in itemColors)
                        {
                            var colorName = colorItem.GetType().GetProperty("Name").GetValue(colorItem)?.ToString();
                            if (colorName != null && color.Contains(colorName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }



            return result;
        }


        

        [HttpGet("SSD/Compability/Motherboard")]
        public string MotherboardCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();




                    string interFace = data["interFace"];

                    var connectors = context.Enum_Connectors
                                   .Select(em => em.Name)
                                   .ToList();

                    foreach (var item in connectors)
                    {
                        if (item.ToString().Contains("PCIe 4.0")  && interFace.Contains("PCIe 4.0"))
                        {
                            string result = item.Replace(" ", "%20");
                            urlBuilder.Append($"internalConnectors={result}&");
                        }
                        if (item.ToString().Contains("PCIe 3.0") && interFace.Contains("PCIe 3.0"))
                        {
                            string result = item.Replace(" ", "%20");
                            urlBuilder.Append($"internalConnectors={result}&");
                        }
                    }
                    if (!urlBuilder.ToString().Contains(interFace))
                    {
                        interFace = interFace.Replace(" ", "%20");
                        urlBuilder.Append($"formFactor={interFace}&");
                    }



                    string formFactor = data.formFactor;

                    foreach (var db in connectors)
                    {
                        if(formFactor.Contains("M2") || formFactor.Contains("M.2"))
                        {
                            if (db.Contains("M2") || db.Contains("M.2") )
                            {
                                if (!db.Contains("(WiFi)") && !formFactor.Contains("(WiFi)") || !db.Contains("(WiFi)") && !formFactor.Contains("(WiFi)"))
                                {
                                    string result = db.Replace(" ", "%20");
                                    urlBuilder.Append($"internalConnectors={result}&");
                                }

                            }
                        }
                        if (!urlBuilder.ToString().Contains(formFactor))
                        {
                            formFactor = formFactor.Replace(" ", "%20");
                            urlBuilder.Append($"formFactor={formFactor}&");
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

        [HttpGet("SSD/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<SSD>(id);
            return Ok(result);
        }

        [HttpGet("SSD/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<SSD>();
            return Ok(result);
        }

        [HttpPost("SSD/Add")]
        public IActionResult Add([FromBody] SSD newItem)
        {
            if (Add<SSD>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid SSD data");
        }

        [HttpDelete("SSD/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<SSD>(id);
        }

        [HttpPut("SSD/Update")]
        public IActionResult Update(int id, [FromBody] SSD newItem) 
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}
