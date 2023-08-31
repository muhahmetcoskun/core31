using Entities.DataTransferObjects.UygulamaYetki;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Authentication
{
    public record TokenDto
    {
        public string AccessToken { get; init; }
        public string RefreshToken { get; init; }
        public string UserName { get; init; }
        public List<UserRole> KullaniciYetki { get; set; }
    }
}
