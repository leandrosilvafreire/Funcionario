Imports System.Data.SqlClient
Module Module1
    Public conexao As New SqlConnection
    Public banco As String
    Public servidor As String
    Public usuario As String
    Public senha As String
    Public sql As String

    Public Sub criarConexao()
        conexao.ConnectionString = "Initial Catalog=" & banco & ";Data Source=" & servidor & ";User ID=" & usuario & ";Password=" & senha & ";"
    End Sub

    Public Sub executaSql(ByVal comando_Sql As String)
        Dim command As New SqlClient.SqlCommand

        conexao.Open()
        command.Connection = conexao
        command.CommandText = comando_Sql
        command.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Public Function consulta(ByVal comando_Sql As String) As DataTable

        Dim adaptador As New SqlDataAdapter
        Dim comando As New SqlCommand
        Dim ds As New DataSet
        Dim dt As New DataTable

        conexao.Open()
        comando.Connection = conexao
        comando.CommandText = comando_Sql
        adaptador.SelectCommand = comando
        adaptador.Fill(ds)
        adaptador.Dispose()
        dt = ds.Tables(0)
        conexao.Close()
        Return dt
    End Function



End Module
