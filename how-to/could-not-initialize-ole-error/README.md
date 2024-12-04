# Unable to Initialize OLE (Error Code: 80010106)

***Based on <https://ironpdf.com/how-to/could-not-initialize-ole-error/>***


This alert commonly appears in the development consoles when employing IronPDF outside the context of Windows Forms or WPF applications.

You'll often see this notification within the consoles of **.NET Core web applications** or any **Console Application**. What exactly does this mean?

## Understanding the Error: Is There an Issue with the Software?

The message originates from the embedded Google Chrome-based browser that IronPDF utilizes. It indicates that the application is running without displaying a visible browser window, which is exactly how it's designed to function.

Integrating such a sophisticated HTML rendering engine does come with minor inconveniences such as this message. Unfortunately, at this moment, we cannot eliminate this message, but it’s important to note that it is completely benign. Rest assured, your application is operating correctly and as expected.

For additional details about IronPDF and its capabilities, please visit the [IronPDF Product Page](https://ironpdf.com).