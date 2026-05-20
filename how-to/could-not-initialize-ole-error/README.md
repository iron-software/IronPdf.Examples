# Understanding the "Could not initialize OLE (error 80010106)" Notification

***Based on <https://ironpdf.com/how-to/could-not-initialize-ole-error/>***


When using IronPDF within environments other than Windows Forms or WPF applications, developers might encounter this notification in their development consoles.

This notice appears typically within **.NET Core web applications** and **Console Applications**. What exactly does it signify?

## What Does This Error Mean? Is There an Issue with the Software?

This notification originates from the embedded Google Chrome-based web browser component of IronPDF. It serves to inform that there will not be an actual browser window displayed, which aligns with the expected behavior of the software.

The occurrence of this message is a side effect of leveraging a substantial and efficient HTML rendering engine incorporated within IronPDF.

Although the message persists and cannot be removed presently, it's important to clarify that it has no negative impact on the functionality of your application. Your application operates as designed without any actual errors.

For additional details on IronPDF and its capabilities, please visit the [IronPDF Product Page](https://ironpdf.com/).