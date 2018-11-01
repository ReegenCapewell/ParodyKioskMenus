Public Class Message
    Private Sub lblGiftCardType_Click(sender As Object, e As EventArgs) Handles lblGiftCardType.Click
        If txtBoxMsg.TextLength > 50 Then
            lblMsgError.Show()
        Else
            Hide()
            mainMenu.Show()
        End If
    End Sub
End Class