<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNomeEmpresa = New System.Windows.Forms.Label()
        Me.lblCnpjEmpresa = New System.Windows.Forms.Label()
        Me.lblEnderecoEmpresa = New System.Windows.Forms.Label()
        Me.lblFone = New System.Windows.Forms.Label()
        Me.lblOrcamento = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFoneCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtFoneCliente = New System.Windows.Forms.TextBox()
        Me.txtServicos = New System.Windows.Forms.TextBox()
        Me.lblServicos = New System.Windows.Forms.Label()
        Me.lblPecas = New System.Windows.Forms.Label()
        Me.lblVlrServicos = New System.Windows.Forms.Label()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtPecas = New System.Windows.Forms.TextBox()
        Me.txtVlrServicos = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtArquivoPDF = New System.Windows.Forms.TextBox()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.txtCor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNomeEmpresa
        '
        Me.lblNomeEmpresa.AutoSize = True
        Me.lblNomeEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeEmpresa.Location = New System.Drawing.Point(18, 19)
        Me.lblNomeEmpresa.Name = "lblNomeEmpresa"
        Me.lblNomeEmpresa.Size = New System.Drawing.Size(144, 20)
        Me.lblNomeEmpresa.TabIndex = 0
        Me.lblNomeEmpresa.Text = "Martelinho de Ouro"
        '
        'lblCnpjEmpresa
        '
        Me.lblCnpjEmpresa.AutoSize = True
        Me.lblCnpjEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnpjEmpresa.Location = New System.Drawing.Point(18, 45)
        Me.lblCnpjEmpresa.Name = "lblCnpjEmpresa"
        Me.lblCnpjEmpresa.Size = New System.Drawing.Size(228, 20)
        Me.lblCnpjEmpresa.TabIndex = 1
        Me.lblCnpjEmpresa.Text = "CNPJ: XX.XXX.XXX/XXXX-XX"
        '
        'lblEnderecoEmpresa
        '
        Me.lblEnderecoEmpresa.AutoSize = True
        Me.lblEnderecoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnderecoEmpresa.Location = New System.Drawing.Point(18, 71)
        Me.lblEnderecoEmpresa.Name = "lblEnderecoEmpresa"
        Me.lblEnderecoEmpresa.Size = New System.Drawing.Size(290, 20)
        Me.lblEnderecoEmpresa.TabIndex = 2
        Me.lblEnderecoEmpresa.Text = "Endereço: Avenida Assis Brasil, Nº XXX"
        '
        'lblFone
        '
        Me.lblFone.AutoSize = True
        Me.lblFone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFone.Location = New System.Drawing.Point(18, 97)
        Me.lblFone.Name = "lblFone"
        Me.lblFone.Size = New System.Drawing.Size(223, 20)
        Me.lblFone.TabIndex = 3
        Me.lblFone.Text = "Telefone: (XX) XXXXX-XXXX "
        '
        'lblOrcamento
        '
        Me.lblOrcamento.AutoSize = True
        Me.lblOrcamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrcamento.Location = New System.Drawing.Point(216, 136)
        Me.lblOrcamento.Name = "lblOrcamento"
        Me.lblOrcamento.Size = New System.Drawing.Size(88, 20)
        Me.lblOrcamento.TabIndex = 4
        Me.lblOrcamento.Text = "Orçamento"
        Me.lblOrcamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(20, 167)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(62, 20)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Cliente:"
        '
        'lblFoneCliente
        '
        Me.lblFoneCliente.AutoSize = True
        Me.lblFoneCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoneCliente.Location = New System.Drawing.Point(20, 192)
        Me.lblFoneCliente.Name = "lblFoneCliente"
        Me.lblFoneCliente.Size = New System.Drawing.Size(75, 20)
        Me.lblFoneCliente.TabIndex = 6
        Me.lblFoneCliente.Text = "Telefone:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(104, 167)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(368, 20)
        Me.txtCliente.TabIndex = 7
        '
        'txtFoneCliente
        '
        Me.txtFoneCliente.Location = New System.Drawing.Point(104, 192)
        Me.txtFoneCliente.Name = "txtFoneCliente"
        Me.txtFoneCliente.Size = New System.Drawing.Size(368, 20)
        Me.txtFoneCliente.TabIndex = 8
        '
        'txtServicos
        '
        Me.txtServicos.Location = New System.Drawing.Point(24, 317)
        Me.txtServicos.Multiline = True
        Me.txtServicos.Name = "txtServicos"
        Me.txtServicos.Size = New System.Drawing.Size(448, 188)
        Me.txtServicos.TabIndex = 9
        '
        'lblServicos
        '
        Me.lblServicos.AutoSize = True
        Me.lblServicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicos.Location = New System.Drawing.Point(20, 294)
        Me.lblServicos.Name = "lblServicos"
        Me.lblServicos.Size = New System.Drawing.Size(73, 20)
        Me.lblServicos.TabIndex = 10
        Me.lblServicos.Text = "Serviços:"
        '
        'lblPecas
        '
        Me.lblPecas.AutoSize = True
        Me.lblPecas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPecas.Location = New System.Drawing.Point(23, 532)
        Me.lblPecas.Name = "lblPecas"
        Me.lblPecas.Size = New System.Drawing.Size(57, 20)
        Me.lblPecas.TabIndex = 11
        Me.lblPecas.Text = "Peças:"
        '
        'lblVlrServicos
        '
        Me.lblVlrServicos.AutoSize = True
        Me.lblVlrServicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVlrServicos.Location = New System.Drawing.Point(23, 561)
        Me.lblVlrServicos.Name = "lblVlrServicos"
        Me.lblVlrServicos.Size = New System.Drawing.Size(73, 20)
        Me.lblVlrServicos.TabIndex = 12
        Me.lblVlrServicos.Text = "Serviços:"
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesconto.Location = New System.Drawing.Point(23, 590)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(82, 20)
        Me.lblDesconto.TabIndex = 13
        Me.lblDesconto.Text = "Desconto:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(23, 619)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 20)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "Total:"
        '
        'txtPecas
        '
        Me.txtPecas.Location = New System.Drawing.Point(125, 532)
        Me.txtPecas.Name = "txtPecas"
        Me.txtPecas.Size = New System.Drawing.Size(100, 20)
        Me.txtPecas.TabIndex = 15
        '
        'txtVlrServicos
        '
        Me.txtVlrServicos.Location = New System.Drawing.Point(125, 561)
        Me.txtVlrServicos.Name = "txtVlrServicos"
        Me.txtVlrServicos.Size = New System.Drawing.Size(100, 20)
        Me.txtVlrServicos.TabIndex = 16
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(125, 590)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(100, 20)
        Me.txtDesconto.TabIndex = 17
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(125, 619)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 18
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.ORCAMENTO.My.Resources.Resources.BotaoImprimir
        Me.btnImprimir.Location = New System.Drawing.Point(311, 511)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(161, 171)
        Me.btnImprimir.TabIndex = 19
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtArquivoPDF
        '
        Me.txtArquivoPDF.Location = New System.Drawing.Point(27, 662)
        Me.txtArquivoPDF.Name = "txtArquivoPDF"
        Me.txtArquivoPDF.Size = New System.Drawing.Size(198, 20)
        Me.txtArquivoPDF.TabIndex = 20
        Me.txtArquivoPDF.Text = "C:\Users\dhionas.magalhaes\Downloads\Arquivo.pdf"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPlaca.Location = New System.Drawing.Point(20, 217)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(52, 20)
        Me.lblPlaca.TabIndex = 21
        Me.lblPlaca.Text = "Placa:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblModelo.Location = New System.Drawing.Point(20, 242)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(65, 20)
        Me.lblModelo.TabIndex = 22
        Me.lblModelo.Text = "Modelo:"
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(104, 219)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(121, 20)
        Me.txtPlaca.TabIndex = 23
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(104, 245)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(368, 20)
        Me.txtModelo.TabIndex = 24
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCor.Location = New System.Drawing.Point(251, 219)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(38, 20)
        Me.lblCor.TabIndex = 25
        Me.lblCor.Text = "Cor:"
        '
        'txtCor
        '
        Me.txtCor.Location = New System.Drawing.Point(295, 219)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Size = New System.Drawing.Size(177, 20)
        Me.txtCor.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(494, 695)
        Me.Controls.Add(Me.txtCor)
        Me.Controls.Add(Me.lblCor)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblPlaca)
        Me.Controls.Add(Me.txtArquivoPDF)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.txtVlrServicos)
        Me.Controls.Add(Me.txtPecas)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDesconto)
        Me.Controls.Add(Me.lblVlrServicos)
        Me.Controls.Add(Me.lblPecas)
        Me.Controls.Add(Me.lblServicos)
        Me.Controls.Add(Me.txtServicos)
        Me.Controls.Add(Me.txtFoneCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblFoneCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblOrcamento)
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
    Friend WithEvents lblOrcamento As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblFoneCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtFoneCliente As TextBox
    Friend WithEvents txtServicos As TextBox
    Friend WithEvents lblServicos As Label
    Friend WithEvents lblPecas As Label
    Friend WithEvents lblVlrServicos As Label
    Friend WithEvents lblDesconto As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtPecas As TextBox
    Friend WithEvents txtVlrServicos As TextBox
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents txtArquivoPDF As TextBox
    Friend WithEvents lblPlaca As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents lblCor As Label
    Friend WithEvents txtCor As TextBox
End Class
