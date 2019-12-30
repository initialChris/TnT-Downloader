Imports System.IO
Imports System.Net

Partial Public Class Form1

    Function sizeFormatter(ByVal sizeString As String, ByVal precision As Integer)
        Dim size As Double
        Dim size_prefix As String
        Double.TryParse(sizeString, size)


        If (size >= 1024 * 1024 * 1024) Then       ' Se il file ha l'ordine di grandezza del Gigabyte
            size = size / (1024 * 1024 * 1024)
            size = Math.Round(size, precision, MidpointRounding.AwayFromZero)
            size_prefix = " GB"

        ElseIf (size >= 1024 * 1024) Then          ' Se il file ha l'ordine di grandezza del Megabyte
            size = size / (1024 * 1024)
            size = Math.Round(size, precision, MidpointRounding.AwayFromZero)
            size_prefix = " MB"
        ElseIf (size >= 1024) Then                 ' Se il file ha l'ordine di grandezza del Kilobyte
            size = size / (1024)
            size = Math.Round(size, precision, MidpointRounding.AwayFromZero)
            size_prefix = " kB"
        Else                                        ' Se il file ha l'ordine di grandezza del byte
            size_prefix = " B"
        End If

        Return (size).ToString() & size_prefix

    End Function

    Function categoryFormatter(ByVal categoryString)

        '1  = Film TV e programmi
        '2  = Musica
        '3  = E Books
        '4  = Film
        '6  = Linux
        '7  = Anime
        '8  = Cartoni
        '9  = Macintosh
        '10 = Windows Software
        '11 = Pc Game
        '12 = Playstation
        '13 = Students Releases
        '14 = Documentari
        '21 = Video Musicali
        '22 = Sport
        '23 = Teatro
        '24 = Wrestling
        '25 = Varie
        '26 = Xbox
        '27 = Immagini sfondi
        '28 = Altri Giochi
        '29 = Serie TV
        '30 = Fumetteria
        '31 = Trash
        '32 = Nintendo
        '34 = A Book
        '35 = Podcast
        '36 = Edicola
        '37 = Mobile

        Dim categoryNumber As Integer
        Integer.TryParse(categoryString, categoryNumber)


        Select Case categoryNumber
            Case 1
                categoryString = "Film TV e programmi"
            Case 2
                categoryString = "Musica"
            Case 3
                categoryString = "E Books"
            Case 4
                categoryString = "Film"
            Case 6
                categoryString = "Linux"
            Case 7
                categoryString = "Anime"
            Case 8
                categoryString = "Cartoni"
            Case 9
                categoryString = "Macintosh"
            Case 10
                categoryString = "Windows Software"
            Case 11
                categoryString = "Pc Game"
            Case 12
                categoryString = "Playstation"
            Case 13
                categoryString = "Students Releases"
            Case 14
                categoryString = "Documentari"
            Case 21
                categoryString = "Video Musicali"
            Case 22
                categoryString = "Sport"
            Case 23
                categoryString = "Teatro"
            Case 24
                categoryString = "Wrestling"
            Case 25
                categoryString = "Varie"
            Case 26
                categoryString = "Xbox"
            Case 27
                categoryString = "Immagini sfondi"
            Case 28
                categoryString = "Altri Giochi"
            Case 29
                categoryString = "Serie TV"
            Case 30
                categoryString = "Fumetteria"
            Case 31
                categoryString = "Trash"
            Case 32
                categoryString = "Nintendo"
            Case 34
                categoryString = "A Book"
            Case 35
                categoryString = "Podcast"
            Case 36
                categoryString = "Edicola"
            Case 37
                categoryString = "Mobile"

            Case Else
                categoryString = "N/A"
        End Select

        Return categoryString
    End Function

    Sub filterDataGrid(ByVal filterString As String, ByVal columnFilter As String, ByVal categoryFilter As String)
        If categoryFilter = "-- Tutto --" Then
            categoryFilter = ""
        Else
            categoryFilter = " AND CATEGORIA Like '" & categoryFilter & "'"
        End If

        If (dt.Rows.Count > 0) Then
            Try
                dt.DefaultView.RowFilter = columnsFilter & " Like '%" & filterString & "%'" & categoryFilter
            Catch ex As Exception
                'Find_Textbox.Text = Find_Textbox.Text.Substring(0, Find_Textbox.Text.Length - 1)
            End Try

            'DataGridView1.DataSource = filter_dt
            If (filterString = "" And categoryFilter = "") Then
                nFind_Label.Text = "Relase filtrate: " & 0
            Else
                nFind_Label.Text = "Relase filtrate: " & dt.DefaultView.Count
            End If
        End If

    End Sub

    Function fileLoader(Optional ByVal strFileName As String = "")
        Dim fd As OpenFileDialog = New OpenFileDialog()


        fd.Title = "Open File Dialog"
        If (strFileName = "") Then
            fd.InitialDirectory = "C:\"
        Else
            fd.InitialDirectory = FilePosition_Textbox.Text
        End If
        fd.Filter = "File csv (*.csv*)|*.csv*|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Return fd.FileName
        Else
            Return strFileName ' Se non è selezionato nessun file ritorna il valore del percorso precedente
        End If


    End Function

    Private Sub copyText(sender As TextBox, e As EventArgs)

        Dim textToCopy As String
        textToCopy = sender.Text
        If (Not (textToCopy = "" Or textToCopy = "Testo copiato")) Then
            My.Computer.Clipboard.SetText(textToCopy)

            Dim timing As New Timer
            timing.Interval = 2000
            Dim precText = sender.Text
            AddHandler timing.Tick, Sub(sender2, eventargs2)
                                        sender.Text = precText
                                        timing.Stop()
                                        sender.BackColor = Color.White
                                    End Sub
            timing.Start()

            sender.Text = "Testo copiato"
            sender.BackColor = Color.LightYellow
        End If
    End Sub

    Private Sub CheckChanged(sender As Object, e As EventArgs)
        columnsHider()
    End Sub


    Sub columnsHider()
        If (loaded = True) Then
            DataGridView1.Columns(0).Visible = DateVisibility.Checked
            DataGridView1.Columns(1).Visible = HashVisibility.Checked
            DataGridView1.Columns(2).Visible = topicVisibility.Checked
            DataGridView1.Columns(3).Visible = postVisibility.Checked
            DataGridView1.Columns(4).Visible = AuthorVisibility.Checked
            DataGridView1.Columns(5).Visible = TitleVisibility.Checked
            DataGridView1.Columns(6).Visible = DescriptionVisibility.Checked
            DataGridView1.Columns(7).Visible = SizeVisibility.Checked
            DataGridView1.Columns(8).Visible = CategoryVisibilty.Checked
        End If
    End Sub

    Function getMagnet(ByVal topic)
        Dim link As String
        If (Not topic = "") Then
            Try
                link = "https://web.archive.org/web/http://forum.tntvillage.scambioetico.org/index.php?showtopic=" & topic
                Dim request As WebRequest = WebRequest.Create(link)
                Using response As WebResponse = request.GetResponse()
                    Using reader As New StreamReader(response.GetResponseStream())
                        Dim html As String = reader.ReadToEnd()

                        Dim subhtml As String = html.Substring(0, html.IndexOf("Magnet link") - 9)
                        subhtml = subhtml.Substring(subhtml.LastIndexOf("""") + 1)
                        subhtml = subhtml.Substring(subhtml.IndexOf("m"))
                        Return subhtml

                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Errore: " & ex.Message, MsgBoxStyle.Critical)
                Return ""
            End Try


        End If
        Return ""

    End Function

    Sub loadData(ByVal folder As String)

        Dim i As Long = 0
        Dim row As DataRow
        count = 0
        dt.Clear()
        dt.Columns.Clear()
        dt.DefaultView.Sort = ""
        DataGridView1.DataSource = False
        Load_Button.Enabled = False

        If (Not folder = "") Then ' Se è presente un percorso
            loadingLabel.Visible = True
            Application.DoEvents()
            Try
                Dim SR As StreamReader = New StreamReader(folder)
                Dim line As String = SR.ReadLine()
                Dim strArray As String() = line.Split(";"c) ' Delimitatore = ';'

                For Each s As String In strArray ' Aggiungi le colonne 
                    dt.Columns.Add(s, Type.GetType("System.String")) ' Il nome delle colonne è uguale ai campi della prima riga
                Next

                If Not dt.Columns.Count = 9 Then
                    Throw New System.Exception("formato file non valido.")
                End If

                ' Colonna 0 = DATA:           Data in formato ISO 8601
                ' Colonna 1 = HASH:           info_hash codicato in esadecimale
                ' Colonna 2 = TOPIC:          ID numerico relativo alla discussione (forum TNTVillage)
                ' Colonna 3 = POST:           ID numerico relativo al messaggio (forum TNTVillage)
                ' Colonna 4 = AUTORE:         nome utente dell'autore della release
                ' Colonna 5 = TITOLO:         titolo della release
                ' Colonna 6 = DESCRIZIONE:    metadati relativi alla release
                ' Colonna 7 = DIMENSIONE:     dimensione complessiva dei file della release (in byte)
                ' Colonna 8 = CATEGORIA:      ID numerico relativo alla categoria della release

                Do  ' Per ogni riga
                    line = SR.ReadLine
                    If Not line = String.Empty Then
                        row = dt.NewRow()
                        Dim s() As String
                        s = line.Split(";"c)

                        s(7) = sizeFormatter(s(7), 2)
                        s(8) = categoryFormatter(s(8))
                        row.ItemArray = s
                        dt.Rows.Add(row)
                    Else
                        Exit Do
                    End If
                Loop
                'dt.Columns(1).ColumnMapping = MappingType.Hidden

                'filter_dt = dt
                dt.DefaultView.Sort = "CATEGORIA ASC, TITOLO ASC"
                DataGridView1.DataSource = dt
                DataGridView1.Refresh()
                'DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView1.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView1.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView1.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                DataGridView1.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                loaded = True
                columnsHider()
                My.Settings.LastAddress = folder
                My.Settings.Save()
                nRelase_Label.Text = "Relase trovate: " & dt.Rows.Count

            Catch ex As Exception
                MsgBox("Errore: " & ex.Message, MsgBoxStyle.Exclamation)
                loaded = False
            End Try
        End If
        loadingLabel.Visible = False
        Load_Button.Enabled = True
    End Sub
End Class