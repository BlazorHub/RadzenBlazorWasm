using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sde3.Data;

namespace Sde3
{
    public partial class ExportSdeController : ExportController
    {
        private readonly SdeContext context;

        public ExportSdeController(SdeContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/Sde/extracts/csv")]
        [HttpGet("/export/Sde/extracts/csv(fileName='{fileName}')")]
        public FileStreamResult ExportExtractsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Extracts, Request.Query), fileName);
        }

        [HttpGet("/export/Sde/extracts/excel")]
        [HttpGet("/export/Sde/extracts/excel(fileName='{fileName}')")]
        public FileStreamResult ExportExtractsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Extracts, Request.Query), fileName);
        }
        [HttpGet("/export/Sde/parameters/csv")]
        [HttpGet("/export/Sde/parameters/csv(fileName='{fileName}')")]
        public FileStreamResult ExportParametersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Parameters, Request.Query), fileName);
        }

        [HttpGet("/export/Sde/parameters/excel")]
        [HttpGet("/export/Sde/parameters/excel(fileName='{fileName}')")]
        public FileStreamResult ExportParametersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Parameters, Request.Query), fileName);
        }
    }
}
