// Decompiled with JetBrains decompiler
// Type: CryptTool.Properties.Resources
// Assembly: CryptTool, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 89995CE8-0DB1-4222-BA2E-374450C4A3A1
// Assembly location: D:\Repo\NHIS5-Standard\HIS5.0\His.Lib\CryptTool.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CryptTool.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (CryptTool.Properties.Resources.resourceMan == null)
          CryptTool.Properties.Resources.resourceMan = new ResourceManager("CryptTool.Properties.Resources", typeof (CryptTool.Properties.Resources).Assembly);
        return CryptTool.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => CryptTool.Properties.Resources.resourceCulture;
      set => CryptTool.Properties.Resources.resourceCulture = value;
    }
  }
}
