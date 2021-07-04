using AutoMapper;
using Musicas.Dominio;
using Musicas.Web.ViewModel.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicas.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Album, AlbumIndexViewModel>();
        }
    }
}