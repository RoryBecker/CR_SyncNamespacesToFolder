using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_SyncNamespacesToFolder
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_SyncNamespacesToFolderExtension : IVsixPluginExtension { }
}