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
    End Sub
End Class
