using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Repositories.EFCore.Extensions
{
    public static class GunlukCalismaSuresiRepositoryExtensions
    {
        public static IQueryable<GunlukCalismaSuresi> FilterGunlukCalismaSuresis(this IQueryable<GunlukCalismaSuresi> gunlukCalismaSuresis, 
            uint SiraNo,string Adi, Boolean Aktif) =>
            gunlukCalismaSuresis.Where(gunlukCalismaSuresis =>
              gunlukCalismaSuresis.Aktif == Aktif &&
              SiraNo > 0 ? gunlukCalismaSuresis.SiraNo == SiraNo : gunlukCalismaSuresis.SiraNo > 0
            );

        public static IQueryable<GunlukCalismaSuresi> Search(this IQueryable<GunlukCalismaSuresi> gunlukCalismaSuresis,
        string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return gunlukCalismaSuresis;

            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return gunlukCalismaSuresis
                .Where(b => b.Adi
                .ToLower()
                .Contains(searchTerm));
        }

        public static IQueryable<GunlukCalismaSuresi> Sort(this IQueryable<GunlukCalismaSuresi> gunlukCalismaSuresis, 
            string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return gunlukCalismaSuresis.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<GunlukCalismaSuresi>(orderByQueryString);

            if (orderQuery is null)
                return gunlukCalismaSuresis.OrderBy(b => b.Id);

            return gunlukCalismaSuresis.OrderBy(orderQuery);
        }

    }
}
