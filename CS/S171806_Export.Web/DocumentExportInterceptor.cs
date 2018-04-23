using System;
using System.ComponentModel.Composition;
using System.IO;
using DevExpress.Xpf.Printing.Service.Extensions;
using DevExpress.XtraPrinting;

namespace S171806_Export.Web {
    [Export(typeof(IDocumentExportInterceptor))]
    public class DocumentExportInterceptor : IDocumentExportInterceptor {
        #region IDocumentExportInterceptor Members
        void IDocumentExportInterceptor.InvokeBefore(Document document, ExportOptionsBase exportoptions, object customArgs) {
            if(exportoptions is ImageExportOptions || exportoptions is PdfExportOptions) {
                var text = string.Format("Created by {0}{2}{1:MM/dd/yy}{2}{1:H:mm:ss}", Environment.UserName, DateTime.Now, Environment.NewLine);
                document.PrintingSystem.Watermark.Text = text;
            }
        }

        void IDocumentExportInterceptor.InvokeAfter(Stream documentContent, ExportOptionsBase exportoptions, object customArgs) {
        }
        #endregion
    }
}