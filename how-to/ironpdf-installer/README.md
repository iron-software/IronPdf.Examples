# Installing IronPDF via Windows Installer

***Based on <https://ironpdf.com/how-to/ironpdf-installer/>***


## Download and Execute the Installation Package

1. Access and execute the **[IronPDF Installer Package](https://ironpdf.com/packages/IronPdfInstaller.zip)**.
2. Review the license agreement thoroughly:
   ![license-agreement-image](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-agreement.webp)

3. Proceed through the setup steps until you reach the `Install` option:
   ![license-install](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-install.webp)

4. After reading the Information page, advance by clicking `Next`:
   ![license information](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-information.webp)

5. Conclude the installation by clicking `Finish`:
   ![license complete](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/license-complete.webp)

## Update Environment Variables in Windows 11

Adjustments to Environment Variables necessitate a system restart for changes to apply. While the installation should configure these settings by default, manual adjustment may be required on occasion:

1. Activate the "Run" dialog by pressing `Windows+R` and input `sysdm.cpl`:
   ![run program win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/run-program-win11.webp)

2. In the opened `System Properties` window, go to the `Advanced` tab and select `Environment Variables...`:
   ![system properties win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/system-properties-win11.webp)

3. Here, you have the option to create or modify `User Variables` for individual settings, or `System Variables` for global changes.
   ![environment variables window](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/environment-variables-window.webp)

4. Set `Variable Name` as `IRONPDF_INSTALL_DIR` and `Variable Value` as `C:\Program Files (x86)\IronSoftware\IronPdf`:
   ![edit user variable win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/edit-user-variable.webp)

5. Restart your computer to apply the Environment Variable updates.

## Update Environment Variables on Windows 10

To ensure Environment Variable changes take effect, a restart is necessary. Typically, these settings are automatically configured during installation, but manual adjustment might be required:

1. Right-click the Windows icon on the taskbar and select `System`.
2. In the appearing `Settings` window, navigate through `Related Settings` to `Advanced System Settings`.
3. Locate and click the `Environment Variables...` button under the `Advanced` tab:
   ![system properties win10](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/system-properties-win10.webp)

4. This section allows for the addition or modification of either `User Variables` or `System Variables`.
   ![environment variables window](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/environment-variables-window.webp)

5. Establish or edit the IronPDF variable with `Variable Name` as `IRONPDF_INSTALL_DIR` and set the `Variable Value` to `C:\Program Files (x86)\IronSoftware\IronPdf`.
   ![edit user variable win11](https://ironpdf.com/static-assets/pdf/how-to/ironpdf-installer/edit-user-variable.webp)

6. Restart your system to enable the Environment Variable updates.