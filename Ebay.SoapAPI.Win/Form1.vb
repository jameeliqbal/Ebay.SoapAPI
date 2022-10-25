Imports Ebay.Service.Core.Soap
Imports Ebay.Service.Call
Imports Ebay.Service.Core.Sdk

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    ''' <summary>
    ''' Please make sure that you set the proper ApiServerUrl and ApiToken 
    ''' in the app.config file BEFORE running this project.
    ''' </summary>
    Private Sub btnUpdateInventory_Click(sender As Object, e As EventArgs) Handles btnUpdateInventory.Click
        Try
            Dim context = GetApiContext()
            Dim apiCall = New ReviseInventoryStatusCall(context)

            Dim InventoriesToUpdate = GetInventoriesToUpdateList()
            Dim updatedInventory = apiCall.ReviseInventoryStatus(InventoriesToUpdate)

            MessageBox.Show("Inventories Updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch ex As Exception
            Dim errorMessage = "Error while updating inventory:" + Environment.NewLine + Environment.NewLine
            errorMessage += ex.Message + Environment.NewLine
            errorMessage += ex.InnerException?.Message

            MessageBox.Show(errorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function GetInventoriesToUpdateList() As InventoryStatusTypeCollection
        Dim inventoryToUpdate = New InventoryStatusTypeCollection()

        Dim inventory1 = New InventoryStatusType()
        inventory1.SKU = "0025215625695"
        inventory1.ItemID = "381842898386"
        inventory1.Quantity = 10

        Dim inventory2 = New InventoryStatusType()
        inventory2.SKU = "0043859472154"
        inventory2.ItemID = "381842898389"
        Dim price = New AmountType()
        price.currencyID = CurrencyCodeType.USD
        price.Value = 24.5D
        inventory2.StartPrice = price

        Dim inventory3 = New InventoryStatusType()
        inventory3.SKU = "0043859536351"
        inventory3.ItemID = "381842898402"
        inventory3.Quantity = 100
        Dim price3 = New AmountType()
        price3.currencyID = CurrencyCodeType.USD
        price3.Value = 240.1D
        inventory3.StartPrice = price3

        inventoryToUpdate.Add(inventory1)
        inventoryToUpdate.Add(inventory2)
        inventoryToUpdate.Add(inventory3)

        Return inventoryToUpdate

    End Function
End Class
