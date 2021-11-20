switch dockeer container from linux to windows.

1) execute this command from powershell :
	Enable-WindowsOptionalFeature -Online -FeatureName $("Microsoft-Hyper-V", "Containers") -All

2) right-click on docker tray icon and select "Switch to windows containers"