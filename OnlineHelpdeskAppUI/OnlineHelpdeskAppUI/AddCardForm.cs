using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Core;
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

        private void btn_addCard_Click(object sender, EventArgs e)
        {
            CardAmountType amountType = EnumHelper.StringToEnum<CardAmountType>(txbx_amount.Text);
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
