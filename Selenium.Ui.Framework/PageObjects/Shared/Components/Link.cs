using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.Shared.Components
{
    public class Link : PomBase
    {
        public void Click()
        {
            RelatedElement.Click();
        }
    }
}
