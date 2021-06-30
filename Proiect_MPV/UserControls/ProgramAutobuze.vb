Public Class ProgramAutobuze
    Public amIncarcat As Boolean = False

    'Metoda apelata la incarcarea formei
    Private Sub Rute_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Populez din baza de date lista cu toate rutele
        Dim dtRute As DataTable = DBUtils.getDataTable("SELECT IDAutobuz AS ID, Firma + ' ' + NrInmatriculare AS Denumire  fROM Autobuze")
        ListBox1.DataSource = dtRute

        ListBox1.DisplayMember = "Denumire"
        ListBox1.ValueMember = "ID"

        'incarc in combo de salvare localitatile
        cmbLoc.DataSource = DBUtils.getDataTable("SELECT * FROM Localitati")
        cmbLoc.DisplayMember = "Denumire"
        cmbLoc.ValueMember = "IDLocalitate"
        amIncarcat = True 'membru prin care controlez daca s-a incarcat forma sau nu (pentru a nu sari direct la ListBox1.SelectedValueChanged)
    End Sub

    'Metoda apelata atunci cand sesizeaza modificari de selectie in lista de rute
    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedValueChanged
        If Not amIncarcat Then Exit Sub 'Daca inca n-am incarcat toate informatiile atunci ies

        'Preiau toate rutele pe care autobuzul selectat le va parcurge (ListBox1.SelectedValue)
        DataGridView1.DataSource = DBUtils.getDataTable("SELECT Rute.IDRuta, Localitati.Denumire as Localitate,RUTE.OraPlecare From Rute " &
                                                        "INNER JOIN Localitati ON Localitati.IDLocalitate = Rute.IDLocalitate " &
                                                        "WHERE IDAutobuz = " & ListBox1.SelectedValue)
        'Ascund IDRuta nu am nevoie s-o afisez, doar s-o procesez la update
        DataGridView1.Columns.Item(0).Visible = False
        DataGridView1.Columns.Item(1).ReadOnly = True
        DataGridView1.Columns.Item(2).ReadOnly = False

    End Sub

    Private Sub btnSalveazaPrg_Click(sender As System.Object, e As System.EventArgs) Handles btnSalveazaPrg.Click
        'parcurg toate randurile din datagrid pt a face update (in caz de modificari)
        Dim IDAutobuzCurent As String = ListBox1.SelectedValue
        For Each dataRow As DataGridViewRow In DataGridView1.Rows
            'Verific daca ora introdusa este corecta
            Dim oraPlecareIntrodusa As String = dataRow.Cells(2).Value.ToString.Trim
            If oraPlecareIntrodusa.Substring(2, 1) = ":" AndAlso oraPlecareIntrodusa.Substring(5, 1) = ":" Then
                DBUtils.ExecuteSQLQuery("UPDATE Rute SET OraPlecare = '" & oraPlecareIntrodusa & "' WHERE IDRuta = " & dataRow.Cells(0).Value.ToString.Trim)
            End If
        Next

        'daca am selectata o localitate si o ora valida atunci o inserez in rute ca un nou program de circulatie
        If cmbLoc.SelectedIndex <> -1 AndAlso
            txbOraPlec.Text <> "" AndAlso
            txbOraPlec.Text.Substring(2, 1) = ":" AndAlso
            txbOraPlec.Text.Substring(5, 1) = ":" Then

            DBUtils.ExecuteSQLQuery(String.Format("INSERT INTO Rute (IDAutobuz, IDLocalitate, Ordine, OraPlecare) VALUES ({0},{1},{2},'{3}')", ListBox1.SelectedValue, cmbLoc.SelectedValue, "'1'", txbOraPlec.Text))
        End If

        txbOraPlec.Text = ""
        cmbLoc.SelectedIndex = -1

        'Reincarc datele
        ListBox1_SelectedValueChanged(Nothing, Nothing)
    End Sub
End Class
