using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Repositories.EFCore.Extensions
{
    public static class UygulamaYetkiRepositoryExtensions
    {
        public static IQueryable<UygulamaYetki> FilterUygulamaYetkies(this IQueryable<UygulamaYetki> uygulamaYetkies, uint UygulamaId,
            uint UserId, uint RolId, Boolean Aktif) =>
            uygulamaYetkies.Where(uygulamaYetkies =>
                                  uygulamaYetkies.Aktif == Aktif &&
              UygulamaId > 0 ? uygulamaYetkies.Uygulama.Id == UygulamaId : uygulamaYetkies.Uygulama.Id > 0 &&
              RolId > 0 ? uygulamaYetkies.RolId == RolId : uygulamaYetkies.RolId > 0 &&
              UserId > 0 ? uygulamaYetkies.UserId == UserId : uygulamaYetkies.UserId > 0 
            );
         
        public static IQueryable<UygulamaYetki> Sort(this IQueryable<UygulamaYetki> uygulamaYetkiess, 
            string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return uygulamaYetkiess.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<UygulamaYetki>(orderByQueryString);

            if (orderQuery is null)
                return uygulamaYetkiess.OrderBy(b => b.Id);

            return uygulamaYetkiess.OrderBy(orderQuery);
        }

    }
}
