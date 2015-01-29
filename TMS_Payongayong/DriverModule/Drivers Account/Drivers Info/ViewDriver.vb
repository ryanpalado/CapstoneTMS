Imports System.IO
Imports System.Data.Odbc
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ViewDriver
    Dim imgMemoryStream As MemoryStream = New MemoryStream()
    Dim imgByteArray As Byte() = Nothing

    Private Sub ViewDriver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gridDriverFunds.AllowDragToGroup = False
        gridCashAdvance.AllowDragToGroup = False
       
    End Sub

    Private Sub ViewDriver_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dashboard.Enabled = True
    End Sub

    Private Sub btnNewFund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFund.Click
        AddFunds.Show()
        Me.Enabled = False
    End Sub

    Private Sub TabDriverFunds_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabDriverFunds.Paint
        gridDriverFunds.AllowDragToGroup = False
        getAllDriversFundFromDB()
    End Sub

  

    Private Sub gridDriverFunds_CommandCellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDriverFunds.CommandCellClick

        Dim GridCommandCellElement As Telerik.WinControls.UI.GridCommandCellElement = TryCast(sender, GridCommandCellElement)
        Dim strText As String = GridCommandCellElement.CommandButton.Text
        Select Case strText
            Case "Edit Amount"
                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)
                Dim fundNo As String = Me.gridDriverFunds.Rows(cell.RowIndex).Cells(2).Value
                Dim fundAmount As String = Me.gridDriverFunds.Rows(cell.RowIndex).Cells(6).Value
                Dim fundID As String = fundNo
                fundAmount = fundAmount.Substring(0, fundAmount.Length - 3)
                EditFunds.lblIDFundEdit.Text = fundID
                EditFunds.txtFundAmount.Text = fundAmount
                EditFunds.Show()
                Me.Enabled = False
            Case "Delete"
                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)
                Dim fundNo As String = Me.gridDriverFunds.Rows(cell.RowIndex).Cells(2).Value
                Dim fundID As String = fundNo

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Are you sure?", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)


                selectQuery("select * from tbl_drivers_funds where fund_no = '" & fundID & "' ")
                If dr.HasRows Then
                    lblAmount.Text = dr.Item("amount")
                End If

                If dialog = DialogResult.Yes Then
                    modifyQuery("delete from tbl_drivers_funds where fund_no = '" & fundID & "' ")
                    
                    deductRemainFunds()
                    RadMessageBox.SetThemeName("Office2010Silver")
                    Dim success As DialogResult = RadMessageBox.Show(Me, "Record Successfully Deleted.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                ElseIf dialog = DialogResult.No Then

                End If

        End Select

    End Sub
   

    Private Sub btnFundsTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFundsTransactions.Click
        Transactions.Show()
    End Sub

    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton3.Click
        Me.Enabled = False
        AddCashAdvance.Show()

    End Sub

    Private Sub drpdwnMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnMonth.SelectedIndexChanged
        queryMonth()
    End Sub

    Private Sub RadPageViewPage9_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles tabCashAdvance.Paint
        gridCashAdvance.AllowDragToGroup = False
        getCashAdvanceFromDB()
    End Sub

    Private Sub gridCashAdvance_CommandCellClick(sender As System.Object, e As System.EventArgs) Handles gridCashAdvance.CommandCellClick
        Dim GridCommandCellElement As Telerik.WinControls.UI.GridCommandCellElement = TryCast(sender, GridCommandCellElement)
        Dim strText As String = GridCommandCellElement.CommandButton.Text
        Select Case strText
            Case "Edit Amount/Reason"
                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)
                Dim balNo As String = Me.gridCashAdvance.Rows(cell.RowIndex).Cells(2).Value
                Dim balAmount As String = Me.gridCashAdvance.Rows(cell.RowIndex).Cells(5).Value
                Dim reason As String = Me.gridCashAdvance.Rows(cell.RowIndex).Cells(6).Value
                Dim balID As String = balNo
                balAmount = balAmount.Substring(0, balAmount.Length - 3)
                EditCashAdvance.lblIDCashAdvEdit.Text = balID
                EditCashAdvance.txtCashAdvAmount.Text = balAmount
                EditCashAdvance.txtCashAdvReason.Text = reason
                EditCashAdvance.Show()
                Me.Enabled = False
            Case "Delete"
                Dim cell As Telerik.WinControls.UI.GridDataCellElement = TryCast(sender, Telerik.WinControls.UI.GridDataCellElement)
                Dim balNo As String = Me.gridCashAdvance.Rows(cell.RowIndex).Cells(2).Value
                Dim balID As String = balNo

                RadMessageBox.SetThemeName("Office2010Silver")
                Dim dialog As DialogResult = RadMessageBox.Show(Me, "Are you sure?", "Message", MessageBoxButtons.YesNo, RadMessageIcon.Question)

                If dialog = DialogResult.Yes Then
                    modifyQuery("delete from tbl_drivers_cashadvance where balance_no = '" & balID & "' ")

                    deductRemainFunds()
                    RadMessageBox.SetThemeName("Office2010Silver")
                    Dim success As DialogResult = RadMessageBox.Show(Me, "Record Successfully Deleted.", "Message", MessageBoxButtons.OK, RadMessageIcon.Info)

                ElseIf dialog = DialogResult.No Then

                End If

        End Select

    End Sub

    Private Sub drpdwnYear_SelectedIndexChanged(sender As System.Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnYear.SelectedIndexChanged
        queryYear()
    End Sub

    Private Sub RadButton2_Click(sender As System.Object, e As System.EventArgs) Handles RadButton2.Click
        PayBalances.Show()
    End Sub
End Class
