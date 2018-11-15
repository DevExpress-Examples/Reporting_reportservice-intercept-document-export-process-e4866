<!-- default file list -->
*Files to look at*:

* **[DocumentExportInterceptor.cs](./CS/S171806_Export.Web/DocumentExportInterceptor.cs) (VB: [DocumentExportInterceptor.vb](./VB/S171806_Export.Web/DocumentExportInterceptor.vb))**
<!-- default file list end -->
# ReportService - Intercept document export process


<p>Document export process can be intercepted by IDocumentExportInterceptor extension. Process can be intercepted before and after invocation.</p><p>Create class that implements IDocumentExportInterceptor interface and register it to service container; by default, add attribute [Export(typeof(IDocumentExportInterceptor))] on your class.</p>

<br/>


