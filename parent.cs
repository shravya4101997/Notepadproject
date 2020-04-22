using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProjectnotepad__
{
    public enum PropertyType
    {
        Name,
        ClassName,
        ControlType



    }
    public class parent
    {
        private static WinWindow _parentWindow;

        public void SetParent(string windowName, string className, string titles)
        {
            _parentWindow = new WinWindow();
            _parentWindow.SearchProperties[WinWindow.PropertyNames.Name] = windowName;
            _parentWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = className;
            _parentWindow.WindowTitles.Add(titles);
            _parentWindow.DrawHighlight();

        }

        public void SetParent(string className, string Window)
        {
            _parentWindow = new WinWindow();
            _parentWindow.SearchProperties[WinWindow.PropertyNames.ControlType] = Window;
            _parentWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = className;
            _parentWindow.DrawHighlight();

        }


        public T ObjectCreator<T>(PropertyType property, string identificationValue) where T : WinControl
        {
            T control = (T)Activator.CreateInstance(typeof(T), new object[] { _parentWindow });
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