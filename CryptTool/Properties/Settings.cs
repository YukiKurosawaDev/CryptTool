// Decompiled with JetBrains decompiler
// Type: CryptTool.Properties.Settings
// Assembly: CryptTool, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 89995CE8-0DB1-4222-BA2E-374450C4A3A1
// Assembly location: D:\Repo\NHIS5-Standard\HIS5.0\His.Lib\CryptTool.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace CryptTool.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
