Public Class mainMenu
    Public Property giftCard As Boolean
    Public Property Amount As Boolean

    Private Sub lblGiftCardType_Click(sender As Object, e As EventArgs) Handles lblGiftCardType.Click
        Hide()
        giftCardType.Show()
        giftCard = True
    End Sub

    Private Sub lblGiftCardAmt_Click(sender As Object, e As EventArgs) Handles lblGiftCardAmt.Click
        Hide()
        giftCardAmount.Show()
        Amount = True
        If giftCard = True Then
            lblImage.Show()
            lblThree.Show()
            lblMsg.Show()
            lblFour.Show()
            lblPP.Show()
            lblSix.Show()
        End If
    End Sub

    Private Sub lblMsg_Click(sender As Object, e As EventArgs) Handles lblMsg.Click
        If giftCard = True Then
            If Amount = True Then
                Hide()
                Message.Show()
            End If
        End If
    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        Hide()
        Help.Show()
    End Sub

    Private Sub lblPP_Click(sender As Object, e As EventArgs) Handles lblPP.Click
        Hide()
        PP.Show()
    End Sub

    Private Sub lblImage_Click(sender As Object, e As EventArgs) Handles lblImage.Click
        Hide()
        Image.Show()
    End Sub
End Class
