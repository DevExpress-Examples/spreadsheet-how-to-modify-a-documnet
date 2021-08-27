<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/192545604/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828671)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Spreadsheet - How to modify a document
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/192545604/)**
<!-- run online end -->

***Note***

In version **19.2**, we renamed our **Range** interface to **CellRange** - see the following BC for details: [The DevExpress.Spreadsheet.Range interface has been renamed to DevExpress.Spreadsheet.CellRange](https://supportcenter.devexpress.com/ticket/details/bc5125).

This example demonstrates how to modify a document in the Spreadsheet extension.
The main idea of this approach is to perform a callback using the  [PerformCallback](https://docs.devexpress.com/AspNet/js-ASPxClientSpreadsheet.PerformCallback%28parameter%29) method and modify a document in the [CustomActionRouteValues](https://docs.devexpress.com/AspNet/DevExpress.Web.Mvc.SpreadsheetSettings.CustomActionRouteValues) action.
 
