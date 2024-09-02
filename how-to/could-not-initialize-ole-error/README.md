# Could not initialize OLE (error 80010106)

IronPDF may display this message during initialization if it is not executed within a Windows Forms or WPF application environment.

This particular message appears in the console of **.NET Core web applications** and **Console Applications**. What does this mean?

## Understanding the Error: Is There an Issue with the Software?

This notification originates from IronPDF’s integrated Google Chrome-based web browser. It indicates that there will be no visible browser window, which aligns with the design and functionality of IronPDF.

The appearance of this message is a minor side effect of integrating a robust HTML rendering engine of this size.

Although currently, this message cannot be eliminated, it is important to understand that it does not signify any malfunction; your application continues to operate correctly.