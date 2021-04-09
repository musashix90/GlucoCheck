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

            try
            {
                string totalHits = jObject.GetValue("totalHits").ToString();
                IList<JToken> foods = jObject["foods"].Children().ToList();

                string firstFoodName = foods[0]["description"].ToString();
                IList<JToken> nutrients = foods[0]["foodNutrients"].Children().ToList();
                double carbs = 0.0;
                foreach (JToken nutrient in nutrients)
                {
                    if (nutrient["nutrientName"].ToString().Contains("Carbohydrate"))
                    {
                        carbs = double.Parse(nutrient["value"].ToString());
                    }
                }
                LblResult.Text = "Name: " + firstFoodName + "\nCarbs: " + carbs.ToString();
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
    }
}