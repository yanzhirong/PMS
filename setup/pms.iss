; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
AppId={{09FB473C-16D2-48F6-8759-3DBE5BC942A0}
AppName=PMS
AppVersion=1.0
;AppVerName=PMS 1.0
AppPublisher=beggar king
DefaultDirName={pf}\PMS
DisableProgramGroupPage=yes
OutputDir=D:\p\project\pms\setup
OutputBaseFilename=PMS_setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checkablealone; OnlyBelowVersion: 0,8.1

[Files]
Source: "D:\p\project\pms\setup\install file\PMS.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\p\project\pms\setup\install file\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{commonprograms}\PMS"; Filename: "{app}\PMS.exe"
Name: "{commondesktop}\PMS"; Filename: "{app}\PMS.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\PMS.exe"; Description: "{cm:LaunchProgram,PMS}"; Flags: nowait postinstall skipifsilent

[code] 
  function initializesetup: boolean; 
  var path:string ; 
         resultcode: integer; 
  begin 
     if regkeyexists(hklm, 'SOFTWARE\Microsoft\.NETFramework\policy\v4.0') then 
     begin 
         result := true; 
     end 
     else 
     begin 
         if msgbox('系统检测到您没有安装.net framework4.5，是否立刻下载并安装？', mbconfirmation, mb_yesno) = idyes then 
         begin 
             path := expandconstant('{pf}\internet explorer\iexplore.exe'); 
             exec(path, 'https://download.microsoft.com/download/B/A/4/BA4A7E71-2906-4B2D-A0E1-80CF16844F5F/dotNetFx45_Full_setup.exe', '', sw_shownormal, ewwaituntilterminated, resultcode); 
             msgbox('请安装好.net framework4.5环境后，再运行本安装包程序！',mbinformation,mb_ok); 
             result := false; 
         end 
         else 
         begin 
             msgbox('没有安装.net framework4.5环境，无法运行安装程序，本安装程序即将退出！',mbinformation,mb_ok); 
             result := false; 
         end; 
     end; 
  end;

