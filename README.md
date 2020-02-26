# DNNDataTablesModule
DNN Summit 2020 Angular 8 presentation module

# Getting Started
The following steps will help you get started with the DNN module
1) Clone repository into your DNN 9.5.0 DesktopModules folder
2) Open solution file in Visual Studio 2019 (Administrator mode)
3) After you've downloaded and compiled the front end, compile in Release mode
4) Install into your DNN website, via Extensions

# Troubleshooting
If you are not seeing data and are receiving 500 errors in Chrome Dev Tool, make sure
1) In IIS, the DesktopModules is not shown as a Virutal Directory. If it is, delete the Virtual Directory
2) Also, in IIS verity the DNNDataTables folder is not configured as an IIS Application. If so, delete the application
