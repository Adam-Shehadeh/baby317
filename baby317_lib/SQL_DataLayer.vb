Imports System.Data.SqlClient
Imports System.Configuration

Public Module SQL_DataLayer

    Dim connstr As String = "Data Source=den1.mssql3.gear.host;Initial Catalog=dbroyann;Persist Security Info=True;User ID=dbroyann;Password=Royann317!"
    Dim conn As New SqlConnection(connstr)

    Public Function CREATE(ByVal msg As String) As Integer
        'Dim sp_CREATE As New SqlCommand("sp_CREATE", conn)
        'Dim local As Integer = 0

        'sp_CREATE.CommandType = CommandType.StoredProcedure
        'sp_CREATE.Parameters.Add(New SqlParameter("@msg", msg))

        'Try
        '    conn.Open()
        '    local = sp_CREATE.ExecuteNonQuery()
        'Catch ex As Exception

        'Finally
        '    conn.Close()
        'End Try

        'Return local
    End Function

    Public Function READ() As List(Of RowModel)

        Dim sp_READ As New SqlCommand("SELECT * FROM tbl_ForAdam", conn)
        Dim local As New List(Of RowModel)

        'sp_READ.Parameters.Add(New SqlParameter("@CustomerName", SqlDbType.NVarChar, 40))
        'sp_READ.Parameters("@CustomerName").Value = txtCustomerName.Text

        Try
            conn.Open()
            Using reader As SqlDataReader = sp_READ.ExecuteReader()
                While reader.Read()
                    Dim rm As New RowModel
                    rm.ID = CInt(reader("ID"))
                    rm.MSG = reader("MSG").ToString()
                    local.Add(rm)
                End While
                If local.Count = 0 Then
                    Throw New ApplicationException() 'Forces going to catch block
                End If
            End Using
        Catch
            Dim rm As New RowModel
            rm.ID = 0
            rm.MSG = "Failed to find data."
            local.Add(rm)
        Finally
            conn.Close()
        End Try
        Return local
    End Function

    Public Sub UPDATE()

    End Sub

    Public Sub DELETE()

    End Sub

End Module
