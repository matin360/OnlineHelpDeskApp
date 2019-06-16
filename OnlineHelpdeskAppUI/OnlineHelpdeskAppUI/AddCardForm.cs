using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Core;
using OnlineHelpdeskAppUI.Exceptions;
using OnlineHelpdeskAppUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineHelpdeskAppUI
{
    public partial class AddCardForm : Form
    {
        public AddCardForm()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
           string guid = Guid.NewGuid().ToString();
            guid = guid.Substring(guid.IndexOf('-') + 1, 14);
            txbx_cardNumber.Text = guid.ToUpper();

            Random random = new Random();
            int number = random.Next(0, 4);

          CardAmountType[] enumValues = (CardAmountType[])Enum.GetValues(typeof(CardAmountType));
            CardAmountType cardAmountType = enumValues[number];
           txbx_amount.Text = ((int)cardAmountType).ToString();

            CardData cardData = new CardData();
           MonthType monthType = cardData.GetMonthByAmountType(cardAmountType);
            txbx_expireDate.Text = DateTime.Now.AddMonths((int)monthType).ToString();
        }

        private CardAmountType GetCardAmountTypeFromString(string amount)
        {
            CardAmountType cardAmountType;
            if (amount == null)
            {
                throw new ArgumentNullException("Amount cannot be null!");
            }
            else if (amount.Length == 0)
            {
                throw new DataEmptyException("Amount cannot be empty!");
            }
            else if (!int.TryParse(amount, out int result))
            {
                throw new ArgumentException("Amount is not a number!");
            }
            else
            {
                cardAmountType = EnumHelper.StringToEnum<CardAmountType>(amount);
            }
            return cardAmountType; 
        }

        private void btn_addCard_Click(object sender, EventArgs e)
        {
            try
            {
                CardAmountType amountType = GetCardAmountTypeFromString(txbx_amount.Text);
                DateTime expireDate = DateTime.Parse(txbx_expireDate.Text);

                Card card = new Card
                {
                    CreateDate = DateTime.Now,
                    cardAmountType = amountType,
                    ExpireDate = expireDate,
                    Number = txbx_cardNumber.Text,
                    Id = Identifier<Card>.GenereteId()

                };
                DbContext.Cards.Add(card);
            }
            catch (ArgumentNullException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (DataEmptyException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (ArgumentException exp)
            {
                MessageBox.Show(exp.Message);
            }
            ShowStastics();


        }

        private void AddCardForm_Load(object sender, EventArgs e)
        {
            ShowStastics();
        }

        private void ShowStastics()
        {
            int count = DbContext.Cards.GetAll().Count;
            lnkLbl_count.Text = count.ToString();
        }
    }
}
