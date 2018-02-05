Imports baby317_lib

Public Class frmMaint
    Private Sub frmMaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_MAINTableAdapter.Fill(Me.DbroyannDataSet.tbl_MAIN)
        Dim data As List(Of RowModel) = READ()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtMSG_Create.Text IsNot "" Then
            Dim exit_code As Integer = CREATE(txtMSG_Create.Text)
            If exit_code = 1 Then
                MessageBox.Show("Inserted value successfully!")
                txtMSG_Create.Text = ""
            Else
                MessageBox.Show("Failed to insert value")
            End If
        End If

    End Sub
End Class
