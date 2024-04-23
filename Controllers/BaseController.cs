using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class BaseController : ControllerBase
    {

        private readonly PCContext context = new ();


        // Get a list of all Entities
        public List<TEntity> GetAll<TEntity>()
            where TEntity : class
        {
            var entity = context.Set<TEntity>().ToList(); 
            return entity;
        }

        // Gets Entity based on Id
        public TEntity GetId<TEntity>(int id)
        where TEntity : class

        {
            var entity = context.Set<TEntity>().Find(id);
            return entity;
        }

        // Get a list of Column Names
        public IEnumerable<string> GetProperties<TEntity>()
            where TEntity : class
        {
            var properties = typeof(TEntity).GetProperties().Select(property => property.Name);
            return properties;
        }

        // Add
        public bool Add<TEntity>([FromBody] TEntity newItem)
        where TEntity : class

        {
            if (newItem == null)
            {
                return false;
            }
           
            context.Set<TEntity>().Add(newItem);
            context.SaveChanges();
            return true;
        }

        // Delete
        public IActionResult Delete<TEntity>(int id)
        where TEntity : class
        {
            var item = context.Set<TEntity>().Find(id);
            if (item == null)
            {
                return NotFound();
            }

            context.Set<TEntity>().Remove(item);
            context.SaveChanges();
            return NoContent();
        }

        // Update
        public IActionResult Update<TEntity>(int id, [FromBody] TEntity updatedItem, Func<TEntity, int> idSelector)
         where TEntity : class
        {
            if (updatedItem == null || id != idSelector(updatedItem))
            {
                return BadRequest("Invalid data");
            }

            var existingItem = context.Set<TEntity>().Find(id);

            if (existingItem == null)
            {
                return NotFound("Item not found");
            }

            var type = typeof(TEntity);
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var updatedValue = property.GetValue(updatedItem);
                if (property.CanWrite && updatedValue != null)
                {
                    property.SetValue(existingItem, updatedValue);
                }
            }

            context.Set<TEntity>().Update(existingItem);
            context.SaveChanges();

            return Ok(existingItem);
        }
#nullable enable

        public IEnumerable<object> FilterBase(IEnumerable<object> result,
    string? name = null,
    int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
                IEnumerable<string>? producer = null)

        {
#nullable  disable
            if (name != null)
            {
                result = result.Where(item => item.GetType().GetProperty("Name").GetValue(item).ToString().Contains(name));
            }

            if (minPrice != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("Price").GetValue(item)) >= minPrice);
            }
            if (maxPrice != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("Price").GetValue(item)) <= maxPrice);
            }
            if (exactPrice != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("Price").GetValue(item)) == exactPrice);
            }

            if (producer != null && producer.Any())
            {
                result = result.Where(item => producer.Contains(item.GetType().GetProperty("Producer").GetValue(item).ToString()));
            }
            return result;
        }

#nullable enable
        public IEnumerable<object> FilterDimensions(IEnumerable<object> result,
            string? name = null,
            int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
            int? minLength = null, int? maxLength = null, int? exactLength = null,
            int? minWidth = null, int? maxWidth = null, int? exactWidth = null,
            int? minHeight = null, int? maxHeight = null, int? exactHeight = null,
            IEnumerable<string>? producer = null

            )

        {
#nullable disable
            result = FilterBase(result, name, minPrice, maxPrice, exactPrice, producer);

            if (minLength != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Length").GetValue(hdd)) >= minLength);
            }
            if (maxLength != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Length").GetValue(hdd)) <= maxLength);
            }
            if (exactLength != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Length").GetValue(hdd)) == exactLength);
            }

            if (minWidth != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Width").GetValue(hdd)) >= minWidth);
            }
            if (maxWidth != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Width").GetValue(hdd)) <= maxWidth);
            }
            if (exactWidth != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Width").GetValue(hdd)) == exactWidth);
            }

            if (minHeight != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Height").GetValue(hdd)) >= minHeight);
            }
            if (maxHeight != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Height").GetValue(hdd)) <= maxHeight);
            }
            if (exactHeight != null)
            {
                result = result.Where(hdd => Convert.ToInt32(hdd.GetType().GetProperty("Height").GetValue(hdd)) == exactHeight);
            }

      
            return result;
        }
    }
}
