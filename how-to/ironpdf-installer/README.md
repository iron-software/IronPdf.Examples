# Install IronPDF Using the Windows Installer

## Download and Execute the Installer

1. To begin, download the installer from **[this location](https://ironpdf.com/packages/IronPdfInstaller.zip)**, and subsequently execute it.
2. Before proceeding, carefully review and agree to the terms of the license. You can view the license agreement as shown here:
![license-agreement-image](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-agreement.webp)

3. Proceed through the installer steps until you reach the `Install` option:
![license-install](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-install.webp)

4. After reviewing the Information page, click `Next` to proceed:
![license information](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-information.webp)

5. Finally, click `Finish` to complete the installation process:
![license complete](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-complete.webp)

## Adjusting Environment Variables in Windows 11

It's necessary to restart your computer for changes to environment variables to take effect. Normally, the installer should handle this, but manual adjustments might be needed:

1. Press `Windows+R` keys to initiate the "Run" dialog and enter `sysdm.cpl` in the "Open" field:
![run program win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/run-program-win11.webp)

2. In the `System Properties` dialog, go to the `Advanced` tab, and then click the `Environment Variables...` button:
![system properties win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/system-properties-win11.webp)

3. You'll find options here to either add new or modify existing `User Variables` and `System Variables`.
![environment variables window](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/environment-variables-window.webp)

4. Proceed to create or edit the variable for IronPDF.
5. Set the `Variable Name` as `IRONPDF_INSTALL_DIR` and the `Variable Value` as `C:\Program Files (x86)\IronSoftware\IronPdf`.
![edit user variable win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/edit-user-variable.webp)

6. Ensure to restart the system to apply the environment variable settings.

## Adjusting Environment Variables in Windows 10

A system restart is essential following any adjustments to environment variables. These modifications are typically automated by the installer, but manual configuration is available if necessary:

1. Right-click on the Windows icon in the taskbar and choose `System` from the menu.
2. In the subsequent `Settings` dialog, navigate to `Related Settings`->`Advanced System Settings`.
3. Within the `Advanced` tab, click on the `Environment Variables...` button.
![system properties win10](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/system-properties-win10.webp)

4. This section allows the addition or modification of both `User Variables` and `System Variables`.
![environment variables window](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/environment-variables-window.webp)

5. Create or revise the IronPDF variable. Name it `IRONPDF_INSTALL_DIR` and assign the value `C:\Program Files (x86)\IronSoftware\IronPdf`.
![edit user variable win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/edit-user-variable.webp)
  
6. Don't forget to reboot your machine to make the changes effective.