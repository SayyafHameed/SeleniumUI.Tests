using Selenium.Ui.Framework.PageObjects.Shared.Components;
using Selenium.Ui.Framework.PageObjects.Shared.Fields;
using Selenium.UI.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Ui.Framework.PageObjects.EntryPages.Login
{
    public class LoginPage : EntryPageBase
    {
        public override void Initialize()
        {
            var btn = LoginButton;

            Driver.GetElement("#footer", 10);
        }
        public TextField UserName => Select<TextField>("#user-name");
        public TextField Password => Select<TextField>("#password");
        public Button LoginButton => Select<Button>("#login-button");

    }
}
