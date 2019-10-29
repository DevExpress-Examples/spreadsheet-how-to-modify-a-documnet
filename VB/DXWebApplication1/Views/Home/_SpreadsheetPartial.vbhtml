@Html.DevExpress().Spreadsheet(Sub(settings)
                                        settings.Name = "Spreadsheet"
                                        settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "SpreadsheetPartial"}
                                        settings.CustomActionRouteValues = New With {Key .Controller = "Home", Key .Action = "CustomAction"}

                                        settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                        settings.Height = 500
                                        settings.ReadOnly = False
                                        settings.RibbonMode = SpreadsheetRibbonMode.Ribbon
                                    End Sub).Open(Server.MapPath("~/Docs/testDocument1.xlsx")).GetHtml()