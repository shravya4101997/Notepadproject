using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProjectnotepad__
{
    public static class basextention
    { 
        public static void Click(this WinControl Control)
        {
            Mouse.Click(Control);

        }

        public static T ObjectCreator<T>(this WinControl parentu, PropertyType property, string identificationValue) where T : WinControl
        {
            T control = (T)Activator.CreateInstance(typeof(T), new object[] { parentu });
            if (property == PropertyType.Name)
                control.SearchProperties[WinControl.PropertyNames.Name] = identificationValue;
            if (property == PropertyType.ClassName)
                control.SearchProperties[WinControl.PropertyNames.ClassName] = identificationValue;
            if (property == PropertyType.ControlType)
                control.SearchProperties[WinControl.PropertyNames.ControlType] = identificationValue;



            return control;
        }
    }
}
