﻿// Decompiled with JetBrains decompiler
// Type: Bujar.Fiscal.My.Resources.Resources
// Assembly: Bujar.Fiscal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F67EA74-8FA1-4626-BF9D-4F6BED24CDA7
// Assembly location: G:\GitHub\IMS_Project\Library\_Fiskalni\Bujar.Fiscal.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Viktor.IMS.Fiscal.My.Resources
{
  [HideModuleName]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [CompilerGenerated]
  [StandardModule]
  [DebuggerNonUserCode]
  internal sealed class Resources2
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
          if (object.ReferenceEquals((object)Resources2.resourceMan, (object)null))
              Resources2.resourceMan = new ResourceManager("Viktor.IMS.Fiscal.Properties.Resources", typeof(Resources2).Assembly);
          return Resources2.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
          return Resources2.resourceCulture;
      }
      set
      {
          Resources2.resourceCulture = value;
      }
    }

    internal static byte[] DAVID32
    {
      get
      {
          return (byte[])RuntimeHelpers.GetObjectValue(Resources2.ResourceManager.GetObject("DAVID32", Resources2.resourceCulture));
      }
    }

    internal static byte[] Fiscal32
    {
      get
      {
          return (byte[])RuntimeHelpers.GetObjectValue(Resources2.ResourceManager.GetObject("Fiscal32", Resources2.resourceCulture));
      }
    }
  }
}
