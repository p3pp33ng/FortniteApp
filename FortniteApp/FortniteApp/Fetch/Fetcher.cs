using FortniteApp.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FortniteApp.Fetch
{
    public class Fetcher
    {
        public async Task<WeaponsList> FetchWeapon()
        {
            var result = new WeaponsList();
            using (var client = SetUpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"http://www.fortnitechests.info/api/weapons");
                    if (response.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<WeaponsList>(await response.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception)
                {

                }
            }
            return result;
        }

        public async Task<ChestDTO> FetchChests()
        {
            var result = new ChestDTO();
            using (var client = SetUpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"http://www.fortnitechests.info/api/chests");
                    if (response.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<ChestDTO>(await response.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception)
                {

                }
            }
            return result;
        }

        private HttpClient SetUpClient()
        {
            HttpClient client = new HttpClient();
            return client;
        }
    }
}
