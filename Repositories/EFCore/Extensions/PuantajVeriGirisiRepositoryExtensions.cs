using Entities.Models;
using System.Linq.Dynamic.Core;

namespace Repositories.EFCore.Extensions
{
    public static class PuantajVeriGirisiRepositoryExtensions
    {
        public static IQueryable<PuantajVeriGirisi> FilterPuantajVeriGirisis(this IQueryable<PuantajVeriGirisi> puantajVeriGirisis,
       uint kategoriTipiId) =>
       puantajVeriGirisis.Where(puantajVeriGirisi =>
       puantajVeriGirisi.KategoriTipi.Id == kategoriTipiId);

        public static IQueryable<PuantajVeriGirisi> Search(this IQueryable<PuantajVeriGirisi> puantajVeriGirisis,
         string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return puantajVeriGirisis;

            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return puantajVeriGirisis
                .Where(b => b.Dayanak
                .ToLower()
                .Contains(searchTerm));
        }

        public static IQueryable<PuantajVeriGirisi> Sort(this IQueryable<PuantajVeriGirisi> puantajVeriGirisis, 
            string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return puantajVeriGirisis.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<PuantajVeriGirisi>(orderByQueryString);

            if (orderQuery is null)
                return puantajVeriGirisis.OrderBy(b => b.Id);

            return puantajVeriGirisis.OrderBy(orderQuery);
        }

    }
}
