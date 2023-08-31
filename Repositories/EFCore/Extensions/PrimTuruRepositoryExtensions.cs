using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Repositories.EFCore.Extensions
{
    public static class PrimTuruRepositoryExtensions
    {
        public static IQueryable<PrimTuru> FilterPrimTurus(this IQueryable<PrimTuru> primTurus, uint SiraNo,string Adi, Boolean Aktif) =>
            primTurus.Where(primTurus =>
              primTurus.Aktif == Aktif &&
              SiraNo > 0 ? primTurus.SiraNo == SiraNo : primTurus.SiraNo > 0
            );

        public static IQueryable<PrimTuru> Search(this IQueryable<PrimTuru> primTurus,
        string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return primTurus;

            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return primTurus
                .Where(b => b.Adi
                .ToLower()
                .Contains(searchTerm));
        }

        public static IQueryable<PrimTuru> Sort(this IQueryable<PrimTuru> primTurus, 
            string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return primTurus.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<PrimTuru>(orderByQueryString);

            if (orderQuery is null)
                return primTurus.OrderBy(b => b.Id);

            return primTurus.OrderBy(orderQuery);
        }

    }
}
