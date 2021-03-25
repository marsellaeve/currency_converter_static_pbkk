using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace dynamic_currency_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            currencyList();
        }
        public void currencyList()
        {
            APIRequester currencyListRequest = new APIRequester("https://free.currconv.com/api/v7/currencies?apiKey=03749addd4f7a194dd84");
            CurrencyList currencyList = CurrencyList.Deserialize(currencyListRequest.SendAndGetResponse());

            CurrencyData[] datas = currencyList.ToArray();
            foreach (CurrencyData currency in datas)
            {
                fromComboBox.Items.Add(currency.id);
                toComboBox.Items.Add(currency.id);
            }
        }
        public static double Exchange(string from, string to, string date)
        {
            string url;
            url = "https://free.currencyconverterapi.com/api/v6/" + "convert?q=" + from + "_" + to + "&compact=y&date=" + date + "&apiKey=03749addd4f7a194dd84";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            string jsonString;
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            return JObject.Parse(jsonString).First.First["val"].First.ToObject<double>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input.Text))
            {
                output.Text = "Insert Amount";
            }
            else
            {
                if (string.IsNullOrEmpty(fromComboBox.Text) || string.IsNullOrEmpty(toComboBox.Text))
                {
                    output.Text = "Choose Currency";
                }
                else
                {
                    double input2 = Convert.ToDouble(input.Text);
                    double rate = Exchange(fromComboBox.Text, toComboBox.Text, datepicker.Value.Date.ToString("yyyy-MM-dd"));
                    input2 = input2 * rate;

                    output.Text = Convert.ToString(input2);
                }
            }
        }
    }
}
