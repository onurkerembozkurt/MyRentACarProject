using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    /* CONTROLLERS DOSYALARI
     * Bunu havalimanı controllerına benzetebiliriz Gelen bütün istekleri bu controller karşılıyor 
     * Gelen İstek Ne demek ? gelen istek aslında sizin projenizde; IProductService e baktığınızda
     * Bizim clientlarımız ne yapar ? örneğin siz bir e-ticaret uygulamasının mobilini yapıyorsunuz
     * Mobil uygulama ne yapar ürünleri listeler fiyat aralığında vs
     * işte bunları istek haline getireceğiz
     * RESTFULL--> Bu yapılar http protokolü üzerinden çalışıyor
     * Protokol: anlaşma yolu demek
     * Siz bu controller da size yapılabilecek istekleri kodluyorsunuz
     * Mesala insanlar [HTTP GET] isteği bulunabilsinler diyoruz
     * Şimdi kendi controllerımızı oluşturacağız
     * Bir controllerin controller olabilmesi için ControllerBase den inherit edilmesi lazım
     * 
     * 
     * 
     */
    [Route("api/[controller]")]//--->>> ATTRİBUTE DEMEK
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Message);

        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
