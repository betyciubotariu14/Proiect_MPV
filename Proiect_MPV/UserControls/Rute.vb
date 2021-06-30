Public Class Rute
    Public IDLocPlecare As String
    Public IDLocSosire As String

    Private Sub ProgramAutobuze_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PopuleazaComboCuLocalitati()
    End Sub

    'Populam combourile cu localitati
    Private Sub PopuleazaComboCuLocalitati()
        Dim dataTablePlec As DataTable = DBUtils.getDataTable("SELECT * FROM Localitati")
        Dim dataTableSosire As DataTable = DBUtils.getDataTable("SELECT * FROM Localitati")

        ComboBox1.DataSource = dataTablePlec
        ComboBox2.DataSource = dataTableSosire

        ComboBox1.DisplayMember = "Denumire"
        ComboBox1.ValueMember = "IDLocalitate"

        ComboBox2.DisplayMember = "Denumire"
        ComboBox2.ValueMember = "IDLocalitate"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Daca ambele localitati sunt la fel afisam mesaj 
        If ComboBox1.SelectedValue = ComboBox2.SelectedValue Then
            MessageBox.Show("Destinatia trebuie sa fie diferita fata de plecare!")
        Else
            IDLocPlecare = ComboBox1.SelectedValue
            IDLocSosire = ComboBox2.SelectedValue

            'Memoram in cele 2 variabile IDLocPlcare si IDLocSosire valorile selectate din combo
            'Afisam in datagrid autobuzele care trec prin cele 2 localitati
            Me.DataGridView1.DataSource = DBUtils.getDataTable(String.Format("SELECT IDAutobuz AS ID, Firma, Marca, NrInmatriculare FROM Autobuze WHERE IDAutobuz IN (SELECT IDAutobuz FROM Rute WHERE IDLocalitate IN ({0},{1}) GROUP BY IDAutobuz HAVING COUNT(*) > 1)", IDLocPlecare, IDLocSosire))
        End If
    End Sub

    'Dupa ce s-au incarcat toate autobuzele care trec prin cele doua localitati 
    'Putem da dublu click pe datagrid astfel selectat index-ul (adica randul) pe care s-a facut click
    'Mai departe preluam ID-ul autobuzului prin acest index si afisam tabelul in interfata
    Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim IDAutobuz = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim showProgram As New Program
        showProgram.DataGridView1.DataSource = DBUtils.getDataTable("SELECT OraPlecare FROM Rute WHERE IDAutobuz = " & IDAutobuz & " AND IDLocalitate = " & IDLocPlecare & " ORDER BY OraPlecare")
        showProgram.Show()
    End Sub
End Class
