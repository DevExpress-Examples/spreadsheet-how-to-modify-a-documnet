@Code
    ViewData("Title") = "Home Page"
End Code

<script>
    function OnCommandExecuted(s, e) {
        var command = e.item.name;
        Spreadsheet.PerformCallback({ customCommand: command })
    }
</script>

@Html.DevExpress().Ribbon(Sub(settings)
                                   settings.Name = "Ribbon"
                                   settings.ShowFileTab = False
                                   settings.ShowTabs = False
                                   settings.OneLineMode = True

                                   settings.ClientSideEvents.CommandExecuted = "OnCommandExecuted"
                                   Dim Group = settings.Tabs.Add("Home").Groups.Add("Group 0")

                                   Group.Items.Add(MVCxRibbonItemType.ButtonItem, Sub(i)
                                                                                      i.Text = "Apply formatting"
                                                                                      i.Name = "applyFormatting"
                                                                                      TryCast(i, RibbonButtonItem).LargeImage.IconID = IconID.ActionsNew32x32
                                                                                  End Sub)
                                   Group.Items.Add(MVCxRibbonItemType.ButtonItem, Sub(i)
                                                                                      i.Text = "Insert link"
                                                                                      i.Name = "insertLink"
                                                                                      i.Size = RibbonItemSize.Small
                                                                                  End Sub)
                                   Group.Items.Add(MVCxRibbonItemType.ButtonItem, Sub(i)
                                                                                      i.Text = "Draw Borders"
                                                                                      i.Name = "drawBorders"
                                                                                      i.Size = RibbonItemSize.Small
                                                                                  End Sub)
                                   Group.Items.Add(MVCxRibbonItemType.ButtonItem, Sub(i)
                                                                                      i.Text = "Show total"
                                                                                      i.Name = "showTotal"
                                                                                      i.Size = RibbonItemSize.Small
                                                                                  End Sub)
                               End Sub).GetHtml()
@Using (Html.BeginForm())
    @Html.Action("SpreadsheetPartial")
End Using
