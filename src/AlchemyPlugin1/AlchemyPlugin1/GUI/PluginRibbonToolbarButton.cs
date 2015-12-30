﻿using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace AlchemyPlugin1.GUI
{
    public class PluginRibbonToolbarButton : Alchemy4Tridion.Plugins.GUI.Configuration.RibbonToolbarExtension
    {
        public PluginRibbonToolbarButton()
        {
            // The unique identifier used for the html element created.
            AssignId = "SayHelloButton";

            // The name of the command to execute when clicked
            Command = "SayHello";

            // The label of the button.
            Name = "Say Hello";

            // The page tab to assign this extension to. See Constants.PageIds.
            PageId = Constants.PageIds.HomePage;

            // Option GroupId, put this into an existing group (not capable if using a .ascx Control)
            GroupId = Constants.GroupIds.HomePage.ShareGroup;

            // The tooltip label that will get applied.
            Title = "Say Hello";

            // Add a dependency to the resource group that contains the files/commands that this toolbar extension will use.
            Dependencies.Add<PluginResourceGroup>();

            // apply the extension to a specific view.
            Apply.ToView(Constants.Views.DashboardView, "DashboardToolbar");
        }
    }
}
