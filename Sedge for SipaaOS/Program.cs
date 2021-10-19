using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace Sedge_for_SipaaOS
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Tab tab = new Tab();
            tab.Tabs.Add(new EasyTabs.TitleBarTab(tab)
            {
                Content = new BrowserForm
                {
                    Text = "New Tab"
                }
            });
            tab.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext context = new TitleBarTabsApplicationContext();
            context.Start(tab);
            Application.Run(context);
        }
    }
}
