using AutoMapper;
using TrendMarket.DtoLayer.Dtos.AboutDtos;
using TrendMarket.DtoLayer.Dtos.SliderDtos;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.PresentationLayer.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultAboutDto,About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<GetByIdAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();


            CreateMap<ResultSliderDto, Slider>().ReverseMap();
            CreateMap<CreateSliderDto, Slider>().ReverseMap();
            CreateMap<GetByIdSliderDto, Slider>().ReverseMap();
            CreateMap<UpdateSliderDto, Slider>().ReverseMap();


        }
    }
}
