Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Windows.Forms

Public Class Form1
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        'Criando uma instância do documento
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)
        'Definido Stream
        Dim arquivo As FileStream = New FileStream(txtArquivoPDF.Text, FileMode.Create)
        'definir um objeto pdfwriter
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, arquivo)
        doc.Open()

        'meta informação
        doc.AddAuthor("DRM - Tecnologia")
        doc.AddCreator("Programa de ordem de serviço ou orçamento")
        doc.AddKeywords("Programa para imprimir orçamentos em PDF")
        doc.AddSubject("Cria um orçamento com todas as funcionalidades em um Form")
        doc.AddTitle("Orçamento Martelinho de Ouro.")

        'Definindo imagem
        Dim arquivoImagem As String = "C:\Users\DHIONAS\source\repos\dhionasrm\ORCAMENTO\ORCAMENTO\Imagens\LOGO.png"
        Dim png As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(New Uri(arquivoImagem))
        png.Alignment = Element.ALIGN_CENTER
        doc.Add(png)

        doc.Add(New Paragraph(" "))
        doc.Add(New Paragraph(" "))

        Dim fonte1 As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, Font.Bold, BaseColor.BLACK)
        Dim fonte2 As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 18, Font.Bold, BaseColor.RED)

        'Criando parágrafos
        Dim para1 As New Paragraph(lblNomeEmpresa.Text, fonte1)
        para1.Alignment = Element.ALIGN_LEFT
        doc.Add(para1)

        Dim para2 As New Paragraph(lblCnpjEmpresa.Text, fonte1)
        para2.Alignment = Element.ALIGN_LEFT
        doc.Add(para2)

        Dim para3 As New Paragraph(lblEnderecoEmpresa.Text, fonte1)
        para3.Alignment = Element.ALIGN_LEFT
        doc.Add(para3)

        Dim para4 As New Paragraph(lblFone.Text, fonte1)
        para4.Alignment = Element.ALIGN_LEFT
        doc.Add(para4)

        Dim para5 As New Paragraph(Now.Day.ToString() & " / " & Now.Month.ToString() & " / " & Now.Year.ToString())
        para5.Alignment = Element.ALIGN_LEFT
        doc.Add(para5)

        doc.Add(New Paragraph(" "))

        Dim para6 As New Paragraph(lblOrcamento.Text, fonte1)
        para6.Alignment = Element.ALIGN_CENTER
        doc.Add(para6)

        doc.Add(New Paragraph(" "))

        Dim para7 As New Paragraph(lblCliente.Text & " " & txtCliente.Text, fonte1)
        para7.Alignment = Element.ALIGN_LEFT
        doc.Add(para7)

        Dim para8 As New Paragraph(lblFoneCliente.Text & " " & txtFoneCliente.Text, fonte1)
        para8.Alignment = Element.ALIGN_LEFT
        doc.Add(para8)

        Dim para9 As New Paragraph(lblServicos.Text, fonte1)
        para9.Alignment = Element.ALIGN_LEFT
        doc.Add(para9)

        Dim para10 As New Paragraph(txtServicos.Text, fonte1)
        para10.Alignment = Element.ALIGN_LEFT
        doc.Add(para10)

        Dim para11 As New Paragraph(lblPecas.Text & " " & txtPecas.Text, fonte1)
        para11.Alignment = Element.ALIGN_LEFT
        doc.Add(para11)

        Dim para12 As New Paragraph(lblVlrServicos.Text & " " & txtVlrServicos.Text, fonte1)
        para12.Alignment = Element.ALIGN_LEFT
        doc.Add(para12)

        Dim para13 As New Paragraph(lblDesconto.Text & " " & txtDesconto.Text, fonte1)
        para13.Alignment = Element.ALIGN_LEFT
        doc.Add(para13)

        Dim para14 As New Paragraph(lblTotal.Text & " " & txtTotal.Text, fonte1)
        para14.Alignment = Element.ALIGN_LEFT
        doc.Add(para14)

        doc.Add(New Paragraph(" "))

        Dim para15 As New Paragraph("Parcelamento no cartão de crédito em 3 X sem juros.", fonte2)
        para15.Alignment = Element.ALIGN_CENTER
        doc.Add(para15)

        doc.Close()
        arquivo.Close()

    End Sub

End Class
