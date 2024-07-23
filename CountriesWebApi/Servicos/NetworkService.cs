using CountriesWebApi.Modelos;
using System.Net;

namespace CountriesWebApi.Servicos
{
    public class NetworkService
    {
        // Método para verificar a ligação à internet
        public Response CheckConnection()
        {
            var client = new WebClient();

            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        IsSuccess = true
                    };
                }
            }
            catch
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Configure a sua ligação à Internet."
                };
            }
        }
    }
}
