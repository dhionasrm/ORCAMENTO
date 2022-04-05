<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNomeEmpresa = New System.Windows.Forms.Label()
        Me.lblCnpjEmpresa = New System.Windows.Forms.Label()
        Me.lblEnderecoEmpresa = New System.Windows.Forms.Label()
        Me.lblFone = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNomeEmpresa
        '
        Me.lblNomeEmpresa.AutoSize = True
        Me.lblNomeEmpresa.Location = New System.Drawing.Point(18, 19)
        Me.lblNomeEmpresa.Name = "lblNomeEmpresa"
        Me.lblNomeEmpresa.Size = New System.Drawing.Size(97, 13)
        Me.lblNomeEmpresa.TabIndex = 0
        Me.lblNomeEmpresa.Text = "Martelinho de Ouro"
        '
        'lblCnpjEmpresa
        '
        Me.lblCnpjEmpresa.AutoSize = True
        Me.lblCnpjEmpresa.Location = New System.Drawing.Point(18, 45)
        Me.lblCnpjEmpresa.Name = "lblCnpjEmpresa"
        Me.lblCnpjEmpresa.Size = New System.Drawing.Size(152, 13)
        Me.lblCnpjEmpresa.TabIndex = 1
        Me.lblCnpjEmpresa.Text = "CNPJ: XX.XXX.XXX/XXXX-XX"
        '
        'lblEnderecoEmpresa
        '
        Me.lblEnderecoEmpresa.AutoSize = True
        Me.lblEnderecoEmpresa.Location = New System.Drawing.Point(18, 71)
        Me.lblEnderecoEmpresa.Name = "lblEnderecoEmpresa"
        Me.lblEnderecoEmpresa.Size = New System.Drawing.Size(195, 13)
        Me.lblEnderecoEmpresa.TabIndex = 2
        Me.lblEnderecoEmpresa.Text = "Endereço: Avenida Assis Brasil, Nº XXX"
        '
        'lblFone
        '
        Me.lblFone.AutoSize = True
        Me.lblFone.Location = New System.Drawing.Point(18, 97)
        Me.lblFone.Name = "lblFone"
        Me.lblFone.Size = New System.Drawing.Size(147, 13)
        Me.lblFone.TabIndex = 3
        Me.lblFone.Text = "Telefone: (XX) XXXXX-XXXX "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(607, 682)
        Me.Controls.Add(Me.lblFone)
        Me.Controls.Add(Me.lblEnderecoEmpresa)
        Me.Controls.Add(Me.lblCnpjEmpresa)
        Me.Controls.Add(Me.lblNomeEmpresa)
        Me.Name = "Form1"
        Me.Text = "Orçamento Martelinho de Ouro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNomeEmpresa As Label
    Friend WithEvents lblCnpjEmpresa As Label
    Friend WithEvents lblEnderecoEmpresa As Label
    Friend WithEvents lblFone As Label
End Class
