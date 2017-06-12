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
using System.Windows.Forms.DataVisualization.Charting;

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
            try
            {
                driver = new ChromeDriver(".");
                driver.Navigate().GoToUrl("http://lab.25sprout.com/nrprnd/");
                driver.FindElement(By.Id("minLimit")).SendKeys(smallNum.Text);
                driver.FindElement(By.Id("maxLimit")).SendKeys(bigNum.Text);
                driver.FindElement(By.Id("rndCount")).SendKeys(rndCount.Text);

                int resultCount = Int32.Parse(bigNum.Text) - Int32.Parse(smallNum.Text) + 1;
                flowLayoutPanel.Controls.Clear();

                int[] result = new int[resultCount];
                for (int i = 0; i < Int32.Parse(testCount.Text); i++)
                {
                    try
                    {
                        foreach (var num in getNums())
                            result[num - 1]++;
                    }
                    catch (Exception ex)
                    {
                        i--;
                    }

                    try
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByClassName('lab-name')[0].innerHTML='已進行" + (i + 1).ToString() + "次, 尚有" + (Int32.Parse(testCount.Text) - (i + 1)) + "次';");
                    }
                    catch (Exception ex)
                    {

                    }
                }

                displayResult(resultCount, result);
                draw(result);
                driver.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("出現無法預期的例外狀況");
            }
            
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

            total.Text = data.Sum().ToString();
        }

        private void draw(int[] data)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add("各數字抽樣統計分布");

            Series[] serieses = new Series[Int32.Parse(bigNum.Text) - Int32.Parse(smallNum.Text) + 1];
            for (int i = 0; i < serieses.Length; i++)
            {
                serieses[i] = new Series();
                serieses[i].ChartType = SeriesChartType.Column;
                serieses[i].IsValueShownAsLabel = true;
                serieses[i].Name = (i + 1).ToString();
                serieses[i].Points.Add((double)data[i] / Int32.Parse(testCount.Text));
                chart.Series.Add(serieses[i]);
            }
        }

        private int[] getNums()
        {
            int[] result = new int[Int32.Parse(rndCount.Text)];
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
