# Secure Digital Signature Implementation in C# with HSM

***Based on <https://ironpdf.com/how-to/signing-pdf-with-hsm/>***


Implementing digital signatures in PDFs is an essential feature for many software applications, especially when the security of the signing keys is paramount. Traditional methods that utilize `.pfx` files can be likened to keeping a master key at home—whereas using a `Hardware Security Module (HSM)` is similar to locking that key in a bank vault. In an HSM environment, the private key is generated internally and never leaves the device, ensuring it cannot be duplicated or compromised.

## Enhanced Security with HSM

Using an HSM for digital signatures typically involves a physical device, like a USB token, which securely manages key operations. IronPDF supports these secure operations seamlessly as it is compatible with the `PKCS#11` standards used by many HSM devices. For the purposes of this guide, we will simulate an HSM environment for demonstration, but remember, for actual deployments, real HSM hardware should be used.

Before you begin, ensure you have installed necessary tools such as [SoftHSM](https://www.opendnssec.org/en/latest/softhsm), [OpenSSL](https://openssl-library.org), and [OpenSC](https://github.com/OpenSC/OpenSC/wiki) for key and token management. Check SoftHSM's GitHub for more details.

We will start by generating a PDF from an HTML string. We'll configure the paths and credentials for the simulated HSM environment, which includes specifying the library path to the SoftHSM’s `.dll` file and your certificate’s `.crt` file.

Next, we define the destination for our output as `output.pdf`.

We continue by setting up three important strings: `hsmTokenLabel`, `hsmPin`, and `hsmKeyLabel`. It is crucial that these match the credentials you have set up in SoftHSM. Next, we instantiate the `UsbPkcs11HsmSigner` using these parameters.

A `PdfSignatureImage` is also created to visually display the signature on the document. Finally, the document is digitally signed using the `SignAndSave` method.

### Example Code

```csharp
using IronPdf;
using IronPdf.Signing;
using IronSoftware.Pdfium.Signing;
using System.Drawing;

// Initialize PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Sample Signature</h1>");

// Define Paths and Credentials for the HSM
string softhsmLibraryPath = @"D:\SoftHSM2\lib\softhsm2-x64.dll";
// Ensure these match your configuration
string hsmTokenLabel = "MyTestToken";
string hsmPin = "123456";
string hsmKeyLabel = "my-key";

// Setup the HsmSigner
UsbPkcs11HsmSigner hsmSigner = new UsbPkcs11HsmSigner(
    softhsmLibraryPath,
    hsmPin,
    hsmTokenLabel,
    hsmKeyLabel
);

// Setup the Signature Image
string signatureImagePath = "IronSoftware.png";
PdfSignatureImage sigImage = new PdfSignatureImage(signatureImagePath, 0, new Rectangle(50, 50, 150, 150));

// Execute HSM based PDF signing
pdf.SignAndSave("signedWithHSM.pdf", hsmSigner);
```

### Output

Below is how the resultant signed PDF appears. You can see the signature field clearly displaying the use of a certified signing process.

![Output with Signature](https://ironpdf.com/static-assets/pdf/how-to/signing-pdf-with-hsm/output.webp)
![Output Demonstrating the Certificate](https://ironpdf.com/static-assets/pdf/how-to/signing-pdf-with-hsm/output-certificate.webp)

### Troubleshooting

If you encounter a `CKR_GENERAL_ERROR`, this often is due to missing configuration files or architecture mismatches. Below are some control steps:

1. **Architecture compatibility**: Ensure that your .NET application runs in a 64-bit environment to match the 64-bit SoftHSM library.
   ![Ensure 64-bit Compatibility](https://ironpdf.com/static-assets/pdf/how-to/signing-pdf-with-hsm/troubleshoot-platform.webp)

2. **Configuration visibility**: Set the `SOFTHSM2_CONF` environment variable to point to your SoftHSM configuration file. Restart your development environment after setting this.
   ![Set Environment Variable](https://ironpdf.com/static-assets/pdf/how-to/signing-pdf-with-hsm/troubleshoot-env.webp)

```csharp
// Check environment variable visibility
Console.WriteLine($"Environment variable check: {Environment.GetEnvironmentVariable("SOFTHSM2_CONF")}");
```

If output is blank, ensure to correctly set the environment variable, restart your IDE or computer, and then recheck.