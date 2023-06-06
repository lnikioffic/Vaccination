using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory.Interface;
using Lab6new.RepresentationFactory.Representations;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class ExportController
    {
        public ExportController(IPermissionManager permissionManager,User user) { 
            PermissionManager = permissionManager;
            User = user;
        }
        public IPermissionManager PermissionManager { get; set; }

        public User User { get; set; }

        private bool Validate(string fileName, List<IExportRepresentation> data)
        {
            return fileName != "" && data.Count !=0;
        }


        public void Export(List<IExportRepresentation> data,string folderPath,string fileName)
        {
            if(Validate(fileName,data))
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage excel = new ExcelPackage())
                {
                    var file = new FileInfo(folderPath + @"\\" + fileName + ".xlsx");
                    excel.Workbook.Worksheets.Add("Лист 1");
                    var worksheet = excel.Workbook.Worksheets["Лист 1"];
                    var headers = data.FirstOrDefault().GetExportColumnsNames();
                    worksheet.Cells[1, 1].LoadFromArrays(new List<object[]> {headers});
                    worksheet.Cells[2, 1].LoadFromArrays(data.ToExport());
                    excel.SaveAs(file);
                }
            }
            else
            {
                throw new Exception("Назание папки не может быть пустым, или нет записей для экспорта");
            }
        }
    }
}
