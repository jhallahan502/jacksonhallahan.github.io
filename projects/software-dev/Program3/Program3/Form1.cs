using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void calcBtn_Click(object sender, EventArgs e)
        {
            
            // declare 6 arrays 
            string[] shippingProvider = { "USPS", "DHL", "FedEx", "UPS" }; //shipping companies
            double[] discountRates = { 0.22, 0.18, 0.19, 0.20 }; // % discount rates 

            string[] businessName = { "John's Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" }; // business names
            double[] contractPrices = { 50000.00, 85000.00, 60000.00, 75000.00, 95000.00, 55000.00 }; // inital contract prices

            int[] contractYearsLowEnd = { 0, 2, 5, 8 }; // contract yr range (low end)
            double[] additionalSavings = { 0.00, 10000.00, 20000.00, 30000.00 }; // additional saving amounts 

            //declare variables
            bool providerFound = false;
            bool businessFound = false;
            bool contractYearFound = false;

            string provider;
            string business;
            int contractYear;
            double finalPrice;
            
            
           
            // validations
            if (providerCombo.SelectedIndex >= 0) //provider combo selection
            {
                if (businessCombo.SelectedIndex >= 0) //business name combo selection
                {
                    if (int.TryParse(contractCombo.Text, out contractYear) && (contractYear >= 0) && (contractYear <= 10)) 
                    {
                        //look for discount based on company name

                        double discount = 0; //discount count
                        
                        for (int i = 0; i < shippingProvider.Length && !providerFound; i++) //valid provider input 
                        { if (providerCombo.Text = shippingProvider[i]) //within index
                            {
                                providerFound = true;
                                discount = discountRates[i];
                                provider = providerCombo.Text;
                            }
                        }

                        //look for contract price based on company name
                        
                        double contractPrice = 0; //contract price count
                        
                        for ( int i= 0; i < businessName.Length && !businessFound; i++) //valid business input
                        { if (businessCombo.Text = businessName[i]) //within index
                            {
                                businessFound = true;
                                contractPrice = contractPrices[i];
                                business = businessCombo.Text;
                            }
                        }

                        //range match, look for any additional savings                    
                        int index = contractYearsLowEnd.Length - 1; //range length 
                        double savings = 0; //savings count

                        while (index >= 0 && !contractYearFound) //valid input
                        {
                            if (index >= contractYearsLowEnd[0]) //contract range 1
                            {
                                contractYearFound = true;
                                savings = additionalSavings[0];
                            }
                            
                            else if (index >= contractYearsLowEnd[1]) //contract range 2
                            {
                                contractYearFound = true;
                                savings = additionalSavings[1];
                            }
                            
                            else if (index >= contractYearsLowEnd[2]) //contract range 3
                            {
                                contractYearFound = true;
                                savings = additionalSavings[2];
                            }

                            else if (index >= contractYearsLowEnd[3]) //contract range 4
                            {
                                contractYearFound = true;
                                savings = additionalSavings[3];
                            }
                           
                            int i = 0;
                            
                            if (contractYearFound)             
                                savings = additionalSavings[i];
                        }


                        //compute all totals and total price
                        discount = contractPrice * discount;
                        
                        finalPrice = contractPrice - discount - savings;



                        //output totals to labels
                        providerOutput.Text = $"{provider}";
                        contractOutput.Text = $"{contractPrice:C2}";
                        compDiscOutput.Text = $"{discount:C2}";
                        lengthDiscOutput.Text = $"{savings:C2}";
                        finalPriceOutput.Text = $"{finalPrice:C2}";



                      //3 message boxes  
                    }
                    else { MessageBox.Show("You Must Provide Contract Years [0,10]"); }
                }
                else { MessageBox.Show("You Must Select a Business"); }
            }
            else { MessageBox.Show("You Must Select a Provider"); }



        }
    }
}
