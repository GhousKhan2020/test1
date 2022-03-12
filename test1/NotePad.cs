using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test1
{
    class NotePad : BaseCUITNotePad
    {
        public void testmethod()
        {
            SetParent("Notepad++");
            ObjectCreator<WinButton>(PropertyType.Name, "Maximize").Click();
            //WinWindow np = new WinWindow();
            //np.SearchProperties[WinWindow.PropertyNames.ClassName]
            //    = "Notepad++";
            //WinTitleBar tp = new WinTitleBar(np);
            //tp.SearchProperties[WinTitleBar.PropertyNames.ControlType]
            //    = "TitleBar";
            //WinButton MaximizeButton = new WinButton(tp);
            //MaximizeButton.SearchProperties[WinButton.PropertyNames.Name]
            // = "Maximize";
            //Thread.Sleep(500);
            //Mouse.Click(MaximizeButton);
        }
    }
}
