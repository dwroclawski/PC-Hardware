using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Web;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class PSUController : BaseController
    {
        private readonly PCContext context = new();

        [HttpGet("PSU/Get")]
        public IActionResult GetAll()
        {
            var result = GetAsList();
            return Ok(result);
        }
        public IEnumerable<object> GetAsList()
        {
            var result = context.PSU
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
                     c.Wattage,
                     FormFactor = context.Enum_FormFactor
                           .Where(em => em.Id == c.FormFactorId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                     Rating = context.Enum_Rating
                           .Where(em => em.Id == c.RatingId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                     Modular = context.Enum_Modular
                           .Where(em => em.Id == c.ModularId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                     PFC = context.Enum_PFC
                           .Where(em => em.Id == c.PFCId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                     Cooling = context.Enum_Cooling
                           .Where(em => em.Id == c.CoolingId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                     Connectors = c.Connectors.Select(c => new { c.Name }),
                     ProtectionFeatures = c.ProtectionFeatures.Select(c => new { c.Name }),
                     Color = c.Color.Select(c => new { c.Name }),

                 });
            return result;
        }

        [HttpGet("PSU/Compability/Case")]
        public string CaseCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    string formFactor = data.formFactor;

                formFactor = formFactor.Replace(" ", "%20");

                    urlBuilder.Append($"psuMount={formFactor}&");

                   
                    if(formFactor == "ATX")
                    {
                    urlBuilder.Append($"psuMount=ATX%203.0&");
                    }
                    if (formFactor == "ATX%203.0")
                    {
                        urlBuilder.Append($"psuMount=ATX&");
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
        [HttpGet("PSU/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
        string? name = null,
        int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
        int? minLength = null, int? maxLength = null, int? exactLength = null,
        int? minWidth = null, int? maxWidth = null, int? exactWidth = null,
        int? minHeight = null, int? maxHeight = null, int? exactHeight = null,
        decimal? minWattage = null, decimal? maxWattage = null, decimal? exactWattage = null,
        IEnumerable<string>? formFactor = null,
        IEnumerable<string>? rating = null,
        IEnumerable<string>? modular = null,
        IEnumerable<string>? pfc = null,
        IEnumerable<string>? cooling = null,
        IEnumerable<string>? producer = null,
        IEnumerable<string>? color = null,
        IEnumerable<string>? protectionFeatures = null,
        IEnumerable<string>? connectors = null

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
            if (formFactor != null && formFactor.Any())
            {
                result = result.Where(item => formFactor.Contains(item.GetType().GetProperty("FormFactor").GetValue(item).ToString()));
            }

            if (rating != null && rating.Any())
            {
                result = result.Where(item => rating.Contains(item.GetType().GetProperty("Rating").GetValue(item).ToString()));
            }

            if (modular != null && modular.Any())
            {
                result = result.Where(item => modular.Contains(item.GetType().GetProperty("Modular").GetValue(item).ToString()));
            }

            if (pfc != null && pfc.Any())
            {
                result = result.Where(item => pfc.Contains(item.GetType().GetProperty("PFC").GetValue(item).ToString()));
            }

            if (cooling != null && cooling.Any())
            {
                result = result.Where(item => cooling.Contains(item.GetType().GetProperty("Cooling").GetValue(item).ToString()));
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
            if (protectionFeatures != null && protectionFeatures.Any())
            {
                result = result.Where(item => {
                    var itemProtectionFeatures = item.GetType().GetProperty("ProtectionFeatures").GetValue(item) as IEnumerable<object>;
                    if (itemProtectionFeatures != null)
                    {
                        foreach (var protectionFeatureItem in itemProtectionFeatures)
                        {
                            var protectionFeatureName = protectionFeatureItem.GetType().GetProperty("Name").GetValue(protectionFeatureItem)?.ToString();
                            if (protectionFeatureName != null && protectionFeatures.Contains(protectionFeatureName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (connectors != null && connectors.Any())
            {
                result = result.Where(item => {
                    var itemConnectors = item.GetType().GetProperty("Connectors").GetValue(item) as IEnumerable<object>;
                    if (itemConnectors != null)
                    {
                        foreach (var connectorItem in itemConnectors)
                        {
                            var connectorName = connectorItem.GetType().GetProperty("Name").GetValue(connectorItem)?.ToString();
                            if (connectorName != null && connectors.Contains(connectorName))
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

        [HttpGet("PSU/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<PSU>(id);
            return Ok(result);
        }

        [HttpGet("PSU/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<PSU>();
            return Ok(result);
        }

        [HttpPost("PSU/Add")]
        public IActionResult Add([FromBody] PSU newItem)
        {
            if (Add<PSU>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid PSU data");
        }

        [HttpDelete("PSU/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<PSU>(id);
        }

        [HttpPut("PSU/Update")]
        public IActionResult Update(int id, [FromBody] PSU newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}