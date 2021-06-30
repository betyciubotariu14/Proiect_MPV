Public Class Intarzieri
    Public IDLocPlecare As String
    Public IDLocSosire As String

    'Functie apelata la incarcare forma
    Private Sub Intarzieri_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        PopuleazaComboCuLocalitati()
    End Sub

    'Preiau datele din baza de date
    Private Sub PopuleazaComboCuLocalitati()
        Dim dataTablePlec As DataTable = DBUtils.getDataTable("SELECT * FROM Localitati")
        Dim dataTableSosire As DataTable = DBUtils.getDataTable("SELECT * FROM Localitati")

        ComboBox1.DataSource = dataTablePlec
        ComboBox2.DataSource = dataTableSosire

        'Setez coloana din tabel care va fi afisata in forma
        ComboBox1.DisplayMember = "Denumire"
        'Setez ca atunci cand selectez sa primesc ID-ul
        ComboBox1.ValueMember = "IDLocalitate"

        ComboBox2.DisplayMember = "Denumire"
        ComboBox2.ValueMember = "IDLocalitate"
    End Sub

    'Metoda apelata la afisarea intarzierilor
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If ComboBox1.SelectedValue = ComboBox2.SelectedValue Then
            MessageBox.Show("Destinatia trebuie sa fie diferita fata de plecare!")
        Else
            IDLocPlecare = ComboBox1.SelectedValue
            IDLocSosire = ComboBox2.SelectedValue

            'Selectez toate autobuzele care trec prin ambele localitati (>1) (au ruta) - conditionare HAVING COUNT(*) > 1 
            'Apoi fac join pe tabele pentru a afisa informatii despre autobuzele respective, rute, intarzieri

            DataGridView1.DataSource = DBUtils.getDataTable(String.Format("SELECT AutobuzeTrecatoare.Firma, AutobuzeTrecatoare.NrInmatriculare, Rute.OraPlecare, Intarzieri.OraConstatata, Intarzieri.Motiv  FROM Intarzieri " &
                                                                           "INNER JOIN ( " &
                                                                               "SELECT IDAutobuz, Firma, Marca, NrInmatriculare " &
                                                                               "FROM Autobuze WHERE IDAutobuz IN ( " &
                                                                                           "SELECT IDAutobuz FROM Rute WHERE IDLocalitate IN ({0},{1}) GROUP BY IDAutobuz HAVING COUNT(*) > 1)) AS AutobuzeTrecatoare " &
                                                                           "ON Intarzieri.IDAutobuz = AutobuzeTrecatoare.IDAutobuz " &
                                                                           "INNER JOIN Rute ON Intarzieri.IDRuta = Rute.IDRuta", IDLocPlecare, IDLocSosire))
        End If

       
    End Sub
End Class
