/*
 * Grading ID: K3194
 * Program 3
 * Due Date: 4/1/2022
 * Course Section: CIS 199-01
 * Description: Calculates flower costs based on user inputted garden type, item number, and quantity of flowers.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) //Event handler for clicking calculate button
        {
			string[] GARDEN_TYPE = { "Discount", "Standard", "Premium" }; //String array holding valid garden types
			double[] GARDEN_TYPE_MULTIPLIER = { 0.9, 1.0, 1.1 }; //Double array holding multipliers for corresponding garden types

			int[] FLOWER_NUMBER = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 }; //Int array holding valid item/flower numbers
			double[] FLOWER_COST = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 }; //Double array holding prices for corresponding flowers

			int[] QUANTITY_UPPER_BOUND = { 5, 15, 20 }; //Int array holding upper bound values for determining quantity discount
			double[] QUANTITY_DISCOUNT_MULTIPLIER = { 0.00, 0.05, 0.10, 0.15 }; //Double array holding multipliers for corresponding quantity ranges

			string gardenType = gardenTypeInputComboBox.Text; //String to hold garden type input

			if (!(gardenTypeInputComboBox.SelectedIndex >= 0)) //Verify that user selected a value in garden type combo box
            {
				displayError("GARDEN TYPE");
				return; //End execution of function in case of error
			}

			if (int.TryParse(itemNumberInputTextBox.Text, out int itemNumber)) //Attempt to parse user inputted item number and store in itemNumber variable
			{
				bool itemFound = false;
				foreach (int i in FLOWER_NUMBER) //Search for a matching item number in array
				{
					if (i == itemNumber)
					{
						itemFound = true;
					}
				}
				if (!itemFound) //If no matching item found, display error
				{
					displayError("ITEM #");
					return; 
				}
			}
			else //If item number can't be parsed, display error
			{
				displayError("ITEM #");
				return;
			}

			if (int.TryParse(quantityInputTextBox.Text, out int quantity)) //Attempt to parse user inputted quantity and store in quantity variable
			{
				if (quantity <= 0) //If quantity is 0 or less, display error
				{
					displayError("QUANTITY");
					return; 
				}
			}
			else //If quantity can't be parsed, display error
			{
				displayError("QUANTITY");
				return;
			}

			double gardenTypeMultiplier = 0.0; //Double to hold garden type multiplier
			double singleFlowerCost = 0.0; //Double to hold individual flower cost for selected flower
			double totalFlowerCost = 0.0; //Double to hold flower total prior to garden type and quantity modifiers
			double adjustedFlowerCost = 0.0; //Double to hold total flower cost after garden type multiplier
			double discountPercentage = 0.0; //Double to hold discount percentage
			double totalPrice = 0.0; //Double to hold the final total price of the flower order

			for (int i = 0; i < GARDEN_TYPE.Length; i++) //Searches for the multiplier associated with the selected garden type
			{
				if (GARDEN_TYPE[i] == gardenType)
				{
					gardenTypeMultiplier = GARDEN_TYPE_MULTIPLIER[i];
					break; //end execution of loop to avoid unnecessary iterations
				}
			}

			for (int i = 0; i < FLOWER_NUMBER.Length; i++) //Searches for the individual flower cost and sets the singleFlowerCost, totalFlowerCost, and adjustedFlowerCost
			{
				if (FLOWER_NUMBER[i] == itemNumber)
				{
					singleFlowerCost = FLOWER_COST[i];
					totalFlowerCost = singleFlowerCost * quantity;
					adjustedFlowerCost = totalFlowerCost * gardenTypeMultiplier;
					break;
				}
			}

			bool quantityFound = false;
			for (int i = 0; i < QUANTITY_UPPER_BOUND.Length; i++) //Searches for the quantity discount percentage based on inputted quantity
			{
				if (quantity <= QUANTITY_UPPER_BOUND[i])
				{
					discountPercentage = QUANTITY_DISCOUNT_MULTIPLIER[i];
					quantityFound = true;
					break;
				}
			}

			if (!quantityFound) //If the quantity wasn't below the highest upper bound, set the discount percentage to the maximum
			{
				discountPercentage = QUANTITY_DISCOUNT_MULTIPLIER[QUANTITY_DISCOUNT_MULTIPLIER.Length - 1];
			}

			totalPrice = adjustedFlowerCost * (1 - discountPercentage); //Calculate total price and store in totalPrice

			flowersCostOutputLabel.Text = totalFlowerCost.ToString("C2"); //Set text of output label to corresponding values with proper formatting
			baseAdjustedCostOutputLabel.Text = adjustedFlowerCost.ToString("C2");
			discountPercentOutputLabel.Text = discountPercentage.ToString("P2");
			totalPriceOutputLabel.Text = totalPrice.ToString("C2");
		}

        private void displayError(string field) //Accepts a string and sets each output field to INVALID ________
        {
            flowersCostOutputLabel.Text = $"INVALID {field}";
            baseAdjustedCostOutputLabel.Text = $"INVALID {field}";
            discountPercentOutputLabel.Text = $"INVALID {field}";
            totalPriceOutputLabel.Text = $"INVALID {field}";
        }
    }
}
