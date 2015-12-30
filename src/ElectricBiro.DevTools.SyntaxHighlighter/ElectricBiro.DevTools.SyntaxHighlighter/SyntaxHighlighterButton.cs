using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace ElectricBiro.DevTools.SyntaxHighlighter
{
    public class SyntaxHighlighterButton : Alchemy4Tridion.Plugins.GUI.Configuration.RibbonToolbarExtension
    {
        public SyntaxHighlighterButton()
        {
            // The unique identifier used for the html element created.
            AssignId = "cm_syntaxhighlight";

            // The name of the command to execute when clicked
            Command = "SyntaxHighlighterCommand";

            // The label of the button.
            Name = "Enable Syntax Highlighting";

            // The page tab to assign this extension to. See Constants.PageIds.
            PageId = Constants.PageIds.HomePage;

            // The tooltip label that will get applied.
            Title = "Enable Syntax Highlighting";

            // Add a dependency to the resource group that contains the files/commands that this toolbar extension will use.
            Dependencies.Add<SyntaxHighlighterResourceGroup>();

            // apply the extension to a specific view.
            Apply.ToView("TemplateBuildingBlockView", "ItemToolbar");
            Apply.ToView("SchemaView", "ItemToolbar");
            Apply.ToView("ComponentVew", "ItemToolbar");
            Apply.ToView("ComponentTemplateView","ItemToolbar");
            Apply.ToView("PageTemplateView", "ItemToolbar");
        }
    }
}
