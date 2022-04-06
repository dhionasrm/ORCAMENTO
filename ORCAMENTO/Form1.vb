Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Form1
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'Criando uma instância do documento
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)
        'Definido Stream
        Dim arquivo As FileStream = New FileStream(txtArquivoPDF.Text, FileMode.Create)
        'Definindo um objeto pdfwriter
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, arquivo)
        doc.Open()

        'meta informação
        doc.AddAuthor("DRM - Tecnologia")
        doc.AddCreator("Programa de ordem de serviço ou orçamento")
        doc.AddKeywords("Programa para imprimir orçamentos em PDF")
        doc.AddSubject("Cria um orçamento com todas as funcionalidades em um Form")
        doc.AddTitle("Orçamento Martelinho de Ouro.")

        'Definindo imagem
        Dim arquivoImagem As String = "C:\Users\dhionas.magalhaes\source\Workspaces\ORCAMENTO\ORCAMENTO\Imagens\LOGO.png"
        Dim png As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(New Uri(arquivoImagem))
        png.Alignment = Element.ALIGN_CENTER
        doc.Add(png)

        Dim fonte1 As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, Font.Bold, BaseColor.BLACK)

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

        doc.Add(New Paragraph(" "))

        Dim para5 As New Paragraph(lblOrcamento.Text, fonte1)
        para5.Alignment = Element.ALIGN_CENTER
        doc.Add(para5)


    End Sub
End Class
