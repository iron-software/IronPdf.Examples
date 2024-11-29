# Installing IronPDF via Windows Installer

***Based on <https://ironpdf.com/how-to/ironpdf-installer/>***


## Initiate Installation Process

1. Obtain the installation package from **[IronPDF Installer Package](https://ironpdf.com/packages/IronPdfInstaller.zip)** and execute it.
2. Review and agree to the terms of the license agreement carefully:
   ![license-agreement-image](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-agreement.webp)

3. Proceed through the prompted steps until you reach the `Install` button:
   ![license-install](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-install.webp)

4. After reviewing the details on the Information screen, select `Next` to proceed:
   ![license information](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-information.webp)

5. Conclude the installation by clicking the `Finish` button:
   ![license complete](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-complete.webp)

## Configure Environment Variables on Windows 11

It’s essential to reboot your computer to activate any modifications to Environment Variables. Here are the steps, which are generally automated during installation but might require manual intervention if not applied:

1. Utilize `Windows+R` keyboard shortcut to access the "Run" dialog, and type `sysdm.cpl`:
   ![run program win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/run-program-win11.webp)

2. Access the `System Properties` dialog, go to the `Advanced` tab, and click `Environment Variables...`:
   ![system properties win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/system-properties-win11.webp)

3. Use this window to either add or modify ‘User Variables’ for personal changes or ‘System Variables’ for changes affecting all users.
   ![environment variables window](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/environment-variables-window.webp)

4. Specify or modify the IronPDF variable:
5. Set the `Variable Name` to `IRONPDF_INSTALL_DIR` and the `Variable Value` to `C:\Program Files (x86)\IronSoftware\IronPdf`.
   ![edit user variable win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/edit-user-variable.webp)

6. Reboot your system to implement the Environment Variable updates.

## Adjust Environment Variables on Windows 10

Ensure to restart your system after making any modifications to Environment Variables. If not automatically applied, you might need to perform these steps manually:

1. Right-click the Windows icon on your taskbar and select `System`.
2. In the `Settings` interface that appears, navigate to `Related Settings` -> `Advanced System Settings`.
3. Under the `Advanced` tab, locate and click on the `Environment Variables...` button:
   ![system properties win10](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/system-properties-win10.webp)

4. Here, you have the option to create or modify both `User Variables` and `System Variables`.
   ![environment variables window](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/environment-variables-window.webp)

5. Proceed to set `Variable Name` as `IRONPDF_INSTALL_DIR` with `Variable Value` as `C:\Program Files (x86)\IronSoftware\IronPdf`. ![edit user variable win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/edit-user-variable.webp)

6. Restart your computer to apply the Environment Variable changes effectively.