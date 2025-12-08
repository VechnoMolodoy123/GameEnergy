using GameEnergy.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GameEnergy.CustomControls
{
    public partial class OrderControl : UserControl
    {
        private Orders _order;
        private List<OrderItems> _orderItems;

        public OrderControl(Orders order)
        {
            InitializeComponent();

            _order = Program.context.Orders.AsNoTracking().FirstOrDefault(o => o.OrderID == order.OrderID);
            _orderItems = Program.context.OrderItems.Where(oi => oi.OrderID == order.OrderID).ToList();

            LoadItemInfo();
        }

        private void LoadItemInfo()
        {
            orderNumberLabel.Text = $"№{_order.OrderID} - {_order.OrderDate:dd.MM.yyyy}";
            totalAmountLabel.Text = $"{_order.TotalAmount} ₽";

            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            itemsPanel.Controls.Clear();

            foreach (var item in _orderItems)
            {
                var itemControl = new CartAndOrderItemsControl(item);
                itemControl.Margin = new Padding(0, 0, 0, 10);
                itemsPanel.Controls.Add(itemControl);
            }
        }
    }
}
