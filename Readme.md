# How to locate detail view tabs in several lines


<p>This example demonstrates how to create a custom GridControl by locating tabs in multiple lines.<br />First, we create a custom BaseTabControlViewInfo and override the IsMultiLine property to always return true.<br />Then, we create a custom GridView. Look at the <a href="http://isc.devexpress.com/Thread/E900">How to create a GridView descendant class and register it for design-time use</a>  example, which shows how to create custom GridView.<br />Also, we create a custom GridViewInfo and override the CalcScrollRect method to calculate new bounds for detail view.</p>

<br/>


