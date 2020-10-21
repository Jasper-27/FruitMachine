Public Class Form1





    Dim R1 As Int16
    Dim R2 As Int16
    Dim R3 As Int16

    Dim H1 As Boolean
    Dim H2 As Boolean
    Dim H3 As Boolean

    Dim Credits As Int16 = 0
    Dim Bank As Decimal = 0.0

    Dim generate As Random = New Random
    Dim counter As Int16 = 0
    Dim flash As Int16


    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If H1 = False Then
            R1 = generate.Next(1, 10)
            lb1.Text = R1
        Else
            R1 = R1
        End If

        If H2 = False Then
            R2 = generate.Next(1, 10)
            lb2.Text = R2
        Else
            R2 = R2
        End If

        If H3 = False Then
            R3 = generate.Next(1, 10)
            lb3.Text = R3
        Else
            R3 = R3
        End If

        If counter > 10 Then
            Timer1.Enabled = False
            'MessageBox.Show(counter)
            counter = 0


            If R1 = R2 And R2 = R3 Then


                'Threading.Thread.Sleep(10000)
                mBox.Text = ("You win")
                timFlash.Enabled = True
                Credits = Credits + 50
                credCount.Text = Credits




                R1 = 1
                R2 = 2
                R3 = 3

                mBox.BackColor = Color.Green
                mBox.Text = "Well done! 50 credits."



                H1 = False
                btnHold1.BackColor = Color.LightGray
                H2 = False
                btnHold2.BackColor = Color.LightGray
                H3 = False
                btnHold3.BackColor = Color.LightGray


            End If
        End If

        mBox.BackColor = Color.White
        mBox.Text = ("Try again")
        'MessageBox.Show("counter")

        counter = counter + 1
        'MessageBox.Show(counter)

    End Sub
    Private Sub timFlash_Tick(sender As Object, e As EventArgs) Handles timFlash.Tick
        flash = flash + 1
        'MessageBox.Show("Test")




        If lb1.BackColor = Color.Yellow Or lb1.BackColor = Color.LightGray Then
            lb1.BackColor = Color.Green
            lb2.BackColor = Color.Green
            lb3.BackColor = Color.Green
            'flash = flash + 1
        ElseIf lb1.BackColor = Color.Green Then
            lb1.BackColor = Color.Yellow
            lb2.BackColor = Color.Yellow
            lb3.BackColor = Color.Yellow
            'flash = flash + 1
        End If

        If flash > 10 Then
            lb1.BackColor = Color.LightGray
            lb2.BackColor = Color.LightGray
            lb3.BackColor = Color.LightGray
            timFlash.Enabled = False
            flash = 0

            lb1.Text = 0
            lb2.Text = 0
            lb3.Text = 0
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSpin.Click



        If Credits < 1 Then
            Credits = 0
            'mBox.Text = ("Please insert money for credits")
            MessageBox.Show("Out of credits, insert money")
            credCount.Text = Credits
            R1 = 0
            R2 = 0
            R3 = 0
            lb1.Text = R1
            lb2.Text = R2
            lb3.Text = R3

        Else

            Timer1.Enabled = True
            counter = 0
            Credits = Credits - 1
            credCount.Text = Credits
        End If
    End Sub

    Private Sub HOLD1(sender As Object, e As EventArgs) Handles btnHold1.Click
        Credits = Credits - 1
        credCount.Text = Credits
        If H1 = False Then
            H1 = True
            btnHold1.BackColor = Color.Red
        Else
            H1 = False
            btnHold1.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub HOLD2(sender As Object, e As EventArgs) Handles btnHold2.Click
        Credits = Credits - 1
        credCount.Text = Credits
        If H2 = False Then
            H2 = True
            btnHold2.BackColor = Color.Red
        Else
            H2 = False
            btnHold2.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub HOLD3(sender As Object, e As EventArgs) Handles btnHold3.Click
        Credits = Credits - 1
        credCount.Text = Credits
        If H3 = False Then
            H3 = True
            btnHold3.BackColor = Color.Red
        Else
            H3 = False
            btnHold3.BackColor = Color.LightGray

        End If

    End Sub

    Private Sub btnCred_Click_1(sender As Object, e As EventArgs) Handles btnCred.Click
        Credits = Credits + 100
        credCount.Text = Credits
    End Sub


End Class


