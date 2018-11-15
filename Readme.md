<!-- default file list -->
*Files to look at*:

* [CustomBaseTabControlViewInfo.cs](./CS/MasterDetailProject/CustomGridControl/CustomBaseTabControlViewInfo.cs) (VB: [CustomBaseTabControlViewInfo.vb](./VB/MasterDetailProject/CustomGridControl/CustomBaseTabControlViewInfo.vb))
* [CustomGridControlClass.cs](./CS/MasterDetailProject/CustomGridControl/CustomGridControlClass.cs) (VB: [CustomGridControlClass.vb](./VB/MasterDetailProject/CustomGridControl/CustomGridControlClass.vb))
* [CustomGridView.cs](./CS/MasterDetailProject/CustomGridControl/CustomGridView.cs) (VB: [CustomGridViewInfo.vb](./VB/MasterDetailProject/CustomGridControl/CustomGridViewInfo.vb))
* [CustomGridViewInfo.cs](./CS/MasterDetailProject/CustomGridControl/CustomGridViewInfo.cs) (VB: [CustomGridViewInfo.vb](./VB/MasterDetailProject/CustomGridControl/CustomGridViewInfo.vb))
* [CustomGridViewRegistrator.cs](./CS/MasterDetailProject/CustomGridControl/CustomGridViewRegistrator.cs) (VB: [CustomGridViewRegistrator.vb](./VB/MasterDetailProject/CustomGridControl/CustomGridViewRegistrator.vb))
* [Form1.cs](./CS/MasterDetailProject/Form1.cs) (VB: [Form1.vb](./VB/MasterDetailProject/Form1.vb))
<!-- default file list end -->
# How to locate detail view tabs in several lines


<p>This example demonstrates how to create a custom GridControl by locating tabs in multiple lines.<br />First, we create a custom BaseTabControlViewInfo and override the IsMultiLine property to always return true.<br />Then, we create a custom GridView. Look at the <a href="http://isc.devexpress.com/Thread/E900">How to create a GridView descendant class and register it for design-time use</a>  example, which shows how to create custom GridView.<br />Also, we create a custom GridViewInfo and override the CalcScrollRect method to calculate new bounds for detail view.</p>

<br/>


