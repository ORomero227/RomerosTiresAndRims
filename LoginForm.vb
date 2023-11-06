Public Class LoginForm
	Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click

	End Sub

	Private Sub CreateAccountLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateAccountLink.LinkClicked
		CreateAccountForm.ShowDialog()
	End Sub

	Private Sub AboutUsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AboutUsLink.LinkClicked
		AboutForm.ShowDialog()
	End Sub

	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
		Me.Close()
	End Sub
End Class