using IronPdf.Editing;
using System;

// Create text stamper
ImageStamper imageStamper = new ImageStamper(new Uri("https://ironpdf.com/img/svgs/iron-pdf-logo.svg"))
{
    HorizontalAlignment = HorizontalAlignment.Center,
    VerticalAlignment = VerticalAlignment.Top,

    // Specify offsets
    HorizontalOffset = new Length(10),
    VerticalOffset = new Length(10),
};