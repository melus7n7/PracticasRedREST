using backendnet.Models;
using Microsoft.AspNetCore.Identity;

namespace backendnet.Middlewares;

public class BitacoraRegistro(RequestDelegate next, IServiceProvider serviceProvider)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var endpoint = context.GetEndpoint();
        var bitacoraEventoAttr = endpoint?.Metadata.GetMetadata<BitacoraEventoAttribute>();

        if (bitacoraEventoAttr != null)
        {
            try
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var contextBd = scope.ServiceProvider.GetRequiredService<IdentityContext>();

                    string evento = bitacoraEventoAttr.Evento + ": " + context.Request.Path;
                    if (!string.IsNullOrEmpty(evento))
                    {
                        Bitacora bitacora = new()
                        {
                            Evento = evento,
                        };

                        contextBd.Bitacora.Add(bitacora);
                        await contextBd.SaveChangesAsync();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception en bitácora");
            }
        }

        await next(context);
    }
}

public static class BitacoraRegistroExtensions
{
    public static IApplicationBuilder UsesBitacoraRegistro(this IApplicationBuilder builder){
        return builder.UseMiddleware<BitacoraRegistro>();
    }
}

[AttributeUsage(AttributeTargets.Method)]
public class BitacoraEventoAttribute : Attribute
{
    public string Evento { get; }

    public BitacoraEventoAttribute(string evento)
    {
        Evento = evento;
    }
}
 