using Entities.Models;
using Entities.RequestFeatures;
using FastReport;
using FastReport.Export.PdfSimple;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;
using System.Data;

namespace Repositories.EFCore
{
    public sealed class PuantajRepository : RepositoryBase<Puantaj>, IPuantajRepository
    {
        public PuantajRepository(RepositoryContext context) : base(context)
        {
            
        }

        public void CreateOnePuantaj(Puantaj puantaj) => Create(puantaj);
        public void DeleteOnePuantaj(Puantaj puantaj) => Delete(puantaj);
        public async Task<PagedList<Puantaj>> GetAllPuantajsAsync(PuantajParameters puantajParameters,bool trackChanges)
        {
            var puantajs = await FindAll(trackChanges)
                .FilterPuantajs(puantajParameters.BaslangicDonemi, puantajParameters.BitisDonemi)
                .Sort(puantajParameters.OrderBy)
                .ToListAsync();

            return PagedList<Puantaj>
                .ToPagedList(puantajs, 
                puantajParameters.PageNumber, 
                puantajParameters.PageSize);
        }
        public async Task<List<Puantaj>> GetAllPuantajsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
        public async Task<MemoryStream> PuantajCizelgesiReportAsync(PuantajParameters puantajParameters)
        {
            FastReport.Utils.Config.WebMode = true;
            Report report = new Report();
            report.Load("Reports/PuantajCizelgesi.frx");
            report.SetParameterValue("PARAMBIRIMADI", "Birim Adı");
            report.SetParameterValue("PARAMBSLDONEM", DateTime.Now);
            report.SetParameterValue("PARAMBTSDONEM", DateTime.Now);
             
            var data = new List<ResponseDataModel>();
            ResponseDataModel m = new ResponseDataModel();
            data.Add(new ResponseDataModel
            {
                Id = 1,
                Adi = "adi1"
            });

            data.Add(new ResponseDataModel
            {
                Id = 2,
                Adi = "adi2"
            });

            report.RegisterData(data, "dt");
            DataBand band = report.FindObject("Data1") as DataBand;
            band.DataSource = report.GetDataSource("dt");
            report.GetDataSource("dt").Enabled = true;
            report.Prepare();

            PDFSimpleExport pdfexport = new PDFSimpleExport();
            pdfexport.ShowProgress = false;
            pdfexport.Subject = "Subject";
            pdfexport.Title = "title";
            MemoryStream ms = new MemoryStream();
            report.Report.Export(pdfexport, ms);
            report.Dispose();
            pdfexport.Dispose();
            ms.Position = 0;

            return ms;
        }
        public async Task<Puantaj> GetOnePuantajByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
        public void UpdateOnePuantaj(Puantaj puantaj) => Update(puantaj);
    }

    class ResponseDataModel 
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }
}
