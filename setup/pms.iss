; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (�����µ�GUID����� ����|��IDE������GUID��)
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
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

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
         if msgbox('ϵͳ��⵽��û�а�װ.net framework4.5���Ƿ��������ز���װ��', mbconfirmation, mb_yesno) = idyes then 
         begin 
             path := expandconstant('{pf}\internet explorer\iexplore.exe'); 
             exec(path, 'https://download.microsoft.com/download/B/A/4/BA4A7E71-2906-4B2D-A0E1-80CF16844F5F/dotNetFx45_Full_setup.exe', '', sw_shownormal, ewwaituntilterminated, resultcode); 
             msgbox('�밲װ��.net framework4.5�����������б���װ������',mbinformation,mb_ok); 
             result := false; 
         end 
         else 
         begin 
             msgbox('û�а�װ.net framework4.5�������޷����а�װ���򣬱���װ���򼴽��˳���',mbinformation,mb_ok); 
             result := false; 
         end; 
     end; 
  end;

