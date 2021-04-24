using Microsoft.AspNetCore.Builder;

namespace Portal.Application.System
{
	public static class ApplicationBuilderExtensions
	{
        public static IApplicationBuilder ConfigSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c=>{
                c.SwaggerEndpoint("/swagger/v1/swagger.json","Portal Api V1");
            });
            return app;
        }
	}
}