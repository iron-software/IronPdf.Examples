# Handling the OLE Initialization Error (error 80010106)

***Based on <https://ironpdf.com/how-to/could-not-initialize-ole-error/>***


This error message often appears in the developer console when IronPDF is used outside the context of a Windows Forms or WPF application.

You may encounter this notification in **.NET Core web applications** as well as any **Console Application**. Let's explore what this means.

## Understanding the Error: Is There an Issue with the Software?

The error originates from the embedded Google Chrome-based web browser that IronPDF utilizes. It indicates that no visible browser window will be presented, which aligns with the designed behavior of the software.

The appearance of this message is a small trade-off for leveraging a robust and sophisticated HTML rendering engine like the one embedded within IronPDF.

Although it would be preferable to eliminate this notice, currently, it must be accepted as part of the operation. Importantly, this message does not signify any malfunction – your application is functioning correctly despite its presence.

For further details on IronPDF and its capabilities, consider visiting the [IronPDF Product Page](https://ironpdf.com).