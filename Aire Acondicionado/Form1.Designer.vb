<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        chSplit = New CheckBox()
        Panel1 = New Panel()
        Label5 = New Label()
        btnAlta = New Button()
        txtPais = New TextBox()
        txtFrigorias = New TextBox()
        txtMarca = New TextBox()
        rbFrioCalor = New RadioButton()
        rbFrioSolo = New RadioButton()
        Panel2 = New Panel()
        lblOn = New Label()
        btnModelo = New Button()
        btnMax = New Button()
        btnMin = New Button()
        btnPower = New Button()
        btnMas = New Button()
        btnMenos = New Button()
        btnOn = New Button()
        Label7 = New Label()
        txtModelo = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 0
        Label1.Text = "Marca"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 1
        Label2.Text = "Frigorías"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 2
        Label3.Text = "Pais"
        ' 
        ' chSplit
        ' 
        chSplit.AutoSize = True
        chSplit.Location = New Point(34, 150)
        chSplit.Name = "chSplit"
        chSplit.Size = New Size(49, 19)
        chSplit.TabIndex = 6
        chSplit.Text = "Split"
        chSplit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnAlta)
        Panel1.Controls.Add(txtPais)
        Panel1.Controls.Add(txtFrigorias)
        Panel1.Controls.Add(txtMarca)
        Panel1.Controls.Add(rbFrioCalor)
        Panel1.Controls.Add(rbFrioSolo)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(chSplit)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(266, 379)
        Panel1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(77, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 13
        Label5.Text = "Ingreso de Datos"
        ' 
        ' btnAlta
        ' 
        btnAlta.BackColor = Color.Black
        btnAlta.FlatStyle = FlatStyle.Popup
        btnAlta.ForeColor = SystemColors.ButtonHighlight
        btnAlta.Location = New Point(130, 266)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(106, 71)
        btnAlta.TabIndex = 12
        btnAlta.Text = "ALTA"
        btnAlta.UseVisualStyleBackColor = False
        ' 
        ' txtPais
        ' 
        txtPais.Location = New Point(86, 209)
        txtPais.Name = "txtPais"
        txtPais.Size = New Size(138, 23)
        txtPais.TabIndex = 11
        ' 
        ' txtFrigorias
        ' 
        txtFrigorias.Location = New Point(98, 91)
        txtFrigorias.Name = "txtFrigorias"
        txtFrigorias.Size = New Size(138, 23)
        txtFrigorias.TabIndex = 10
        ' 
        ' txtMarca
        ' 
        txtMarca.Location = New Point(86, 33)
        txtMarca.Name = "txtMarca"
        txtMarca.Size = New Size(138, 23)
        txtMarca.TabIndex = 9
        ' 
        ' rbFrioCalor
        ' 
        rbFrioCalor.AutoSize = True
        rbFrioCalor.Location = New Point(16, 309)
        rbFrioCalor.Name = "rbFrioCalor"
        rbFrioCalor.Size = New Size(74, 19)
        rbFrioCalor.TabIndex = 8
        rbFrioCalor.TabStop = True
        rbFrioCalor.Text = "Frio calor"
        rbFrioCalor.UseVisualStyleBackColor = True
        ' 
        ' rbFrioSolo
        ' 
        rbFrioSolo.AutoSize = True
        rbFrioSolo.Location = New Point(16, 267)
        rbFrioSolo.Name = "rbFrioSolo"
        rbFrioSolo.Size = New Size(70, 19)
        rbFrioSolo.TabIndex = 7
        rbFrioSolo.TabStop = True
        rbFrioSolo.Text = "Frío solo"
        rbFrioSolo.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(lblOn)
        Panel2.Controls.Add(btnModelo)
        Panel2.Controls.Add(btnMax)
        Panel2.Controls.Add(btnMin)
        Panel2.Controls.Add(btnPower)
        Panel2.Controls.Add(btnMas)
        Panel2.Controls.Add(btnMenos)
        Panel2.Controls.Add(btnOn)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtModelo)
        Panel2.Location = New Point(323, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(248, 379)
        Panel2.TabIndex = 8
        ' 
        ' lblOn
        ' 
        lblOn.AutoSize = True
        lblOn.Location = New Point(109, 235)
        lblOn.Name = "lblOn"
        lblOn.Size = New Size(0, 15)
        lblOn.TabIndex = 22
        ' 
        ' btnModelo
        ' 
        btnModelo.Enabled = False
        btnModelo.Location = New Point(10, 33)
        btnModelo.Name = "btnModelo"
        btnModelo.Size = New Size(75, 23)
        btnModelo.TabIndex = 21
        btnModelo.Text = "Modelo"
        btnModelo.UseVisualStyleBackColor = True
        ' 
        ' btnMax
        ' 
        btnMax.Enabled = False
        btnMax.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMax.Location = New Point(135, 323)
        btnMax.Name = "btnMax"
        btnMax.Size = New Size(59, 42)
        btnMax.TabIndex = 20
        btnMax.Text = "Max."
        btnMax.UseVisualStyleBackColor = True
        ' 
        ' btnMin
        ' 
        btnMin.Enabled = False
        btnMin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMin.Location = New Point(53, 323)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(56, 42)
        btnMin.TabIndex = 19
        btnMin.Text = "Min."
        btnMin.UseVisualStyleBackColor = True
        ' 
        ' btnPower
        ' 
        btnPower.Enabled = False
        btnPower.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPower.Location = New Point(82, 266)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(82, 40)
        btnPower.TabIndex = 18
        btnPower.Text = "POWER"
        btnPower.UseVisualStyleBackColor = True
        ' 
        ' btnMas
        ' 
        btnMas.Enabled = False
        btnMas.Font = New Font("Segoe UI", 20F)
        btnMas.Location = New Point(171, 266)
        btnMas.Name = "btnMas"
        btnMas.Size = New Size(58, 40)
        btnMas.TabIndex = 17
        btnMas.Text = "+"
        btnMas.UseVisualStyleBackColor = True
        ' 
        ' btnMenos
        ' 
        btnMenos.Enabled = False
        btnMenos.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenos.Location = New Point(18, 266)
        btnMenos.Name = "btnMenos"
        btnMenos.Size = New Size(58, 40)
        btnMenos.TabIndex = 16
        btnMenos.Text = "-"
        btnMenos.UseVisualStyleBackColor = True
        ' 
        ' btnOn
        ' 
        btnOn.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnOn.Enabled = False
        btnOn.FlatStyle = FlatStyle.Popup
        btnOn.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOn.Location = New Point(53, 109)
        btnOn.Name = "btnOn"
        btnOn.Size = New Size(141, 123)
        btnOn.TabIndex = 15
        btnOn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(77, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 15)
        Label7.TabIndex = 14
        Label7.Text = "Control Equipo"
        ' 
        ' txtModelo
        ' 
        txtModelo.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txtModelo.BorderStyle = BorderStyle.FixedSingle
        txtModelo.Location = New Point(91, 34)
        txtModelo.Name = "txtModelo"
        txtModelo.ReadOnly = True
        txtModelo.Size = New Size(125, 23)
        txtModelo.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(583, 403)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Aire Acondicionado"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chSplit As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtFrigorias As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents rbFrioCalor As RadioButton
    Friend WithEvents rbFrioSolo As RadioButton
    Friend WithEvents btnAlta As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnOn As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnMas As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnModelo As Button
    Friend WithEvents lblOn As Label

End Class
