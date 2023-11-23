<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/192545604/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828671)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Spreadsheet for ASP.NET MVC - How to modify a document
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/192545604/)**
<!-- run online end -->

This example demonstrates how to programmatically modify a document in the [Spreadsheet](https://docs.devexpress.com/AspNetMvc/17113/components/spreadsheet) extension.

## Implementation Details

In this example, a ribbon contains four buttons that apply predefined settings to spreadsheet content: **Apply formatting**, **Insert link**, **Draw Borders**, and **Show total**. When a button is clicked, the [CommandExecuted](https://docs.devexpress.com/AspNet/js-ASPxClientRibbon.CommandExecuted) event handler initiates a spreadsheet callback. 

```jscript
 function OnCommandExecuted(s, e) {
     var command = e.item.name;
     Spreadsheet.PerformCallback({ customCommand: command })
 }
```

On the server, the [CustomActionRouteValues](https://docs.devexpress.com/AspNet/DevExpress.Web.Mvc.SpreadsheetSettings.CustomActionRouteValues) action implements the required document modifications.
 
```csharp
public ActionResult CustomAction(string customCommand) {
    IWorkbook workbook = SpreadsheetExtension.GetCurrentDocument("Spreadsheet");
    Worksheet worksheet = workbook.Worksheets[0];
   
    switch (customCommand) {
        case "applyFormatting":
            CellRange priceRange = worksheet.Range["C2:C15"];
            Formatting rangeFormatting = priceRange.BeginUpdateFormatting();
            rangeFormatting.Font.Color = Color.SandyBrown;
            rangeFormatting.Font.FontStyle = SpreadsheetFontStyle.Bold;
            rangeFormatting.Fill.BackgroundColor = Color.PaleGoldenrod;
            rangeFormatting.NumberFormat = "$0.0#";

            rangeFormatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            rangeFormatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            priceRange.EndUpdateFormatting(rangeFormatting);
            break;
        case "insertLink":
            worksheet.Columns["G"].WidthInPixels = 180;
            Cell cell1 = worksheet.Cells["G4"];
            cell1.Fill.BackgroundColor = Color.WhiteSmoke;
            worksheet.Hyperlinks.Add(cell1, "https://documentation.devexpress.com/OfficeFileAPI/14912/Spreadsheet-Document-API", true, "Spreadsheet Document API");
            break;
        case "drawBorders":
            CellRange tableRange = worksheet.Range["A2:E16"];
            tableRange.Borders.SetAllBorders(Color.RosyBrown, BorderLineStyle.Hair);
            break;
        case "showTotal":
            Cell cell2 = worksheet.Cells["E16"];
            cell2.Formula = "=SUBTOTAL(9,E2:E15)";
            Cell cell3 = worksheet.Cells["A16"];
            cell3.Formula = "SUBTOTAL(103,A2:A15)";
            Cell cell4 = worksheet.Cells["D16"];
            cell4.Value = "Total amount";
            break;
    }
    return SpreadsheetExtension.GetCustomActionResult("Spreadsheet");
}
```

## Files to Review

* [_SpreadsheetPartial.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml) (VB: [_SpreadsheetPartial.vbhtml](./VB/DXWebApplication1/Views/Home/Index.vbhtml))
* [Index.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml) (VB: [Index.vbhtml](./VB/DXWebApplication1/Views/Home/Index.vbhtml))
* [HomeController.cs](./CS/DXWebApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DXWebApplication1/Controllers/HomeController.vb))

