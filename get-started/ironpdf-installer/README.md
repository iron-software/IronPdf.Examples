# Install IronPDF with the Windows Installer

***Based on <https://ironpdf.com/get-started/ironpdf-installer/>***


## Download and Execute the Installer

1. Initiate the installation by downloading the **[IronPDF Installer Package](https://ironpdf.com/packages/IronPdfInstaller.zip)** and executing the file.
2. Review and agree to the licensing terms displayed:
   ![license-agreement-image](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-agreement.webp)

3. Proceed through the installation steps and select the `Install` button:
   ![license-install](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-install.webp)

4. After reviewing the Information page, select `Next` to progress:
   ![license information](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-information.webp)

5. Conclude the setup by clicking the `Finish` button:
   ![license complete](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-complete.webp)

## Adjusting Environment Variables on Windows 11

Note that changes to Environment Variables won't apply until the computer is restarted. While these adjustments are typically handled by the installer, manual intervention might be necessary on occasion:

1. Open the "Run" dialog by pressing `Windows+R` and entering `sysdm.cpl`:
   ![run program win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/run-program-win11.webp)

2. Access the `Advanced` tab in the `System Properties` dialog that appears, and click on the `Environment Variables...`:
   ![system properties win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/system-properties-win11.webp)

3. Here you may add or modify `User Variables` and `System Variables`:
   ![environment variables window](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/environment-variables-window.webp)

4. Create or update the variable for IronPDF.
5. Set `IRONPDF_INSTALL_DIR` as the `Variable Name` and `C:\Program Files (x86)\IronSoftware\IronPdf` as the `Variable Value`:
   ![edit user variable win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/edit-user-variable.webp)

6. Restart your computer to apply these Environment Variable changes.

## Adjusting Environment Variables on Windows 10

Ensure that your machine is restarted for the Environment Variable changes to take effect. These modifications should generally be made automatically by the installer, but if not, they will need to be done manually:

1. Right-click the Windows icon on the taskbar and select `System`.
2. In the subsequent `Settings` window, go to `Related Settings` and then `Advanced System Settings`.
3. In the `Advanced` tab, locate and click the `Environment Variables...` button:
   ![system properties win10](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/system-properties-win10.webp)

4. This area allows you to add and edit `User Variables` and `System Variables`:
   ![environment variables window](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/environment-variables-window.webp)

5. Now let's set or modify the IronPDF variable. Define `IRONPDF_INSTALL_DIR` as the `Variable Name` and assign `C:\Program Files (x86)\IronSoftware\IronPdf` as the `Variable Value`:
   ![edit user variable win10](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/edit-user-variable.webp)

6. Remember to restart your PC to ensure the adjustments to Environment Variables are implemented.