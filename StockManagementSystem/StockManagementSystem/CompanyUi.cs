using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Models;

namespace StockManagementSystem
{
    public partial class CompanyUi : Form
    {
        public CategoryManager categoryManager;
        public Category category;
        public CompanyUi()
        {
            InitializeComponent();
            categoryManager = new CategoryManager();
            category = new Category();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            categoryManager.InsertCategory(category);
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource= categoryManager.ShowCategory();
        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
