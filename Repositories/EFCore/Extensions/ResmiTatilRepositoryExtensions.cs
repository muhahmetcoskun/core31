using Entities.Models;
using System.Linq.Dynamic.Core;

namespace Repositories.EFCore.Extensions
{
    public static class ResmiTatilRepositoryExtensions
    {
        public static IQueryable<ResmiTatil> FilterResmiTatils(this IQueryable<ResmiTatil> resmiTatils,Boolean Aktif,DateTime Tarih) =>
            resmiTatils.Where(resmiTatil =>
                resmiTatil.Aktif == Aktif);

        public static IQueryable<ResmiTatil> Sort(this IQueryable<ResmiTatil> resmiTatils, 
            string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return resmiTatils.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<ResmiTatil>(orderByQueryString);

            if (orderQuery is null)
                return resmiTatils.OrderBy(b => b.Id);

            return resmiTatils.OrderBy(orderQuery);
        }

    }
}
