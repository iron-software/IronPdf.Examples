var pdf = new PdfDocument("/attachments/2022_Q1_sales.pdf");

ImageStamper logoImageStamper = new ImageStamper("/assets/logo.png");

// Apply to every page, one page, or some pages
pdf.ApplyStamp(logoImageStamper);
pdf.ApplyStamp(logoImageStamper, 0);
pdf.ApplyStamp(logoImageStamper, new[] { 0, 3, 11 });