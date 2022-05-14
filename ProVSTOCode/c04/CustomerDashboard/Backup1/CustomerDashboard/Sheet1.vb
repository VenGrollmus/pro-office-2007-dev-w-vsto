
Public Class Sheet1


  Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    'TODO: Delete this line of code to 
    'remove the default AutoFill for 
    'Northwind2007DataSet.Invoices'.
    If Me.NeedsFill("Northwind2007DataSet") Then
      Me.InvoicesTableAdapter.Fill( _
        Me.Northwind2007DataSet.Invoices)
    End If

    If Me.NeedsFill("Northwind2007DataSet") Then
      Me.OrdersTableAdapter.Fill( _
        Me.Northwind2007DataSet.Orders)
    End If

    If Me.NeedsFill("Northwind2007DataSet") Then
      Me.CustomersTableAdapter.Fill( _
         Me.Northwind2007DataSet.Customers)
    End If

    GetOrderData(True)
  End Sub




  Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

  End Sub

  Private Sub GetOrderData(ByVal IncludeAll As Boolean)
    Dim sql As String
    sql = "SELECT Month([Order Summary].[Order Date])"
    sql = sql & " AS TheMonth, Year([Order Summary].[Order Date]) "
    sql = sql & " AS TheYear, Sum([Order Summary].[Order Total]) "
    sql = sql & " AS [SumOfOrder Total] FROM [Order Summary] "
    If Not IncludeAll Then
      sql = sql & " WHERE [Order Summary].[Customer ID]=" & _
        CompanyListBox.SelectedValue
    End If
    sql = sql & " GROUP BY Month([Order Summary].[Order Date]), "
    sql = sql & " Year([Order Summary].[Order Date]); "

    'Setup the connection & the query
    Dim cnn As OleDb.OleDbConnection = _
      Globals.Sheet1.OrdersTableAdapter.Connection
    Dim cmd As New OleDb.OleDbCommand(sql, cnn)

    'Reset the data for the list.
    Dim adpProducts As New OleDb.OleDbDataAdapter
    adpProducts.TableMappings.Add("Table", "Products")
    adpProducts.SelectCommand = cmd

    Dim ds = New DataSet("Products")
    adpProducts.Fill(ds)
    Dim dt As DataTable = ds.Tables(0)

    Me.List1.DataSource = dt
  End Sub


  Private Sub CompanyListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompanyListBox.SelectedIndexChanged

    GetOrderData(False)

  End Sub
End Class
