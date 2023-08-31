using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Repositories.EFCore.Extensions
{
    public static class CalismaGrubuRepositoryExtensions
    {
        public static IQueryable<CalismaGrubu> FilterPersonelPrims(this IQueryable<CalismaGrubu> calismaGrubu, int PersonelId,
            TimeOnly OOMesaiBaslamaSaati, TimeOnly OOMesaiBitisSaati, TimeOnly YemekMolasiBaslamaSaati,
            TimeOnly YemekMolasiBitisSaati, TimeOnly OSMesaiBaslamaSaati, TimeOnly OSMesaiBitisSaati,
            int HaftalikCalismaSuresi, int HaftaTatiliGunu, Boolean Aktif) =>
            calismaGrubu.Where(calismaGrubu =>
              calismaGrubu.Aktif == Aktif &&
              OOMesaiBaslamaSaati > new TimeOnly(0, 0) ? calismaGrubu.OOMesaiBaslamaSaati >= OOMesaiBaslamaSaati : calismaGrubu.OOMesaiBaslamaSaati > new TimeOnly(0, 0) &&
              OOMesaiBitisSaati > new TimeOnly(0, 0) ? calismaGrubu.OOMesaiBitisSaati >= OOMesaiBitisSaati : calismaGrubu.OOMesaiBitisSaati > new TimeOnly(0, 0) &&
              YemekMolasiBaslamaSaati > new TimeOnly(0, 0) ? calismaGrubu.YemekMolasiBaslamaSaati >= YemekMolasiBaslamaSaati : calismaGrubu.YemekMolasiBaslamaSaati > new TimeOnly(0, 0) &&
              YemekMolasiBitisSaati > new TimeOnly(0, 0) ? calismaGrubu.YemekMolasiBitisSaati >= YemekMolasiBitisSaati : calismaGrubu.YemekMolasiBitisSaati > new TimeOnly(0, 0) &&
              OSMesaiBaslamaSaati > new TimeOnly(0, 0) ? calismaGrubu.OSMesaiBaslamaSaati >= OSMesaiBaslamaSaati : calismaGrubu.OSMesaiBaslamaSaati > new TimeOnly(0, 0) &&
              OSMesaiBitisSaati > new TimeOnly(0, 0) ? calismaGrubu.OSMesaiBitisSaati >= OSMesaiBitisSaati : calismaGrubu.OSMesaiBitisSaati > new TimeOnly(0, 0) &&
              PersonelId > 0 ? calismaGrubu.PersonelId == PersonelId : calismaGrubu.PersonelId > 0 &&
              HaftalikCalismaSuresi > 0 ? calismaGrubu.HaftalikCalismaSuresi == HaftalikCalismaSuresi : calismaGrubu.HaftalikCalismaSuresi > 0 &&
              HaftaTatiliGunu > 0 ? calismaGrubu.HaftaTatiliGunu == HaftaTatiliGunu : calismaGrubu.HaftaTatiliGunu > 0
            );
         
        public static IQueryable<CalismaGrubu> Sort(this IQueryable<CalismaGrubu> calismaGrubu, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return calismaGrubu.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<CalismaGrubu>(orderByQueryString);

            if (orderQuery is null)
                return calismaGrubu.OrderBy(b => b.Id);

            return calismaGrubu.OrderBy(orderQuery);
        }

    }
}
