<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604651/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4866)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[DocumentExportInterceptor.cs](./CS/S171806_Export.Web/DocumentExportInterceptor.cs) (VB: [DocumentExportInterceptor.vb](./VB/S171806_Export.Web/DocumentExportInterceptor.vb))**
<!-- default file list end -->
# ReportService - Intercept document export process
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4866)**
<!-- run online end -->


<p>Document export process can be intercepted by IDocumentExportInterceptor extension. Process can be intercepted before and after invocation.</p><p>Create class that implements IDocumentExportInterceptor interface and register it to service container; by default, add attribute [Export(typeof(IDocumentExportInterceptor))] on your class.</p>

<br/>


