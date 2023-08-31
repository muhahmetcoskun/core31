using AutoMapper;
using Entities.DataTransferObjects.Authentication;
using Entities.DataTransferObjects.Book;
using Entities.DataTransferObjects.CalismaGrubu;
using Entities.DataTransferObjects.GunlukCalismaSuresi;
using Entities.DataTransferObjects.PersonelPrim;
using Entities.DataTransferObjects.PrimTuru;
using Entities.DataTransferObjects.Puantaj;
using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.DataTransferObjects.ResmiTatil;
using Entities.DataTransferObjects.UygulamaYetki;
using Entities.Models;

namespace WebApi.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDtoForUpdate, Book>().ReverseMap();
            CreateMap<Book, BookDto>();
            CreateMap<BookDtoForInsertion, Book>();

            CreateMap<PuantajVeriGirisiDtoForUpdate, PuantajVeriGirisi>().ReverseMap();
            CreateMap<PuantajVeriGirisi, PuantajVeriGirisiDto>();
            CreateMap<PuantajVeriGirisiDtoForInsertion, PuantajVeriGirisi>();

            CreateMap<PuantajDtoForUpdate, Puantaj>().ReverseMap();
            CreateMap<Puantaj, PuantajDto>();
            CreateMap<PuantajDtoForInsertion, Puantaj>();

            CreateMap<UygulamaYetkiDtoForUpdate, UygulamaYetki>().ReverseMap();
            CreateMap<UygulamaYetki, UygulamaYetkiDto>();
            CreateMap<UygulamaYetkiDtoForInsertion, UygulamaYetki>();

            CreateMap<ResmiTatilDtoForUpdate, ResmiTatil>().ReverseMap();
            CreateMap<ResmiTatil, ResmiTatilDto>();
            CreateMap<ResmiTatilDtoForInsertion, ResmiTatil>();

            CreateMap<PrimTuruDtoForUpdate, PrimTuru>().ReverseMap();
            CreateMap<PrimTuru, PrimTuruDto>();
            CreateMap<PrimTuruDtoForInsertion, PrimTuru>();

            CreateMap<PersonelPrimDtoForUpdate, PersonelPrim>().ReverseMap();
            CreateMap<PersonelPrim, PersonelPrimDto>();
            CreateMap<PersonelPrimDtoForInsertion, PersonelPrim>();

            CreateMap<GunlukCalismaSuresiDtoForUpdate, GunlukCalismaSuresi>().ReverseMap();
            CreateMap<GunlukCalismaSuresi, GunlukCalismaSuresiDto>();
            CreateMap<GunlukCalismaSuresiDtoForInsertion, GunlukCalismaSuresi>();

            CreateMap<CalismaGrubuDtoForUpdate, CalismaGrubu>().ReverseMap();
            CreateMap<CalismaGrubu, CalismaGrubuDto>();
            CreateMap<CalismaGrubuDtoForInsertion, CalismaGrubu>();

            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
