using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using testNUnit.Map;
using testNUnit.PageObject;

namespace testNUnit
{
    public class BaseTest
    {

        public static IWebDriver driver;
        protected BasePage BasePage;
        protected BaseMap BaseMap;

        [OneTimeSetUp]

        protected void DoBeforeAllTheTests() //���������� ���� ��� ����� �������� �����
        {
            driver = new ChromeDriver();//���������� ����������

        }


        [OneTimeTearDown]
        public void DoAfterAllTheTests() //����������� ���� ��� ���� ��� �����
        {
            driver.Quit();
        }

        [SetUp]
        protected void DobeforeEach()//����������� ����� ������ ������
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Cookies.DeleteAllCookies();//�������� ��� ���� ���� �������
            driver.Navigate().GoToUrl(TestSettings.HostUrl); //������� Ur�, �� ��������� � ���� TestSettings 
            driver.Manage().Window.Maximize();  //������� ��� ������� Chrome �� ���� ����� �������

            this.BasePage = new BasePage();
            
        }
        [TearDown]
        protected void DoAfterEach()  //����������� ���� ������� �����
        {

        
        }
    }
}