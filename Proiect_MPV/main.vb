Public Class main
    'Pentru o mai buna gestionare al programului vom folosi UserControls
    'UserControls - Este aproximativ la fel ca o forma doar ca aceasta se poate integra in alta forma
    'Reducand astfel repetarea codului inutil
    'La fiecare apasare pe buton se va incarca usercontrolul aferent


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles btnProgram.Click
        'Controls.Clear - Curata interfata de orice alt user control ramas
        'Daca nu curat atunci se suprapune cu cel anterior
        Me.Panel1.Controls.Clear()
        'Dupa ce am curatat il adaug
        Me.Panel1.Controls.Add(New Rute)
    End Sub

    Private Sub btnIntarzieri_Click(sender As System.Object, e As System.EventArgs) Handles btnIntarzieri.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Intarzieri)
    End Sub

    Private Sub btnDetalii_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalii.Click
        Dim show As New Details
        show.Show()
    End Sub

    Private Sub btnRute_Click(sender As System.Object, e As System.EventArgs) Handles btnRute.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New ProgramAutobuze)
    End Sub

    Private Sub btnChat_Click(sender As System.Object, e As System.EventArgs) Handles btnChat.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Chat)
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
