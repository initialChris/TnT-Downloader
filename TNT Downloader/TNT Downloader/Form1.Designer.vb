<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FilePosition_Textbox = New System.Windows.Forms.TextBox()
        Me.Load_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nRelase_Label = New System.Windows.Forms.Label()
        Me.Topic_Textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Post_Textbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Title_Textbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Author_Textbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Size_Textbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Data_Textbox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Category_Textbox = New System.Windows.Forms.TextBox()
        Me.Description_Textbox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Find_Textbox = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nFind_Label = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Hash_Textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Magnet_Textbox = New System.Windows.Forms.TextBox()
        Me.Dowload_Button = New System.Windows.Forms.Button()
        Me.Magnet_Button = New System.Windows.Forms.Button()
        Me.OpenPost_Button = New System.Windows.Forms.Button()
        Me.postVisibility = New System.Windows.Forms.CheckBox()
        Me.topicVisibility = New System.Windows.Forms.CheckBox()
        Me.DateVisibility = New System.Windows.Forms.CheckBox()
        Me.AuthorVisibility = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CategoryVisibilty = New System.Windows.Forms.CheckBox()
        Me.SizeVisibility = New System.Windows.Forms.CheckBox()
        Me.DescriptionVisibility = New System.Windows.Forms.CheckBox()
        Me.TitleVisibility = New System.Windows.Forms.CheckBox()
        Me.HashVisibility = New System.Windows.Forms.CheckBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.loadingLabel = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(815, 653)
        Me.DataGridView1.TabIndex = 0
        '
        'FilePosition_Textbox
        '
        Me.FilePosition_Textbox.BackColor = System.Drawing.Color.White
        Me.FilePosition_Textbox.Location = New System.Drawing.Point(9, 35)
        Me.FilePosition_Textbox.Name = "FilePosition_Textbox"
        Me.FilePosition_Textbox.ReadOnly = True
        Me.FilePosition_Textbox.Size = New System.Drawing.Size(388, 20)
        Me.FilePosition_Textbox.TabIndex = 1
        Me.FilePosition_Textbox.Text = " E:\Chris\Documenti\41) Varie\TNT Village Relase\dump_release_tntvillage_2019-08-" &
    "30.csv"
        '
        'Load_Button
        '
        Me.Load_Button.Enabled = False
        Me.Load_Button.Location = New System.Drawing.Point(322, 65)
        Me.Load_Button.Name = "Load_Button"
        Me.Load_Button.Size = New System.Drawing.Size(75, 44)
        Me.Load_Button.TabIndex = 2
        Me.Load_Button.Text = "Carica"
        Me.Load_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Percorso Database:"
        '
        'nRelase_Label
        '
        Me.nRelase_Label.AutoSize = True
        Me.nRelase_Label.Location = New System.Drawing.Point(6, 84)
        Me.nRelase_Label.Name = "nRelase_Label"
        Me.nRelase_Label.Size = New System.Drawing.Size(92, 13)
        Me.nRelase_Label.TabIndex = 4
        Me.nRelase_Label.Text = "Relase Trovate: 0"
        '
        'Topic_Textbox
        '
        Me.Topic_Textbox.BackColor = System.Drawing.Color.White
        Me.Topic_Textbox.Location = New System.Drawing.Point(80, 19)
        Me.Topic_Textbox.Name = "Topic_Textbox"
        Me.Topic_Textbox.ReadOnly = True
        Me.Topic_Textbox.Size = New System.Drawing.Size(101, 20)
        Me.Topic_Textbox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Topic"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Post"
        '
        'Post_Textbox
        '
        Me.Post_Textbox.BackColor = System.Drawing.Color.White
        Me.Post_Textbox.Location = New System.Drawing.Point(251, 19)
        Me.Post_Textbox.Name = "Post_Textbox"
        Me.Post_Textbox.ReadOnly = True
        Me.Post_Textbox.Size = New System.Drawing.Size(136, 20)
        Me.Post_Textbox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Titolo"
        '
        'Title_Textbox
        '
        Me.Title_Textbox.BackColor = System.Drawing.Color.White
        Me.Title_Textbox.Location = New System.Drawing.Point(80, 45)
        Me.Title_Textbox.Multiline = True
        Me.Title_Textbox.Name = "Title_Textbox"
        Me.Title_Textbox.ReadOnly = True
        Me.Title_Textbox.Size = New System.Drawing.Size(307, 31)
        Me.Title_Textbox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Autore"
        '
        'Author_Textbox
        '
        Me.Author_Textbox.BackColor = System.Drawing.Color.White
        Me.Author_Textbox.Location = New System.Drawing.Point(80, 82)
        Me.Author_Textbox.Name = "Author_Textbox"
        Me.Author_Textbox.ReadOnly = True
        Me.Author_Textbox.Size = New System.Drawing.Size(307, 20)
        Me.Author_Textbox.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Dimensioni"
        '
        'Size_Textbox
        '
        Me.Size_Textbox.BackColor = System.Drawing.Color.White
        Me.Size_Textbox.Location = New System.Drawing.Point(80, 108)
        Me.Size_Textbox.Name = "Size_Textbox"
        Me.Size_Textbox.ReadOnly = True
        Me.Size_Textbox.Size = New System.Drawing.Size(101, 20)
        Me.Size_Textbox.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Data"
        '
        'Data_Textbox
        '
        Me.Data_Textbox.BackColor = System.Drawing.Color.White
        Me.Data_Textbox.Location = New System.Drawing.Point(251, 108)
        Me.Data_Textbox.Name = "Data_Textbox"
        Me.Data_Textbox.ReadOnly = True
        Me.Data_Textbox.Size = New System.Drawing.Size(136, 20)
        Me.Data_Textbox.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Categoria"
        '
        'Category_Textbox
        '
        Me.Category_Textbox.BackColor = System.Drawing.Color.White
        Me.Category_Textbox.Location = New System.Drawing.Point(80, 134)
        Me.Category_Textbox.Name = "Category_Textbox"
        Me.Category_Textbox.ReadOnly = True
        Me.Category_Textbox.Size = New System.Drawing.Size(101, 20)
        Me.Category_Textbox.TabIndex = 17
        '
        'Description_Textbox
        '
        Me.Description_Textbox.BackColor = System.Drawing.Color.White
        Me.Description_Textbox.Location = New System.Drawing.Point(80, 160)
        Me.Description_Textbox.Multiline = True
        Me.Description_Textbox.Name = "Description_Textbox"
        Me.Description_Textbox.ReadOnly = True
        Me.Description_Textbox.Size = New System.Drawing.Size(307, 83)
        Me.Description_Textbox.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Descrizione"
        '
        'Find_Textbox
        '
        Me.Find_Textbox.Location = New System.Drawing.Point(6, 19)
        Me.Find_Textbox.Name = "Find_Textbox"
        Me.Find_Textbox.Size = New System.Drawing.Size(261, 20)
        Me.Find_Textbox.TabIndex = 22
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(296, 34)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton1.TabIndex = 23
        Me.RadioButton1.Text = "Descrizione"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(296, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton2.TabIndex = 24
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Titolo"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox1.Controls.Add(Me.nFind_Label)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Find_Textbox)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.nRelase_Label)
        Me.GroupBox1.Location = New System.Drawing.Point(833, 546)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 106)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ricerca"
        '
        'nFind_Label
        '
        Me.nFind_Label.AutoSize = True
        Me.nFind_Label.Location = New System.Drawing.Point(6, 69)
        Me.nFind_Label.Name = "nFind_Label"
        Me.nFind_Label.Size = New System.Drawing.Size(86, 13)
        Me.nFind_Label.TabIndex = 26
        Me.nFind_Label.Text = "Relase Filtrate: 0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Hash_Textbox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Magnet_Textbox)
        Me.GroupBox2.Controls.Add(Me.Dowload_Button)
        Me.GroupBox2.Controls.Add(Me.Magnet_Button)
        Me.GroupBox2.Controls.Add(Me.OpenPost_Button)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Topic_Textbox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Post_Textbox)
        Me.GroupBox2.Controls.Add(Me.Description_Textbox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Title_Textbox)
        Me.GroupBox2.Controls.Add(Me.Category_Textbox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Author_Textbox)
        Me.GroupBox2.Controls.Add(Me.Data_Textbox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Size_Textbox)
        Me.GroupBox2.Location = New System.Drawing.Point(833, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 407)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Relase"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(214, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Hash"
        '
        'Hash_Textbox
        '
        Me.Hash_Textbox.BackColor = System.Drawing.Color.White
        Me.Hash_Textbox.Location = New System.Drawing.Point(252, 134)
        Me.Hash_Textbox.Name = "Hash_Textbox"
        Me.Hash_Textbox.ReadOnly = True
        Me.Hash_Textbox.Size = New System.Drawing.Size(135, 20)
        Me.Hash_Textbox.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Magnet URI:"
        '
        'Magnet_Textbox
        '
        Me.Magnet_Textbox.BackColor = System.Drawing.Color.White
        Me.Magnet_Textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Magnet_Textbox.Location = New System.Drawing.Point(6, 273)
        Me.Magnet_Textbox.Multiline = True
        Me.Magnet_Textbox.Name = "Magnet_Textbox"
        Me.Magnet_Textbox.ReadOnly = True
        Me.Magnet_Textbox.Size = New System.Drawing.Size(381, 99)
        Me.Magnet_Textbox.TabIndex = 24
        '
        'Dowload_Button
        '
        Me.Dowload_Button.Location = New System.Drawing.Point(291, 378)
        Me.Dowload_Button.Name = "Dowload_Button"
        Me.Dowload_Button.Size = New System.Drawing.Size(96, 23)
        Me.Dowload_Button.TabIndex = 23
        Me.Dowload_Button.Text = "Scarica"
        Me.Dowload_Button.UseVisualStyleBackColor = True
        '
        'Magnet_Button
        '
        Me.Magnet_Button.Location = New System.Drawing.Point(4, 378)
        Me.Magnet_Button.Name = "Magnet_Button"
        Me.Magnet_Button.Size = New System.Drawing.Size(81, 23)
        Me.Magnet_Button.TabIndex = 22
        Me.Magnet_Button.Text = "Leggi Magnet "
        Me.Magnet_Button.UseVisualStyleBackColor = True
        '
        'OpenPost_Button
        '
        Me.OpenPost_Button.Location = New System.Drawing.Point(202, 378)
        Me.OpenPost_Button.Name = "OpenPost_Button"
        Me.OpenPost_Button.Size = New System.Drawing.Size(83, 23)
        Me.OpenPost_Button.TabIndex = 21
        Me.OpenPost_Button.Text = "Apri Post"
        Me.OpenPost_Button.UseVisualStyleBackColor = True
        '
        'postVisibility
        '
        Me.postVisibility.AutoSize = True
        Me.postVisibility.Location = New System.Drawing.Point(6, 69)
        Me.postVisibility.Name = "postVisibility"
        Me.postVisibility.Size = New System.Drawing.Size(47, 17)
        Me.postVisibility.TabIndex = 27
        Me.postVisibility.Text = "Post"
        Me.postVisibility.UseVisualStyleBackColor = True
        '
        'topicVisibility
        '
        Me.topicVisibility.AutoSize = True
        Me.topicVisibility.Location = New System.Drawing.Point(59, 69)
        Me.topicVisibility.Name = "topicVisibility"
        Me.topicVisibility.Size = New System.Drawing.Size(53, 17)
        Me.topicVisibility.TabIndex = 28
        Me.topicVisibility.Text = "Topic"
        Me.topicVisibility.UseVisualStyleBackColor = True
        '
        'DateVisibility
        '
        Me.DateVisibility.AutoSize = True
        Me.DateVisibility.Location = New System.Drawing.Point(118, 69)
        Me.DateVisibility.Name = "DateVisibility"
        Me.DateVisibility.Size = New System.Drawing.Size(49, 17)
        Me.DateVisibility.TabIndex = 29
        Me.DateVisibility.Text = "Data"
        Me.DateVisibility.UseVisualStyleBackColor = True
        '
        'AuthorVisibility
        '
        Me.AuthorVisibility.AutoSize = True
        Me.AuthorVisibility.Location = New System.Drawing.Point(173, 69)
        Me.AuthorVisibility.Name = "AuthorVisibility"
        Me.AuthorVisibility.Size = New System.Drawing.Size(57, 17)
        Me.AuthorVisibility.TabIndex = 30
        Me.AuthorVisibility.Text = "Autore"
        Me.AuthorVisibility.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CategoryVisibilty)
        Me.GroupBox3.Controls.Add(Me.SizeVisibility)
        Me.GroupBox3.Controls.Add(Me.DescriptionVisibility)
        Me.GroupBox3.Controls.Add(Me.TitleVisibility)
        Me.GroupBox3.Controls.Add(Me.HashVisibility)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.AuthorVisibility)
        Me.GroupBox3.Controls.Add(Me.FilePosition_Textbox)
        Me.GroupBox3.Controls.Add(Me.DateVisibility)
        Me.GroupBox3.Controls.Add(Me.Load_Button)
        Me.GroupBox3.Controls.Add(Me.topicVisibility)
        Me.GroupBox3.Controls.Add(Me.postVisibility)
        Me.GroupBox3.Location = New System.Drawing.Point(833, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(403, 115)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dataset"
        '
        'CategoryVisibilty
        '
        Me.CategoryVisibilty.AutoSize = True
        Me.CategoryVisibilty.Checked = True
        Me.CategoryVisibilty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CategoryVisibilty.Location = New System.Drawing.Point(234, 92)
        Me.CategoryVisibilty.Name = "CategoryVisibilty"
        Me.CategoryVisibilty.Size = New System.Drawing.Size(71, 17)
        Me.CategoryVisibilty.TabIndex = 35
        Me.CategoryVisibilty.Text = "Categoria"
        Me.CategoryVisibilty.UseVisualStyleBackColor = True
        '
        'SizeVisibility
        '
        Me.SizeVisibility.AutoSize = True
        Me.SizeVisibility.Checked = True
        Me.SizeVisibility.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SizeVisibility.Location = New System.Drawing.Point(151, 92)
        Me.SizeVisibility.Name = "SizeVisibility"
        Me.SizeVisibility.Size = New System.Drawing.Size(77, 17)
        Me.SizeVisibility.TabIndex = 34
        Me.SizeVisibility.Text = "Dimensioni"
        Me.SizeVisibility.UseVisualStyleBackColor = True
        '
        'DescriptionVisibility
        '
        Me.DescriptionVisibility.AutoSize = True
        Me.DescriptionVisibility.Checked = True
        Me.DescriptionVisibility.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DescriptionVisibility.Location = New System.Drawing.Point(64, 92)
        Me.DescriptionVisibility.Name = "DescriptionVisibility"
        Me.DescriptionVisibility.Size = New System.Drawing.Size(81, 17)
        Me.DescriptionVisibility.TabIndex = 33
        Me.DescriptionVisibility.Text = "Descrizione"
        Me.DescriptionVisibility.UseVisualStyleBackColor = True
        '
        'TitleVisibility
        '
        Me.TitleVisibility.AutoSize = True
        Me.TitleVisibility.Checked = True
        Me.TitleVisibility.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleVisibility.Location = New System.Drawing.Point(6, 92)
        Me.TitleVisibility.Name = "TitleVisibility"
        Me.TitleVisibility.Size = New System.Drawing.Size(52, 17)
        Me.TitleVisibility.TabIndex = 32
        Me.TitleVisibility.Text = "Titolo"
        Me.TitleVisibility.UseVisualStyleBackColor = True
        '
        'HashVisibility
        '
        Me.HashVisibility.AutoSize = True
        Me.HashVisibility.Location = New System.Drawing.Point(234, 69)
        Me.HashVisibility.Name = "HashVisibility"
        Me.HashVisibility.Size = New System.Drawing.Size(51, 17)
        Me.HashVisibility.TabIndex = 31
        Me.HashVisibility.Text = "Hash"
        Me.HashVisibility.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.VersionLabel.Location = New System.Drawing.Point(1095, 655)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(141, 19)
        Me.VersionLabel.TabIndex = 32
        Me.VersionLabel.Text = "V0.1"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VersionLabel.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(845, 655)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(212, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "(Doppio click sui campi di testo per copiare)"
        '
        'loadingLabel
        '
        Me.loadingLabel.AutoSize = True
        Me.loadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadingLabel.Location = New System.Drawing.Point(327, 356)
        Me.loadingLabel.Name = "loadingLabel"
        Me.loadingLabel.Size = New System.Drawing.Size(137, 20)
        Me.loadingLabel.TabIndex = 28
        Me.loadingLabel.Text = "CARICAMENTO"
        Me.loadingLabel.Visible = False
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DisplayMember = "1"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"-- Tutto --", "A Book", "Altri Giochi", "Anime", "Cartoni", "Documentari", "E Books", "Edicola", "Film", "Film TV e programmi", "Fumetteria", "Immagini sfondi", "Linux", "Macintosh", "Mobile", "Musica", "Nintendo", "Pc Game", "Playstation", "Podcast", "Serie TV", "Sport", "Students Releases", "Teatro", "Trash", "Varie", "Video Musicali", "Windows Software", "Wrestling", "Xbox"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(73, 45)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(194, 21)
        Me.CategoryComboBox.Sorted = True
        Me.CategoryComboBox.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Categoria: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 677)
        Me.Controls.Add(Me.loadingLabel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "TnT Downloader"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FilePosition_Textbox As TextBox
    Friend WithEvents Load_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nRelase_Label As Label
    Friend WithEvents Topic_Textbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Post_Textbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Title_Textbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Author_Textbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Size_Textbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Data_Textbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Category_Textbox As TextBox
    Friend WithEvents Description_Textbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Find_Textbox As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nFind_Label As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Magnet_Textbox As TextBox
    Friend WithEvents Dowload_Button As Button
    Friend WithEvents Magnet_Button As Button
    Friend WithEvents OpenPost_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents postVisibility As CheckBox
    Friend WithEvents topicVisibility As CheckBox
    Friend WithEvents DateVisibility As CheckBox
    Friend WithEvents AuthorVisibility As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Hash_Textbox As TextBox
    Friend WithEvents HashVisibility As CheckBox
    Friend WithEvents CategoryVisibilty As CheckBox
    Friend WithEvents SizeVisibility As CheckBox
    Friend WithEvents DescriptionVisibility As CheckBox
    Friend WithEvents TitleVisibility As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents loadingLabel As Label
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Label13 As Label
End Class
