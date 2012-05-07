<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndrePakke
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEndrePakke))
        Me.gbSokId = New System.Windows.Forms.GroupBox()
        Me.btnIdSlett = New System.Windows.Forms.Button()
        Me.btnIdEndre = New System.Windows.Forms.Button()
        Me.txtIdPakkeNavn = New System.Windows.Forms.TextBox()
        Me.lblIdPakkeNavn = New System.Windows.Forms.Label()
        Me.cbIdPakkeId = New System.Windows.Forms.ComboBox()
        Me.lblIdPakkeid = New System.Windows.Forms.Label()
        Me.gbSokNavn = New System.Windows.Forms.GroupBox()
        Me.btnNavnSlett = New System.Windows.Forms.Button()
        Me.btnNavnEndre = New System.Windows.Forms.Button()
        Me.txtNavnPakkeId = New System.Windows.Forms.TextBox()
        Me.lblNavnPakkeId = New System.Windows.Forms.Label()
        Me.cbNavnPakkeNavn = New System.Windows.Forms.ComboBox()
        Me.lblNavnPakkeNavn = New System.Windows.Forms.Label()
        Me.gbSokId.SuspendLayout()
        Me.gbSokNavn.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSokId
        '
        Me.gbSokId.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSokId.Controls.Add(Me.btnIdSlett)
        Me.gbSokId.Controls.Add(Me.btnIdEndre)
        Me.gbSokId.Controls.Add(Me.txtIdPakkeNavn)
        Me.gbSokId.Controls.Add(Me.lblIdPakkeNavn)
        Me.gbSokId.Controls.Add(Me.cbIdPakkeId)
        Me.gbSokId.Controls.Add(Me.lblIdPakkeid)
        Me.gbSokId.Location = New System.Drawing.Point(12, 140)
        Me.gbSokId.Name = "gbSokId"
        Me.gbSokId.Size = New System.Drawing.Size(260, 102)
        Me.gbSokId.TabIndex = 8
        Me.gbSokId.TabStop = False
        Me.gbSokId.Text = "Pakkesøk på id"
        '
        'btnIdSlett
        '
        Me.btnIdSlett.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIdSlett.Location = New System.Drawing.Point(98, 73)
        Me.btnIdSlett.Name = "btnIdSlett"
        Me.btnIdSlett.Size = New System.Drawing.Size(75, 23)
        Me.btnIdSlett.TabIndex = 10
        Me.btnIdSlett.Text = "S&lett"
        Me.btnIdSlett.UseVisualStyleBackColor = True
        '
        'btnIdEndre
        '
        Me.btnIdEndre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIdEndre.Location = New System.Drawing.Point(179, 70)
        Me.btnIdEndre.Name = "btnIdEndre"
        Me.btnIdEndre.Size = New System.Drawing.Size(75, 23)
        Me.btnIdEndre.TabIndex = 11
        Me.btnIdEndre.Text = "E&ndre"
        Me.btnIdEndre.UseVisualStyleBackColor = True
        '
        'txtIdPakkeNavn
        '
        Me.txtIdPakkeNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdPakkeNavn.Enabled = False
        Me.txtIdPakkeNavn.Location = New System.Drawing.Point(96, 44)
        Me.txtIdPakkeNavn.Name = "txtIdPakkeNavn"
        Me.txtIdPakkeNavn.Size = New System.Drawing.Size(158, 20)
        Me.txtIdPakkeNavn.TabIndex = 10
        '
        'lblIdPakkeNavn
        '
        Me.lblIdPakkeNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIdPakkeNavn.AutoSize = True
        Me.lblIdPakkeNavn.Location = New System.Drawing.Point(15, 47)
        Me.lblIdPakkeNavn.Name = "lblIdPakkeNavn"
        Me.lblIdPakkeNavn.Size = New System.Drawing.Size(33, 13)
        Me.lblIdPakkeNavn.TabIndex = 9
        Me.lblIdPakkeNavn.Text = "Navn"
        '
        'cbIdPakkeId
        '
        Me.cbIdPakkeId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbIdPakkeId.FormattingEnabled = True
        Me.cbIdPakkeId.Location = New System.Drawing.Point(96, 17)
        Me.cbIdPakkeId.Name = "cbIdPakkeId"
        Me.cbIdPakkeId.Size = New System.Drawing.Size(158, 21)
        Me.cbIdPakkeId.TabIndex = 8
        '
        'lblIdPakkeid
        '
        Me.lblIdPakkeid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIdPakkeid.AutoSize = True
        Me.lblIdPakkeid.Location = New System.Drawing.Point(15, 20)
        Me.lblIdPakkeid.Name = "lblIdPakkeid"
        Me.lblIdPakkeid.Size = New System.Drawing.Size(16, 13)
        Me.lblIdPakkeid.TabIndex = 7
        Me.lblIdPakkeid.Text = "&Id"
        '
        'gbSokNavn
        '
        Me.gbSokNavn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSokNavn.Controls.Add(Me.btnNavnSlett)
        Me.gbSokNavn.Controls.Add(Me.btnNavnEndre)
        Me.gbSokNavn.Controls.Add(Me.txtNavnPakkeId)
        Me.gbSokNavn.Controls.Add(Me.lblNavnPakkeId)
        Me.gbSokNavn.Controls.Add(Me.cbNavnPakkeNavn)
        Me.gbSokNavn.Controls.Add(Me.lblNavnPakkeNavn)
        Me.gbSokNavn.Location = New System.Drawing.Point(12, 12)
        Me.gbSokNavn.Name = "gbSokNavn"
        Me.gbSokNavn.Size = New System.Drawing.Size(260, 104)
        Me.gbSokNavn.TabIndex = 7
        Me.gbSokNavn.TabStop = False
        Me.gbSokNavn.Text = "Pakkesøk på navn"
        '
        'btnNavnSlett
        '
        Me.btnNavnSlett.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavnSlett.Location = New System.Drawing.Point(98, 73)
        Me.btnNavnSlett.Name = "btnNavnSlett"
        Me.btnNavnSlett.Size = New System.Drawing.Size(75, 23)
        Me.btnNavnSlett.TabIndex = 9
        Me.btnNavnSlett.Text = "&Slett"
        Me.btnNavnSlett.UseVisualStyleBackColor = True
        '
        'btnNavnEndre
        '
        Me.btnNavnEndre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavnEndre.Location = New System.Drawing.Point(179, 73)
        Me.btnNavnEndre.Name = "btnNavnEndre"
        Me.btnNavnEndre.Size = New System.Drawing.Size(75, 23)
        Me.btnNavnEndre.TabIndex = 5
        Me.btnNavnEndre.Text = "&Endre"
        Me.btnNavnEndre.UseVisualStyleBackColor = True
        '
        'txtNavnPakkeId
        '
        Me.txtNavnPakkeId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNavnPakkeId.Enabled = False
        Me.txtNavnPakkeId.Location = New System.Drawing.Point(96, 47)
        Me.txtNavnPakkeId.Name = "txtNavnPakkeId"
        Me.txtNavnPakkeId.Size = New System.Drawing.Size(158, 20)
        Me.txtNavnPakkeId.TabIndex = 4
        '
        'lblNavnPakkeId
        '
        Me.lblNavnPakkeId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNavnPakkeId.AutoSize = True
        Me.lblNavnPakkeId.Location = New System.Drawing.Point(15, 50)
        Me.lblNavnPakkeId.Name = "lblNavnPakkeId"
        Me.lblNavnPakkeId.Size = New System.Drawing.Size(16, 13)
        Me.lblNavnPakkeId.TabIndex = 3
        Me.lblNavnPakkeId.Text = "Id"
        '
        'cbNavnPakkeNavn
        '
        Me.cbNavnPakkeNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbNavnPakkeNavn.FormattingEnabled = True
        Me.cbNavnPakkeNavn.Location = New System.Drawing.Point(96, 20)
        Me.cbNavnPakkeNavn.Name = "cbNavnPakkeNavn"
        Me.cbNavnPakkeNavn.Size = New System.Drawing.Size(158, 21)
        Me.cbNavnPakkeNavn.TabIndex = 2
        '
        'lblNavnPakkeNavn
        '
        Me.lblNavnPakkeNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNavnPakkeNavn.AutoSize = True
        Me.lblNavnPakkeNavn.Location = New System.Drawing.Point(15, 23)
        Me.lblNavnPakkeNavn.Name = "lblNavnPakkeNavn"
        Me.lblNavnPakkeNavn.Size = New System.Drawing.Size(33, 13)
        Me.lblNavnPakkeNavn.TabIndex = 1
        Me.lblNavnPakkeNavn.Text = "&Navn"
        '
        'frmEndrePakke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 255)
        Me.Controls.Add(Me.gbSokId)
        Me.Controls.Add(Me.gbSokNavn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEndrePakke"
        Me.Text = "Endre pakke"
        Me.gbSokId.ResumeLayout(False)
        Me.gbSokId.PerformLayout()
        Me.gbSokNavn.ResumeLayout(False)
        Me.gbSokNavn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSokId As System.Windows.Forms.GroupBox
    Friend WithEvents btnIdEndre As System.Windows.Forms.Button
    Friend WithEvents txtIdPakkeNavn As System.Windows.Forms.TextBox
    Friend WithEvents lblIdPakkeNavn As System.Windows.Forms.Label
    Friend WithEvents cbIdPakkeId As System.Windows.Forms.ComboBox
    Friend WithEvents lblIdPakkeid As System.Windows.Forms.Label
    Friend WithEvents gbSokNavn As System.Windows.Forms.GroupBox
    Friend WithEvents btnNavnEndre As System.Windows.Forms.Button
    Friend WithEvents txtNavnPakkeId As System.Windows.Forms.TextBox
    Friend WithEvents lblNavnPakkeId As System.Windows.Forms.Label
    Friend WithEvents cbNavnPakkeNavn As System.Windows.Forms.ComboBox
    Friend WithEvents lblNavnPakkeNavn As System.Windows.Forms.Label
    Friend WithEvents btnIdSlett As System.Windows.Forms.Button
    Friend WithEvents btnNavnSlett As System.Windows.Forms.Button
End Class
