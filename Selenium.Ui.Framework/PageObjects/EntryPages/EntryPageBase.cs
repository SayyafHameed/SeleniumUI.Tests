using Selenium.Ui.Framework.Factories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.EntryPages
{
    public abstract class EntryPageBase : PomBase, IEntryPage
    {
        public virtual void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
