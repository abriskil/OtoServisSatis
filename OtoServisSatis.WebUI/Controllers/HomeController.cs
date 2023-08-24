using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;
using OtoServisSatis.WebUI.Models;
using SubeApi.Models;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace OtoServisSatis.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IService<Slider> _service;
        private readonly ICarService _serviceArac;


        public HomeController(IService<Slider> service, ICarService serviceArac, HttpClient httpClient)
        {
            _service = service;
            _serviceArac = serviceArac;
            _httpClient = httpClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = new HomePageViewModel()
            {
                Sliders = await _service.GetAllAsync(),
                Araclar = await _serviceArac.GetCustomCarList(a=>a.AnaSayfa)

            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Sube()
        {
            //web api ile haberleşen kısım -- istek atıyor
            var response = await _httpClient.GetAsync("https://localhost:7017/api/Sube");
            if (response.IsSuccessStatusCode)
            {
                //istek sonucunda gelen html cevabı stringe çeviriyor
                var content = await response.Content.ReadAsStringAsync();
                //string içindeki json nesnelerinden Urun sınıfındaki nesneleri oluşturuyor
                var subeler = JsonSerializer.Deserialize<List<Sube>>(content);
                //view tarafına model olarak iletiyor
                return View(subeler);
            }
            return View(new List<Sube>());
        }

        public IActionResult SubeEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SubeEkle(Sube sube)
        {
            //gelen Urun nesnesini Json tipinden string yapıya çeviriyoruz
            var json = JsonSerializer.Serialize(sube);

            //karşı tarafa göndereceğimiz içeriği oluşturuyoruz
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //olşan json'ı karşı api sunucusuna iletiyoruz
            var response = await _httpClient.PostAsync("https://localhost:7017/api/Sube", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Sube");
            }
            return View(sube);
        }
    }
}