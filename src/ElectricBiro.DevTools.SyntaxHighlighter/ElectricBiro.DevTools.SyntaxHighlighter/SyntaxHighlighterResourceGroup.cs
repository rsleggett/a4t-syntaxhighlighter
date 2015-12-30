using Alchemy4Tridion.Plugins.GUI.Configuration;
using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;

namespace ElectricBiro.DevTools.SyntaxHighlighter
{
    public class SyntaxHighlighterResourceGroup : Alchemy4Tridion.Plugins.GUI.Configuration.ResourceGroup
    {
        public SyntaxHighlighterResourceGroup()
        {
            AddFile("SyntaxHighlighterCommand.js");
            AddFile<SyntaxHighlighterCommandSet>();
            Dependencies.AddAlchemyCore();
        }
    }
}
