using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProjectnotepad__
{
    class basicnote : parent
    {
        public void parentmethod()
        {
            //parent window
            SetParent("new 1 - Notepad++", "Notepad++", "new 1 - Notepad++");

        }

        public void filemethod()
        {

            //menu
            ObjectCreator<WinMenuBar>(PropertyType.Name, "Application")
              .ObjectCreator<WinMenuItem>(PropertyType.Name, "File").Click();

        }

        public void openmethod()
        {
            SetParent("#32768", "Window");
            ObjectCreator<WinMenuItem>(PropertyType.Name, "New	Ctrl+N").Click();
            Keyboard.SendKeys("Hi shastri");

        }

        public void filesecond()
        {
            SetParent("*new 2 - Notepad++", "Notepad++", "*new 2 - Notepad++");
            ObjectCreator<WinMenuBar>(PropertyType.Name, "Application")
              .ObjectCreator<WinMenuItem>(PropertyType.Name, "File").Click();

        }

        public void savemethod()
        {
            ObjectCreator<WinMenuItem>(PropertyType.Name,"Save As...	Ctrl+Alt+S").Click();
            SetParent("#32770", "Window");
            ObjectCreator<WinButton>(PropertyType.Name, "Desktop").Click();
            WinEdit c = ObjectCreator<WinEdit>(PropertyType.Name, "File name:");
            c.Text="newtextin";

            ObjectCreator<WinComboBox>(PropertyType.Name, "Save as type:").Click();
            ObjectCreator<WinListItem>(PropertyType.Name, "Normal text file (*.txt)").Click();
            ObjectCreator<WinButton>(PropertyType.Name,"Save").Click();



        }
       /*public bool exists(string p)
        {
            Console.WriteLine(File.Exists(p) ? "File exists." : "File doesnot exist");
            return File.Exists(p);

        }*/
    }



}
