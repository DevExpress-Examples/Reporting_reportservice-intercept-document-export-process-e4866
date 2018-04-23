# ReportService - Intercept document export process


<p>Document export process can be intercepted by IDocumentExportInterceptor extension. Process can be intercepted before and after invocation.</p><p>Create class that implements IDocumentExportInterceptor interface and register it to service container; by default, add attribute [Export(typeof(IDocumentExportInterceptor))] on your class.</p>

<br/>


