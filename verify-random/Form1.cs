using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace verify_random
{
    public partial class Form1 : Form
    {
        IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl("http://lab.25sprout.com/nrprnd/");

            int resultCount = Int32.Parse(bigNum.Text) - Int32.Parse(smallNum.Text) + 1;
            flowLayoutPanel.Controls.Clear();

            int[] result = new int[resultCount];
            for (int i = 0; i < Int32.Parse(testCount.Text); i++)
            {
                foreach (var num in getNums())
                    result[num - 1]++;
            }
            
            displayResult(resultCount, result);

            total.Text = result.Sum();
            driver.Quit();
        }

        private void displayResult(int count, int[] data)
        {
            flowLayoutPanel.Controls.Clear();
            Label[] label = new Label[count];

            for (int i = 0; i < count; i++)
            {
                label[i] = new Label();
                label[i].Text = (i + 1).ToString() + "出現次數為" + data[i];
                flowLayoutPanel.Controls.Add(label[i]);
            }
        }

        private int[] getNums()
        {
            int[] result = new int[Int32.Parse(rndCount.Text)];

            driver.FindElement(By.Id("minLimit")).Clear();
            driver.FindElement(By.Id("maxLimit")).Clear();
            driver.FindElement(By.Id("rndCount")).Clear();
            driver.FindElement(By.Id("minLimit")).SendKeys(smallNum.Text);
            driver.FindElement(By.Id("maxLimit")).SendKeys(bigNum.Text);
            driver.FindElement(By.Id("rndCount")).SendKeys(rndCount.Text);
            driver.FindElement(By.Id("btnMkRnd")).Click();

            IWebElement rndResult = driver.FindElement(By.Id("rndResult"));
            List<IWebElement> elements = new List<IWebElement>(rndResult.FindElements(By.TagName("div")));
            foreach (var element in elements)
            {
                int index = elements.IndexOf(element);
                result[index] = Int32.Parse(element.GetAttribute("innerHTML"));
            }

            return result;
        }
    }
}
