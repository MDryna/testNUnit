using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testNUnit.PageObject;

namespace testNUnit.PageObject
{

    public class BasePage
    {
        public AuthorizationPageObject AuthorizationPageObject => new AuthorizationPageObject();
        public HomePageObject HomePageObject => new HomePageObject();
        public SchedulePageObject SchedulePageObject => new SchedulePageObject();
        public HostPageObject HostPageObject => new HostPageObject();
        public FrontendPageObject FrontendPageObject => new FrontendPageObject();
        public QaPageObject QaPageObject => new QaPageObject();
        public EnglishHostPageObject EnglishHostPageObject => new EnglishHostPageObject();

    }
}