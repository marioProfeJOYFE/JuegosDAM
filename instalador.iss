[Setup]
; Información básica de la aplicación
AppName=JuegosDAM
AppVersion=1.0.0
AppPublisher=Mario Ríos
AppPublisherURL=https://github.com/
AppSupportURL=https://github.com/
AppUpdatesURL=https://github.com/

; Ruta de instalación por defecto (Archivos de programa \ JuegosDAM)
DefaultDirName={autopf}\JuegosDAM
DefaultGroupName=JuegosDAM

; Configuración del instalador generado
OutputDir=Output
OutputBaseFilename=JuegosDAM_Setup
Compression=lzma2
SolidCompression=yes
ArchitecturesInstallIn64BitMode=x64

; Privilegios para instalar (requiere permisos de administrador)
PrivilegesRequired=admin

[Tasks]
Name: "desktopicon"; Description: "Crear un acceso directo en el escritorio"; GroupDescription: "Iconos adicionales:"

[Files]
; Toma TODOS los archivos generados en la carpeta "publish" y los incluye en el instalador
Source: "publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
; Crea los accesos directos en el menú inicio y el escritorio apuntando al .exe
Name: "{group}\JuegosDAM"; Filename: "{app}\JuegosDAM.exe"
Name: "{autodesktop}\JuegosDAM"; Filename: "{app}\JuegosDAM.exe"; Tasks: desktopicon

[Run]
; Ofrece ejecutar la app inmediatamente después de instalarla
Filename: "{app}\JuegosDAM.exe"; Description: "Ejecutar JuegosDAM"; Flags: nowait postinstall skipifsilent
