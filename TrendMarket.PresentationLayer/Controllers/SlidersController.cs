﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using TrendMarket.BusinessLayer.Abstract;
using TrendMarket.DtoLayer.Dtos.SliderDtos;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.PresentationLayer.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;


        public SlidersController(ISliderService sliderService,IMapper mapper)
        {

            _sliderService = sliderService;
            _mapper = mapper;
        }
        public IActionResult  SliderList()
        {
            var values=_sliderService.TGetAll();
            return View( _mapper.Map<List<ResultSliderDto>>(values));
        }


        [HttpGet]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            var values = _mapper.Map<Slider>(createSliderDto);
            _sliderService.TInsert(values);
            return RedirectToAction("SliderList");
        }

        public IActionResult Deleteslider(int id)
        {

            _sliderService.TDelete(id);
            return RedirectToAction("SliderList");
        }

        [HttpGet]

        public IActionResult UpdateSlider(int id )
        {
            var value= _sliderService.TGetById(id);
            return View(_mapper.Map<GetByIdSliderDto>(value));
        }

        [HttpPost]
        public IActionResult UpdateSlider (UpdateSliderDto updateSliderDto)
        {
            var value = _mapper.Map<Slider>(updateSliderDto);
            _sliderService.TUpdate(value);
            return RedirectToAction("SliderList");

        }
    }
}