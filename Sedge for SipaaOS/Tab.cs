using System;
using EasyTabs;

namespace Sedge_for_SipaaOS
{
    public partial class Tab : TitleBarTabs
    {
        public Tab()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }


        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new BrowserForm
                {
                    Text = "New Tab"
                }
            };
        }
    }
}