using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace GlucoCheck.Forms
{
    public partial class FrmFoodSearch : Form
    {
        public FrmFoodSearch()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.nal.usda.gov/fdc/v1/foods/search?api_key=DEMO_KEY&query=" + TxtSearch.Text);
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            var jObject = JObject.Parse(response.Content);
            tblOutput.RowCount = 1;
            tblOutput.Controls.Clear();
            tblOutput.RowStyles.Clear();
            tblOutput.Controls.Add(new Label() { Text = "Description" }, 0, 0);
            tblOutput.Controls.Add(new Label() { Text = "Carbyhydrates" }, 1, 0);

            try
            {
                int totalHits = int.Parse(jObject.GetValue("totalHits").ToString());
                IList<JToken> foods = jObject["foods"].Children().ToList();

                for (int i = 0; i < totalHits; i++)
                {
                    IList<JToken> nutrients = foods[i]["foodNutrients"].Children().ToList();
                    double carbs = 0.0;
                    foreach (JToken nutrient in nutrients)
                    {
                        if (nutrient["nutrientName"].ToString().Contains("Carbohydrate"))
                        {
                            carbs = double.Parse(nutrient["value"].ToString());
                        }
                    }
                    tblOutput.RowCount++;
                    tblOutput.Controls.Add(new Label() { Text = foods[i]["description"].ToString() }, 0, i+1);
                    tblOutput.Controls.Add(new Label() { Text = carbs.ToString() }, 1, i+1);
                    
                    //LblResult.Text = "Name: " + foods[i]["description"].ToString() + "\nCarbs: " + carbs.ToString();
                }

            }
            catch (Exception ex)
            {
                LblResult.Text = ex.ToString();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFoodSearch_Load(object sender, EventArgs e)
        {

        }
    }
}