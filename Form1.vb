Public Class MenuUtama
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BtnDataMaster_Click(sender As Object, e As EventArgs) Handles btnDataMaster.Click
        ' button dipilih
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        ' tampilkan panel konten
        pnlDataMaster.Visible = True
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
    End Sub

    Private Sub BtnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        ' button dipilih
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        ' tampilkan panel konten
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        'button dipilih
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        ' tampilkan panel konten
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = True
    End Sub

    Private Sub BtnLainnya_Click(sender As Object, e As EventArgs) Handles btnLainnya.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = True
        lblSelected5.Visible = False
        lblSelected6.Visible = False
    End Sub

    Private Sub BtnTentangAplikasi_Click(sender As Object, e As EventArgs) Handles btnTentangAplikasi.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = True
        lblSelected6.Visible = False
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Ketika menekan tombol logout
        Select Case MsgBox("Yakin Ingin Keluar ?", MsgBoxStyle.YesNo, "Keluar")
            Case MsgBoxResult.Yes
                Me.Close()
        End Select

        'button dipilih
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = True



    End Sub


End Class
