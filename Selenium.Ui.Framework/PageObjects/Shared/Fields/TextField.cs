using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.Shared.Fields
{
    public class TextField : PomBase
    {
        public void SetValue(string value)
        {
            RelatedElement.SendKeys(value);
        }
    }
}
