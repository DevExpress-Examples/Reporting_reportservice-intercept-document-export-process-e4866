Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.Composition
Imports System.IO
Imports DevExpress.Xpf.Printing.Service.Extensions
Imports DevExpress.XtraPrinting

Namespace S171806_Export.Web
	<Export(GetType(IDocumentExportInterceptor))> _
	Public Class DocumentExportInterceptor
		Implements IDocumentExportInterceptor
		#Region "IDocumentExportInterceptor Members"
		Private Sub InvokeBefore(ByVal document As Document, ByVal exportoptions As ExportOptionsBase, ByVal customArgs As Object) Implements IDocumentExportInterceptor.InvokeBefore
			If TypeOf exportoptions Is ImageExportOptions OrElse TypeOf exportoptions Is PdfExportOptions Then
				Dim text = String.Format("Created by {0}{2}{1:MM/dd/yy}{2}{1:H:mm:ss}", Environment.UserName, DateTime.Now, Environment.NewLine)
				document.PrintingSystem.Watermark.Text = text
			End If
		End Sub

		Private Sub InvokeAfter(ByVal documentContent As Stream, ByVal exportoptions As ExportOptionsBase, ByVal customArgs As Object) Implements IDocumentExportInterceptor.InvokeAfter
		End Sub
		#End Region
	End Class
End Namespace