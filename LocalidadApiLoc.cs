using DTOsTp;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Localidad_winForm
{
    public class LocalidadApiLoc
    {
        private static HttpClient loc = new HttpClient();
        static LocalidadApiLoc()
        {
            loc.BaseAddress = new Uri("http://localhost:5183/");
            loc.DefaultRequestHeaders.Accept.Clear();
            loc.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<LocalidadDTO> GetAsync(string codPostal)
        {
            LocalidadDTO localidad = null;
            HttpResponseMessage response = await loc.GetAsync("localidades/" + codPostal);
            if (response.IsSuccessStatusCode)
            {
                localidad = await response.Content.ReadAsAsync<LocalidadDTO>();
            }
            return localidad;
        }

        public static async Task<IEnumerable<LocalidadDTO>> GetAllAsync()
        {
            IEnumerable<LocalidadDTO> localidades = null;
            HttpResponseMessage response = await loc.GetAsync("localidades");
            if (response.IsSuccessStatusCode)
            {
                localidades = await response.Content.ReadAsAsync<IEnumerable<LocalidadDTO>>();
            }
            return localidades;
        }

        public async static Task AddAsync(LocalidadDTO localidad)
        {
            HttpResponseMessage response = await loc.PostAsJsonAsync("localidades");
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(string codPostal)
        {
            HttpResponseMessage response = await loc.DeleteAsync("localidades");
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(LocalidadDTO localidad)
        {
            HttpResponseMessage response = await loc.PutAsJsonAsync("localidades");
            response.EnsureSuccessStatusCode();
        }
    }
}