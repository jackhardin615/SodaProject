using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace SodaProject
{

    public partial class Home : System.Web.UI.Page
    {
        static double quarter = 0.00;
        static string coinTotal = String.Format("{0:C}", quarter);
        static int cokeAmount = 2;
        static int dietcokeAmount = 5;
        static int spriteAmount = 3;
        static int drpepperAmount = 0;




        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)

            //Check if Coca-Cola is sold out
            SoldOut(cokeAmountlbl, cokeAmount);

            //Check if Diet Coca-Cola is sold out
            SoldOut(dietcokeAmountlbl, dietcokeAmount);

            //Check if Sprite is sold out
            SoldOut(spriteAmountlbl, spriteAmount);

            //Check if Dr. Pepper is sold out
            SoldOut(drpepperAmountlbl, drpepperAmount);
        }


        //Insert Coin button
        protected void insertCoinBtn_Click(object sender, EventArgs e)
        {
            refundBtn.Visible = true;
            quarter += 0.25;
            UpdateCoins(totalAmountlbl);

        }


        //Refund coin button
        protected void refundBtn_Click(object sender, EventArgs e)
        {

            if (quarter > 0.25)
            {
                quarter -= 0.25;
                UpdateCoins(totalAmountlbl);
            }
            else if (quarter == 0.25)
            {
                quarter -= 0.25;
                UpdateCoins(totalAmountlbl);
                refundBtn.Visible = false;
            }
            else
            {
                totalAmountlbl.Text = coinTotal;
                refundBtn.Visible = false;
            }

        }


        //Change available lable to sold out
        static void SoldOut(Label label, int soda)
        {
            if (soda > 0)
            {
                label.Text = soda.ToString();
            }
            else
            {
                label.Text = "SOLD OUT";
            }
        }


        //Update total number of coins in machine
        static void UpdateCoins(Label label)
        {
            string coinTotal = String.Format("{0:C}", quarter);
            label.Text = coinTotal;
        }


        //Coca-Cola button
        protected void cokeBtn_Click(object sender, EventArgs e)
        {
            
            if (quarter > 0.25)
            {
                if (cokeAmount > 0)
                {
                    cokeAmount -= 1;
                    quarter -= 0.25;
                    SoldOut(cokeAmountlbl, cokeAmount);
                    UpdateCoins(totalAmountlbl);
                }
                else
                {
                    SoldOut(cokeAmountlbl, cokeAmount);
                    Response.Write("<script>alert('Sold Out. Please try another soda.');</script>");
                }
                
            }
            else if (quarter == 0.25)
            {
                if (cokeAmount > 0)
                {
                    cokeAmount -= 1;
                    quarter -= 0.25;
                    SoldOut(cokeAmountlbl, cokeAmount);
                    UpdateCoins(totalAmountlbl);
                }
                else
                {
                    SoldOut(cokeAmountlbl, cokeAmount);
                    Response.Write("<script>alert('Sold Out. Please try another soda.');</script>");
                    refundBtn.Visible = false;
                }
                
            }

            else
            {
                refundBtn.Visible = false;
                Response.Write("<script>alert('Insert a quarter');</script>");
            }

        }

        //Diet Coke button
        protected void dietcokeBtn_Click(object sender, EventArgs e)
        {
            if (quarter > 0.25)
            {
                if (dietcokeAmount > 0)
                {
                    dietcokeAmount -= 1;
                    quarter -= 0.25;
                    SoldOut(dietcokeAmountlbl, dietcokeAmount);
                    UpdateCoins(totalAmountlbl);
                }
                else
                {
                    SoldOut(dietcokeAmountlbl, dietcokeAmount);
                    Response.Write("<script>alert('Sold Out. Please try another soda.');</script>");
                }

            }
            else if (quarter == 0.25)
            {
                if (dietcokeAmount > 0)
                {
                    dietcokeAmount -= 1;
                    quarter -= 0.25;
                    SoldOut(dietcokeAmountlbl, dietcokeAmount);
                    UpdateCoins(totalAmountlbl);
                }
                else
                {
                    SoldOut(dietcokeAmountlbl, dietcokeAmount);
                    Response.Write("<script>alert('Sold Out. Please try another soda.');</script>");
                    refundBtn.Visible = false;
                }

            }

            else
            {
                refundBtn.Visible = false;
                Response.Write("<script>alert('Insert a quarter');</script>");
            }


        }




        //Sprite button
        protected void spriteBtn_Click(object sender, EventArgs e)
        {
            
            if (quarter > 0.25)
            {
                if (spriteAmount > 0)
                {
                    spriteAmount -= 1;
                    quarter -= 0.25;
                    SoldOut(spriteAmountlbl, spriteAmount);
                    UpdateCoins(totalAmountlbl);
                }
                else
                {
                    SoldOut(spriteAmountlbl, spriteAmount);
                    Response.Write("<script>alert('Sold Out. Please try another soda.');</script>");
                }

            }
            else if (quarter == 0.25)
            {
                if (spriteAmount > 0)
                {
                    spriteAmount -= 1;
                    quarter -= 0.25;
                    SoldOut(spriteAmountlbl, spriteAmount);
                    UpdateCoins(totalAmountlbl);
                }
                else
                {
                    SoldOut(spriteAmountlbl, spriteAmount);
                    Response.Write("<script>alert('Sold Out. Please try another soda.');</script>");
                    refundBtn.Visible = false;
                }

            }

            else
            {
                refundBtn.Visible = false;
                Response.Write("<script>alert('Insert a quarter');</script>");
            }
        }


        //Dr. Pepper button
        protected void drpepperBtn_Click(object sender, EventArgs e)
        {
            

                if (quarter > 0.25)
                {
                    if (drpepperAmount > 0)
                    {
                        drpepperAmount -= 1;
                        quarter -= 0.25;
                        SoldOut(drpepperAmountlbl, drpepperAmount);
                        UpdateCoins(totalAmountlbl);
                    }
                    else
                    {
                        SoldOut(drpepperAmountlbl, drpepperAmount);
                        Response.Write("<script>alert('Sold Out. Please try another soda.');</script>");
                    }

                }
                else if (quarter == 0.25)
                {
                    if (drpepperAmount > 0)
                    {
                    drpepperAmount -= 1;
                    quarter -= 0.25;
                    SoldOut(drpepperAmountlbl, drpepperAmount);
                    UpdateCoins(totalAmountlbl);
                    }
                    else
                    {
                    SoldOut(drpepperAmountlbl, drpepperAmount);
                    Response.Write("<script>alert('Sold Out. Please try another soda.');</script>");
                    refundBtn.Visible = false;
                    }

                }

                else
                {
                    refundBtn.Visible = false;
                    Response.Write("<script>alert('Insert a quarter');</script>");
                }

            
        }
    }

    
    }


