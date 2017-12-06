rem @echo off

cls

echo Busy drawing Ford data from PANDA ............


set HTTP_USER=PRXP0055
set HTTP_PASSWORD=crD055


c:\Logidata\http_get.exe https://www.datex-za.dealerconnection.com/PRXP0055/PANDA_COURIER.TXT c:\logidata\PANDA_COURIER.txt

@set HTTPS_ERRLEV=%ERRORLEVEL%
pause

