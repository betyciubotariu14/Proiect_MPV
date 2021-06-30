Imports System.Data.SqlClient

Public Class DBUtils
    'SQL Server 2019
    'Connection string - sirul de caractere necesar pentru conectarea la serverul sql
    'Acesta contine serverul - adica local / Baza de date user si parola
    Public Shared connectionString As String = "Data source=DESKTOP-O0H6376\SQL2019;Database=db_Autobuze;User Id=sa;Password=system"

    'Functie care returneaza un tabel din sql pe baza unei interogari
    Public Shared Function getDataTable(ByVal sqlCommand As String) As DataTable
        'Tabel in care stocam informatiile
        Dim dtRezultat As New DataTable

        'Facem o noua conexiune cu parametru connection string
        Dim conn As New SqlConnection(connectionString)
        'Deschidem conexiunea, totodata aici se verifica daca este functionala (cod intern)
        conn.Open()

        'Data adapter cu care putem citi datele din sql server
        Dim sqlDA As New SqlDataAdapter(sqlCommand, connectionString)
        'Dupa ce am citit datele umblem tabelul cu aceste date
        sqlDA.Fill(dtRezultat)

        'Inchidem conexiunea pentru a nu avea alte erori ulterioare
        conn.Close()

        'Returnam tabelul cu informatii
        Return dtRezultat
    End Function

    'Functie care executa o comanda insert / update / delete pe serverul sql ( nu returneaza nimic)
    Public Shared Sub ExecuteSQLQuery(ByVal sqlCommand As String)
        Dim con As New SqlClient.SqlConnection(connectionString)

        'Facem un obiect de tip comanda
        Dim cmd As New SqlCommand()
        cmd.Connection = con
        con.Open()

        'Atribuim la comanda interogarea noastra primita ca parametru
        cmd.CommandText = sqlCommand

        'Executam comanda pe serverul sql
        cmd.ExecuteNonQuery()

        'Inchidem conexiunea
        con.Close()
    End Sub

End Class
