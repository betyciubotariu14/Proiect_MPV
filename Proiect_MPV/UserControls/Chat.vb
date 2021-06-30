Public Class Chat

    'Metoda apelata la incarcarea formei automat prin eveniment (load)
    Private Sub Chat_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Preiau din baza de date un tabel si-l atribui in datagridview (tabelul afisat din forma)
        DataGridView1.DataSource = DBUtils.getDataTable("SELECT Mesaj, Data FROM Chat ORDER BY Data")
        'Setez dimensiunea coloanei din datagridview
        DataGridView1.Columns.Item(0).Width = 300
    End Sub

    Private Sub btnTrimite_Click(sender As System.Object, e As System.EventArgs) Handles btnTrimite.Click
        'Daca am introdus un mesaj valid atunci procedez mai departe la inserarea lui in baza de date
        If String.IsNullOrEmpty(TextBox1.Text) Then Exit Sub

        'Inserez mesajul in baza de date
        DBUtils.ExecuteSQLQuery("INSERT INTO Chat (Mesaj, Data) VALUES ('" & TextBox1.Text & "','" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "')")

        'Reincarc forma prin apelarea evenimentului
        Me.Chat_Load(Nothing, Nothing)
        'Curat textboxul de mesajul vechi introdus
        Me.TextBox1.Text = ""
    End Sub
End Class
