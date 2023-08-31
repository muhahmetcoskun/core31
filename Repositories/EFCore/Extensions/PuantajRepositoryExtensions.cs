using Entities.Models;
using System.Linq.Dynamic.Core;

namespace Repositories.EFCore.Extensions
{
    public static class PuantajRepositoryExtensions
    {
        public static IQueryable<Puantaj> FilterPuantajs(this IQueryable<Puantaj> puantajVeriGirisis,
       DateTime baslangicDonem, DateTime bitisDonem) =>
       puantajVeriGirisis.Where(puantajVeriGirisi =>
       puantajVeriGirisi.BaslangicDonem >= baslangicDonem &&
       puantajVeriGirisi.BaslangicDonem <= bitisDonem);

     
        public static IQueryable<Puantaj> Sort(this IQueryable<Puantaj> puantajVeriGirisis, 
            string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return puantajVeriGirisis.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<Puantaj>(orderByQueryString);

            if (orderQuery is null)
                return puantajVeriGirisis.OrderBy(b => b.Id);

            return puantajVeriGirisis.OrderBy(orderQuery);
        }

    }
}
