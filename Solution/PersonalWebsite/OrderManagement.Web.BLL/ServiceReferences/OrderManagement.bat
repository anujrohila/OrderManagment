@ECHO OFF

set UIProjectServiceRefPath =F:\Anuj\Extra\Project\My Website\My Website\Project\New\PersonalWebsite
set SVCUTILPATHValue =C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\bin\NETFX 4.0 Tools

ECHO Generating AdminService.CS
"%SVCUTILPATHValue %\svcutil.exe" /o:"%UIProjectServiceRefPath %\OrderManagement.Web.BLL\ServiceReferences\AdminService.cs" /reference:"%UIProjectServiceRefPath %\OrderManagement.Web.Domain\bin\Debug\OrderManagement.Web.Domain.dll" /serializer:Auto /edb /ct:System.Collections.Generic.List`1 /ixt  /namespace:*,OrderManagement.Web.BLL.AdminService http://localhost/OrderManagement.Web.Services/Services/Admin/AdminService.svc?wsdl

set /p delBuild=press any key to exit:
