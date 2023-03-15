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
        btnCalcularPromedio = New Button()
        txtPromedioEstudiante1 = New TextBox()
        txtPromedioEstudiante2 = New TextBox()
        txtPromedioEstudiante3 = New TextBox()
        txtPromedioEstudiante4 = New TextBox()
        txtPromedioEstudiante5 = New TextBox()
        txtPromedioClase = New TextBox()
        SuspendLayout()
        ' 
        ' btnCalcularPromedio
        ' 
        btnCalcularPromedio.Location = New Point(12, 409)
        btnCalcularPromedio.Name = "btnCalcularPromedio"
        btnCalcularPromedio.Size = New Size(199, 29)
        btnCalcularPromedio.TabIndex = 0
        btnCalcularPromedio.Text = "Calcular Promedio"
        btnCalcularPromedio.UseVisualStyleBackColor = True
        ' 
        ' txtPromedioEstudiante1
        ' 
        txtPromedioEstudiante1.Location = New Point(314, 33)
        txtPromedioEstudiante1.Name = "txtPromedioEstudiante1"
        txtPromedioEstudiante1.Size = New Size(125, 27)
        txtPromedioEstudiante1.TabIndex = 1
        ' 
        ' txtPromedioEstudiante2
        ' 
        txtPromedioEstudiante2.Location = New Point(314, 81)
        txtPromedioEstudiante2.Name = "txtPromedioEstudiante2"
        txtPromedioEstudiante2.Size = New Size(125, 27)
        txtPromedioEstudiante2.TabIndex = 2
        ' 
        ' txtPromedioEstudiante3
        ' 
        txtPromedioEstudiante3.Location = New Point(314, 114)
        txtPromedioEstudiante3.Name = "txtPromedioEstudiante3"
        txtPromedioEstudiante3.Size = New Size(125, 27)
        txtPromedioEstudiante3.TabIndex = 3
        ' 
        ' txtPromedioEstudiante4
        ' 
        txtPromedioEstudiante4.Location = New Point(314, 162)
        txtPromedioEstudiante4.Name = "txtPromedioEstudiante4"
        txtPromedioEstudiante4.Size = New Size(125, 27)
        txtPromedioEstudiante4.TabIndex = 4
        ' 
        ' txtPromedioEstudiante5
        ' 
        txtPromedioEstudiante5.Location = New Point(314, 206)
        txtPromedioEstudiante5.Name = "txtPromedioEstudiante5"
        txtPromedioEstudiante5.Size = New Size(125, 27)
        txtPromedioEstudiante5.TabIndex = 5
        ' 
        ' txtPromedioClase
        ' 
        txtPromedioClase.Location = New Point(607, 360)
        txtPromedioClase.Name = "txtPromedioClase"
        txtPromedioClase.Size = New Size(125, 27)
        txtPromedioClase.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtPromedioClase)
        Controls.Add(txtPromedioEstudiante5)
        Controls.Add(txtPromedioEstudiante4)
        Controls.Add(txtPromedioEstudiante3)
        Controls.Add(txtPromedioEstudiante2)
        Controls.Add(txtPromedioEstudiante1)
        Controls.Add(btnCalcularPromedio)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalcularPromedio As Button
    Friend WithEvents txtPromedioEstudiante1 As TextBox
    Friend WithEvents txtPromedioEstudiante2 As TextBox
    Friend WithEvents txtPromedioEstudiante3 As TextBox
    Friend WithEvents txtPromedioEstudiante4 As TextBox
    Friend WithEvents txtPromedioEstudiante5 As TextBox
    Friend WithEvents txtPromedioClase As TextBox
End Class
