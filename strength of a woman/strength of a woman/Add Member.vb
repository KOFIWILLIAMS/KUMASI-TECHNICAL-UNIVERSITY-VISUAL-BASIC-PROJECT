Imports MySql.Data.MySqlClient
Public Class Add
    'combobox selection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxGender.Text = "Choose Gender"
        ComboBoxGender.Items.Add("Male")
        ComboBoxGender.Items.Add("Female")
        ComboBoxMarital.Text = "Choose Marital Status"
        ComboBoxMarital.Items.Add("Single")
        ComboBoxMarital.Items.Add("Married")
        ComboBoxMarital.Items.Add("Divorced")
        ComboBoxMarital.Items.Add("Widow")
    End Sub

    'pic selection
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicBox.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"
        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim IMG_FileNameInput As String = OpenFileDialog1.FileName
            PicBox.ImageLocation = IMG_FileNameInput
        End If
        C_H.Visible = False
    End Sub

    'save
    Private Sub BT_SAVE_Click(sender As Object, e As EventArgs) Handles BT_SAVE.Click
        Dim store As String
        If F_N.Text = "" Or S_N.Text = "" Then
            MsgBox("please Enter your details")
            Exit Sub
        Else

            store = "insert into ma_family.register(`F_N`, `S_N`, `ComboBoxGender`, `N_I_N`, `P_N`, `Date_O_B`, `P_O_B`, `G_P_A`, `ComboBoxMarital`, `PicBox`) values 
('" + F_N.Text + "' , '" + S_N.Text + "','" + ComboBoxGender.Text + "', '" + N_I_N.Text + "', '" + P_N.Text + "' , '" + Date_O_B.Text + "', '" + P_O_B.Text + "','" + G_P_A.Text + "', '" + ComboBoxMarital.Text + "','" + PicBox.Text + "')"
            save(store)
            clear(Me)
        End If

    End Sub
    'clear
    Private Sub BT_CLEAR_Click(sender As Object, e As EventArgs) Handles BT_CLEAR.Click
        clear(Me)
        ComboBoxGender.Text = "Choose Gender"
        ComboBoxMarital.Text = "Choose Marital Status"
        PicBox.Text = ""
    End Sub

    'update
    Private Sub BTupdate_Click(sender As Object, e As EventArgs) Handles BTupdate.Click
        If F_N.Text = "" And S_N.Text = "" Then
            MsgBox("Enter You Details")
        Else

            Dim info As String
            info = "update ma_family.register Set F_N = '" + F_N.Text + "', S_N = '" + S_N.Text + "' ,P_N = '" + P_N.Text + "' where N_I_N = '" + N_I_N.Text + "'"
            save(info)
            Record.Load_Table()
            clear(Me)
        End If

    End Sub
End Class
