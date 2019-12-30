Imports System.Data.DataTable
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient
Imports System.Net

Public Class Form1

    Dim table As New DataTable("Table")
    Dim dt As New DataTable
    Dim filter_dt As DataTable
    Dim count As Integer
    Dim columnsFilter = "TITOLO"
    Dim loaded = False
    Dim Version = "V1.0 Beta"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLabel.Text = Version
        VersionLabel.Visible = True
        CategoryComboBox.SelectedIndex = 0
        ' Carica l'ultima posizione valida trovata
        FilePosition_Textbox.Text = My.Settings.LastAddress
        GroupBox3.Controls.OfType(Of CheckBox).ToList().ForEach(Sub(c) AddHandler c.CheckedChanged, AddressOf CheckChanged)
        GroupBox2.Controls.OfType(Of TextBox).ToList().ForEach(Sub(c) AddHandler c.DoubleClick, AddressOf copyText)
        AddHandler Magnet_Textbox.DoubleClick, AddressOf copyText

        If (Not FilePosition_Textbox.Text = "") Then
            Dim delayLoad As New Timer
            delayLoad.Interval = 1000
            AddHandler delayLoad.Tick, Sub(sender2, args2)
                                           delayLoad.Stop()
                                           loadData(FilePosition_Textbox.Text)
                                       End Sub
            delayLoad.Start()
        Else
            Load_Button.Enabled = True
        End If

    End Sub


    Private Sub Load_Button_Click(sender As Object, e As EventArgs) Handles Load_Button.Click
        ' Se non è presente un percorso
        If (FilePosition_Textbox.Text = "") Then
            FilePosition_Textbox.Text = fileLoader() ' Chiedi la posizione del file
        End If

        loadData(FilePosition_Textbox.Text)
    End Sub

    Private Sub FilePosition_Textbox_Click(sender As Object, e As EventArgs) Handles FilePosition_Textbox.Click
        ' Se viene cliccata la textbox chiedi il percorso partendo da quello corrente (nel caso sia nullo il percorso di default è il disco C)
        FilePosition_Textbox.Text = fileLoader(FilePosition_Textbox.Text)
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If (Not IsNothing(DataGridView1.CurrentCell)) Then
            Data_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
            Hash_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            Topic_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value
            Post_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value
            Author_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(4).Value
            Title_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(5).Value
            Description_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(6).Value
            Size_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(7).Value
            Category_Textbox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(8).Value
        End If
    End Sub

    Private Sub Find_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Find_Textbox.TextChanged
        filterDataGrid(Find_Textbox.Text, columnsFilter, CategoryComboBox.SelectedItem)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        columnsFilter = "TITOLO"
        filterDataGrid(Find_Textbox.Text, columnsFilter, CategoryComboBox.SelectedItem)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        columnsFilter = "DESCRIZIONE"
        filterDataGrid(Find_Textbox.Text, columnsFilter, CategoryComboBox.SelectedItem)
    End Sub



    Private Sub Magnet_Button_Click(sender As Object, e As EventArgs) Handles Magnet_Button.Click
        Magnet_Textbox.Text = getMagnet(Topic_Textbox.Text)
    End Sub

    Private Sub OpenPost_Button_Click(sender As Object, e As EventArgs) Handles OpenPost_Button.Click
        Dim link As String
        If (Not Topic_Textbox.Text = "" And loaded) Then
            link = "https://web.archive.org/web/http://forum.tntvillage.scambioetico.org/index.php?showtopic=" & Topic_Textbox.Text
            Process.Start(link)
        End If

    End Sub

    Private Sub Dowload_Button_Click(sender As Object, e As EventArgs) Handles Dowload_Button.Click
        If (loaded) Then
            Magnet_Textbox.Text = getMagnet(Topic_Textbox.Text)
            If (Not Magnet_Textbox.Text = "") Then
                Process.Start(Magnet_Textbox.Text)
            End If
        End If

    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        filterDataGrid(Find_Textbox.Text, columnsFilter, CategoryComboBox.SelectedItem)
    End Sub
End Class
