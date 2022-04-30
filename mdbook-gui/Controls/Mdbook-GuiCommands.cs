// Copyright © 2018-2019 The Mdbook_Gui Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.


using System.Windows.Input;

namespace mdbook_gui.Controls
{
    public static class Mdbook_GuiCommands
    {
        public static RoutedUICommand DefaultProject = new RoutedUICommand("DefaultProject", "DefaultProject", typeof(Mdbook_GuiCommands));
        /*
        **
        */
        public static RoutedUICommand Export = new RoutedUICommand("Export", "Export", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand Close = new RoutedUICommand("Close", "Close", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand Exit = new RoutedUICommand("Exit", "Exit", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand ToggleServer = new RoutedUICommand("ToggleServer", "ToggleServer", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand Build = new RoutedUICommand("Build", "Build", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand Rebuild = new RoutedUICommand("Rebuild", "Rebuild", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand Clean = new RoutedUICommand("Clean", "Clean", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand Mdbook = new RoutedUICommand("Mdbook", "Mdbook", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand Commonmark = new RoutedUICommand("Commonmark", "Commonmark", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand Webdev = new RoutedUICommand("Webdev", "Webdev", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand MingongSeparator = new RoutedUICommand("MingongSeparator", "MingongSeparator", typeof(Mdbook_GuiCommands));
        public static RoutedUICommand About = new RoutedUICommand("About", "About", typeof(Mdbook_GuiCommands));
    }
}
