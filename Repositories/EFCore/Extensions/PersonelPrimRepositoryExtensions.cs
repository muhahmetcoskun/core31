using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Repositories.EFCore.Extensions
{
    public static class PersonelPrimRepositoryExtensions
    {
        public static IQueryable<PersonelPrim> FilterPersonelPrims(this IQueryable<PersonelPrim> primTurus, uint PrimTuruId, uint PersonelId, Boolean Aktif) =>
            primTurus.Where(primTurus =>
              primTurus.Aktif == Aktif &&
              PrimTuruId > 0 ? primTurus.PrimTuruId == PrimTuruId : primTurus.PrimTuruId > 0 &&
              PersonelId > 0 ? primTurus.PersonelId == PersonelId : primTurus.PersonelId > 0
            );
         
        public static IQueryable<PersonelPrim> Sort(this IQueryable<PersonelPrim> primTurus, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return primTurus.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<PersonelPrim>(orderByQueryString);

            if (orderQuery is null)
                return primTurus.OrderBy(b => b.Id);

            return primTurus.OrderBy(orderQuery);
        }

    }
}
