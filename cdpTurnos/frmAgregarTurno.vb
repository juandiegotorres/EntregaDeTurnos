Public Class frmAgregarTurno
    Private Sub frmAgregarTurno_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtiFechaTurno.Text = Today
        dtiHoraTurno.Text = Now
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmAgregarCliente.Show()
    End Sub
End Class