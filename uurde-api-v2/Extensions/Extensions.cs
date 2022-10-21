using System;
namespace uurde_api_v2.Extensions
{
    public static class Extensions
    {
        public static WebApplication MapEndpoints(this WebApplication app)
        {
            app.MapGet("vinyls/list", Endpoints.Vinyls.List);
            return app;
        }
    }
}

