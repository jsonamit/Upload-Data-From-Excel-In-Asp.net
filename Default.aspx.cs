using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string extension;
    static DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUploadExcel_Click(object sender, EventArgs e)
    {
        try
        {
            if (excelUpload.HasFile)
            {
                extension = String.Empty;
                extension = excelUpload.FileName.Substring(excelUpload.FileName.LastIndexOf("."));
                string FileName = excelUpload.FileName;
                excelUpload.SaveAs(HttpContext.Current.Server.MapPath("excelfile/" + FileName));
                StateData sdata = new StateData();
                dt = ReadExcelFile.ReadAsDataTable(FileName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sdata.Name = dt.Rows[i][0].ToString();
                    sdata.Save();
                }
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void btnUploadCity_Click(object sender, EventArgs e)
    {
        try
        {
            if (FileUploadCity.HasFile)
            {
                extension = String.Empty;
                extension = FileUploadCity.FileName.Substring(FileUploadCity.FileName.LastIndexOf("."));
                string FileName = FileUploadCity.FileName;
                FileUploadCity.SaveAs(HttpContext.Current.Server.MapPath("excelfile/" + FileName));
                CityData cdata = new CityData();
                dt = ReadExcelFile.ReadAsDataTable(FileName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cdata.StateId = int.Parse(dt.Rows[i][0].ToString());
                    cdata.Name = dt.Rows[i][1].ToString();                   
                    cdata.Save();
                }
            }
        }
        catch (Exception ex)
        {

        }
    }
}