using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void calcBtn_Click(object sender, EventArgs e) //when user clicks button

        {
            //declare const variables 
            const double medicalBase = 160.00;
            const double dentalBase = 20.00;
            const double visionBase = 30.00;
            const double fullCarBase = 110.00;
            const double liabilityCarBase = 50.00;
            const double minorFee = 25.00;
            const double smokingFee = 70.00;
            const double accidentFee = 1.20;
            const double CAR_VALUE_DISCOUNT = 0.88;
            const double MIN_VALUE = 15000;


            //declare variables
            int age;
            int carValue;
            double totalPolicyCost;
            double totalHealth = 0;
            double totalCar = 0;
            string medical;
            string dental;
            string vision;
            string full;
            string liability;
            bool hasAutoCoverage;
            bool hasMedicalCoverage;

           

            {
                if (int.TryParse(ageTxtBox.Text, out age) && (age >= 21 && age <= 120)) //valid age input
                { if (int.TryParse(carValueTxt.Text, out carValue) && (carValue >= 0)) //valif car input
                    { if (healthCovCombo.SelectedIndex >= 0) //health coverage selected
                        { if (carComboBox.SelectedIndex >= 0) // car coverage selected
                            {
                                //calc heath coverage
                                {
                                    if (healthCovCombo.Text = medical) //??
                                    {
                                        totalHealth += medicalBase;
                                        ++totalHealth;
                                    }

                                    else if (healthCovCombo.Text = dental)
                                    {
                                        totalHealth += dentalBase;
                                        ++totalHealth;
                                    }

                                    else if (healthCovCombo.Text = vision)
                                    {
                                        totalHealth += visionBase;
                                        ++totalHealth;
                                    }

                                    if (hasMedicalCoverage && smokeBtn1.Checked)
                                    {
                                        totalHealth += smokingFee;
                                        ++totalHealth;
                                    }

                                    else if (hasMedicalCoverage && smokeBtn2.Checked)
                                        ++totalHealth;
                                }

                                //calc car coverage
                                {
                                    if (carComboBox.Text = full) //?
                                        totalCar += fullCarBase;

                                    else if (carComboBox.Text = liability)
                                        totalCar += liabilityCarBase;

                                    if (hasAutoCoverage && accidentBtn1.Checked)
                                    {
                                        totalCar *= accidentFee;
                                        ++totalCar;
                                    }

                                    else if (hasAutoCoverage && accidentBtn2.Checked)
                                        ++totalCar;

                                    if (age < 21)
                                        totalCar += minorFee;

                                    else if (carValue <= MIN_VALUE)
                                        totalCar *= CAR_VALUE_DISCOUNT;


                                }
                                // calc and display totals to labels
                                totalPolicyCost = totalHealth + totalCar;
                                annualHealthCost.Text = $"{totalHealth:c}";
                                annualCarCost.Text = $"{totalCar:c}";
                                annualPolicyCost.Text = $"{totalPolicyCost:c}";
                            
                          //error messages for invalid user input
                            }else
                                MessageBox.Show("Please select Car Coverage option!");
                        } else
                            MessageBox.Show("Please select Health Coverage option!");
                    } else
                        MessageBox.Show("Invalid car value entered!");
                } else
                    MessageBox.Show("Invalid age entered!");

            }

        }
    }

}
