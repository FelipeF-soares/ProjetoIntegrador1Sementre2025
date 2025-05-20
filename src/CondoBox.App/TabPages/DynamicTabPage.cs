using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.App.TabPages;

public class DynamicTabPage
{
    public void Add(string name, UserControl userControl,TabControl tabControl)
    {
        tabControl.TabPages.Clear();
        TabPage tabPage = new TabPage();
        userControl.Dock = DockStyle.Fill;
        tabPage.Name = name.ToLower().Trim();
        tabPage.Controls.Add(userControl);
        tabControl.Appearance = TabAppearance.FlatButtons;
        tabControl.ItemSize = new Size(0, 1);
        tabControl.SizeMode = TabSizeMode.Fixed;
        tabControl.TabPages.Add(tabPage);
        tabControl.SelectTab(tabPage);
    }
}
