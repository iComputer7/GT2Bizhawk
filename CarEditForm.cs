using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GT2Bizhawk.GameComponents;

namespace GT2Bizhawk {
    public partial class CarEditForm : Form {
        private Car EditCar { get; set; }

        public CarEditForm(Car carToEdit) {
            InitializeComponent();
            EditCar = carToEdit;
        }

        private void CarEditList_DoubleClick(object sender, MouseEventArgs e) {
            //getting the item that was clicked
            //var curItem = CarEditList.GetItemAt(e.X, e.Y);
            //if (curItem == null)
            //    return;

            //getting the column that was clicked
            //var curSubItem = curItem.GetSubItemAt(e.X, e.Y);
            //if (curItem.SubItems.IndexOf(curSubItem) != 1) 
            //    return;

            //placing a text box

        }
    }
}
