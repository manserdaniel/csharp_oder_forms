using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarkt_Forms
{
    public partial class OrderFormular : Form
    {
        Dictionary<string, int> order = new Dictionary<string, int>();
        public OrderFormular()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void addClick(object sender, EventArgs e)
        {
            var product = tbProduct.Text;
            int.TryParse(tbAmount.Text, out var amount);

            if(!string.IsNullOrEmpty(product))
            {
                try
                {
                    order.Add(product, amount);
                }
                catch (ArgumentException)
                {
                    order[product] += amount;
                }
                UpdateList();
            }
        }

        private void UpdateList()
        {
            lboxOutput.DataSource = order.Select(x => $"{x.Key} ({x.Value})").ToList();
        }

        private void removeClick(object sender, EventArgs e)
        {
            var product = tbProduct.Text;
            int.TryParse(tbAmount.Text, out var amount);

            if (!string.IsNullOrEmpty(product) && order.ContainsKey(product))
            {
                if (order[product] > 0)
                {
                    order[product] -= amount;
                }
                if (order[product] <= 0)
                {
                    order.Remove(product);
                }
                UpdateList();
            }

        }
    }
}
