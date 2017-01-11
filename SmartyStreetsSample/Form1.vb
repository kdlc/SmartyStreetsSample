Imports System
Imports System.IO
Imports SmartyStreets
Imports SmartyStreets.USStreetApi

Public Class Form1
    Private Sub btnVerifyAddress_Click(sender As Object, e As EventArgs) Handles btnVerifyAddress.Click

        'NOTE: Before running, make sure you include your AuthID and AuthToken from SmartyStreets.com
        Dim _authID As String = ""
        Dim _authToken As String = ""

        If _authID = "" And _authToken = "" Then
            MessageBox.Show("You need to include AuthID and AuthToken from smarty streets com.")
            Exit Sub
        End If

        Dim client = New ClientBuilder(_authID, _authToken).Build()

        Dim lookup As New Lookup
        With lookup
            .Street = Me.txtAddress1.Text
            .Street2 = Me.txtAddress2.Text
            .City = Me.txtCity.Text
            .State = Me.txtState.Text
            .ZipCode = Me.txtZipcode.Text
        End With

        Try
            client.Send(lookup)
        Catch ex As Exception
            Me.txtResults.Clear()
            Me.txtResults.Text = "Error: " & ex.Message.ToString
        End Try

        Dim candidates As List(Of Candidate) = lookup.Result
        Dim results As String = ""

        For Each candidate In candidates
            Dim meta As Metadata = candidate.Metadata
            Debug.Print("Latitude: " & meta.Latitude & " Longitude: " & meta.Longitude)
            results = results & "Candidate(" & candidate.CandidateIndex & ")" & vbCrLf
            results = results & "Latitude: " & meta.Latitude & " Longitude: " & meta.Longitude & vbCrLf
        Next

        Me.txtResults.Text = results


    End Sub
End Class
