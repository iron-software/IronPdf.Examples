<ipv:IronPdfView Source="C:/path/to/my/example.pdf" />
</ContentPage>
```

In C#:

```cs
// Assuming an IronPdfView instance named pdfView is already created
pdfView.Source = IronPdfViewSource.FromFile("C:/path/to/my/example.pdf");
```

#### Load Through Byte Array

For scenarios requiring a byte array load, this is achievable only in C#. Here’s how you can do it:

```cs
pdfView.Source = IronPdfViewSource.FromBytes(File.ReadAllBytes("~/Downloads/example.pdf"));
```

#### Load Through Stream

If you wish to load a PDF through a stream, utilize this method in C#:

```cs
pdfView.Source = IronPdfViewSource.FromStream(File.OpenRead("~/Downloads/example.pdf"));
```

## Configure the Toolbar

IronPDF Viewer allows you to customize the toolbar to fit your needs. Options you can include are:

- Thumbnail view
- Filename display
- Text search
- Page number navigation
- Zoom
- Fit to width
- Fit to height
- Rotate clockwise
- Rotate counterclockwise
- Open file
- Download file
- Print file
- Display annotations
- Two-page view

The default setup of IronPDF Viewer displays the following toolbar:

![Default Toolbar](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_all.png)

In this configuration, the filename display, text search, and rotate counterclockwise are not enabled. To enable all options, adjust the `Option` parameter in the `IronPdfView` tag in your XAML to `All`:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage ...
    xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui"
    ...>
    <ipv:IronPdfView x:Name="pdfView" Options="All"/>
</ContentPage>
```

Or similarly in C#:

```cs
pdfView.Options = IronPdfViewOptions.All;
```

This configuration displays:

![All Toolbar](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_all.png)

To hide all toolbar options, set `Options` to `None`, eliminating the toolbar:

![No Toolbar](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_none.png)

If you prefer specific options, like thumbnail and open file, adjust accordingly in XAML:

```xml
<ipv:IronPdfView x:Name="pdfView" Options="Thumbs, Open"/>
```

Or in C#:

```cs
pdfView.Options = IronPdfViewOptions.Thumbs | IronPdfViewOptions.Open;
```

This configuration will show:

![Toolbar with thumbnail and open file options](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_thumbsopen.png)

## Conclusion

This tutorial covered integrating IronPDF Viewer into a MAUI application and customizing its toolbar to suit various requirements.

This viewer is part of the IronPDF product suite. For feature requests or inquiries about IronPDF Viewer (or IronPDF), please [contact our support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are eager to assist you.