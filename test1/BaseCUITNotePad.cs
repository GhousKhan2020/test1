using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class BaseCUITNotePad
    {

      public  enum PropertyType
        {
            Name,
            ControlName,
            ClassName

        }
        private static WinWindow _parentWindow;
        public void SetParent(string name)
        {
            _parentWindow = new WinWindow();
            _parentWindow.SearchProperties[WinWindow.PropertyNames.ClassName]
               = "Notepad++";
            // _parentWindow.SearchProperties[WinWindow.PropertyNames.]
        }
        //identification value is to identify our control from search property by name or classname
        public T ObjectCreator<T>(PropertyType Property, string IdentificationValue) where T: WinControl
        {
            T control = (T)Activator.CreateInstance(typeof(T), new object[] { _parentWindow });
            if (Property.Equals(PropertyType.Name))
                control.SearchProperties[WinControl.PropertyNames.Name] 
                    = IdentificationValue;
            if (Property.Equals(PropertyType.ClassName))
                control.SearchProperties[WinControl.PropertyNames.ClassName] 
                    = IdentificationValue;
            if (Property.Equals(PropertyType.ControlName))
                control.SearchProperties[WinControl.PropertyNames.ControlName] 
                    = IdentificationValue;

            return control;
        }
    }
}
