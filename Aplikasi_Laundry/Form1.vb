Public Class Form1

    Private Sub rd_reguler_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_reguler.CheckedChanged
        If rd_reguler.Checked = True Then
            t_hargakg.Text = 4000
        End If
    End Sub

    Private Sub rd_express_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_express.CheckedChanged
        If rd_express.Checked = True Then
            t_hargakg.Text = 6000
        End If
    End Sub

    Private Sub cb_pewangi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_pewangi.SelectedIndexChanged
        If cb_pewangi.Text = "Downy" Then
            t_hargapewangi.Text = 2000
        ElseIf cb_pewangi.Text = "Kispray" Then
            t_hargapewangi.Text = 2500
        ElseIf cb_pewangi.Text = "So Klin" Then
            t_hargapewangi.Text = 2500
        Else
            t_hargapewangi.Text = 1500
        End If
    End Sub

    Private Sub btn_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hitung.Click
        t_total.Text = (Val(t_hargakg.Text) * Val(t_jlhsatuan.Text)) + Val(t_hargapewangi.Text)
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click

        t_id.Text = ""
        t_nama.Text = ""
        t_alamat.Text = ""
        t_nomor.Text = ""
        t_ketpakaian.Text = ""
        rd_reguler.Checked = False
        rd_express.Checked = False
        t_hargakg.Text = ""
        t_jlhsatuan.Text = ""
        cb_pewangi.Text = ""
        t_hargapewangi.Text = ""
        t_total.Text = ""
        t_id.Focus()


    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        End
    End Sub

End Class
