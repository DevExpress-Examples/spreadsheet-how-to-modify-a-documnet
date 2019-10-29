# Spreadsheet - How to modify a document

***Note***

In version **19.2**, we renamed our **Range** interface to **CellRange** - see the following BC for details: [The DevExpress.Spreadsheet.Range interface has been renamed to DevExpress.Spreadsheet.CellRange](https://supportcenter.devexpress.com/ticket/details/bc5125).

This example demonstrates how to modify a document in the Spreadsheet extension.
The main idea of this approach is to perform a callback using the  [PerformCallback](https://docs.devexpress.com/AspNet/js-ASPxClientSpreadsheet.PerformCallback%28parameter%29) method and modify a document in the [CustomActionRouteValues](https://docs.devexpress.com/AspNet/DevExpress.Web.Mvc.SpreadsheetSettings.CustomActionRouteValues) action.
 