Public Class frmReportes
    Private Sub abrirForm(ByVal formulario As Form)
        Dim formHijo As Form = TryCast(formulario, Form)
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        If Me.pnlContenedor.Controls.Count = 1 Then
            Me.pnlContenedor.Controls.RemoveAt(0)
        End If
        Me.pnlContenedor.Controls.Add(formHijo)
        Me.pnlContenedor.Tag = formHijo
        formHijo.Show()
    End Sub

    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirForm(frmReporteAlquilerInicio)
    End Sub

    Private Sub btnAlquiler_Click(sender As Object, e As EventArgs) Handles btnAlquiler.Click
        abrirForm(frmReporteAlquiler)
    End Sub

    Private Sub btnExtras_Click(sender As Object, e As EventArgs) Handles btnExtras.Click
        abrirForm(frmReporteExtras)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        abrirForm(frmReporteAlquilerInicio)
    End Sub

    Private Sub frmReportes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmPrincipal.Show()
    End Sub
End Class