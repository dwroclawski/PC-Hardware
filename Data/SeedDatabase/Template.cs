namespace VueBase.Data.SeedDatabase
{
    public static class TemplateInitializer
    {
        public static WebApplication SeedTemplate(this WebApplication app, PCContext context)
        {
            try
            {
                /*
                var part = context.Part.FirstOrDefault();
                if (part == null)
                {
                    context.Part.AddRange(
                        new Models.Part
                        {
                           part data,
                           part data,
                           part data

                        }
                new Models.Part
                        {
                           part data,
                           part data,
                           part data

                        }
                new Models.Part
                        {
                           part data,
                           part data,
                           part data

                        }
                new Models.Part
                        {
                           part data,
                           part data,
                           part data

                        }
                       );
                }
                */

                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

            return app;
        }

    }
}
