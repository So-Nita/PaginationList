﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DataGridView_CS.UserControls;

namespace DataGridView_CS
{
    public partial class Form1 : Form
    {
        private List<Customer> customers;
        public UC_ProuductCard ProductCard { get; set; }
        public Form1()
        {
            InitializeComponent();
            InitializeSampleData();
        }

        int PageSize = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BindGrid(1);
        }
        private void InitializeSampleData()
        {
            customers = new List<Customer>();
            for (int i = 1; i <= 40; i++)
            {
                customers.Add(new Customer
                {
                    RowNumber = i,
                    CustomerID = $"CustomerID{i}",
                    ContactName = $"ContactName{i}",
                    Country = $"Country{i}"
                });
            }
        }
        private void BindGrid(int pageIndex)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RowNumber");
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("ContactName");
            dt.Columns.Add("Country");

            int startIndex = (pageIndex - 1) * PageSize;
            int endIndex = Math.Min(startIndex + PageSize, customers.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                DataRow row = dt.NewRow();
                row["RowNumber"] = customers[i].RowNumber;
                row["CustomerID"] = customers[i].CustomerID;
                row["ContactName"] = customers[i].ContactName;
                row["Country"] = customers[i].Country;
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
            PopulatePager(customers.Count, pageIndex);
        }

        private void PopulatePager(int recordCount, int currentPage)
        {
            List<Page> pages = new List<Page>();
            int startIndex, endIndex;
            int pagerSpan = 5;

            //Calculate the Start and End Index of pages to be displayed.
            double dblPageCount = (double)((decimal)recordCount / Convert.ToDecimal(PageSize));
            int pageCount = (int)Math.Ceiling(dblPageCount);
            startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1;
            endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
            if (currentPage > pagerSpan % 2)
            {
                if (currentPage == 2)
                {
                    endIndex = 5;
                }
                else
                {
                    endIndex = currentPage + 2;
                }
            }
            else
            {
                endIndex = (pagerSpan - currentPage) + 1;
            }

            if (endIndex - (pagerSpan - 1) > startIndex)
            {
                startIndex = endIndex - (pagerSpan - 1);
            }

            if (endIndex > pageCount)
            {
                endIndex = pageCount;
                startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
            }

            //Add the First Page Button.
            if (currentPage > 1)
            {
                pages.Add(new Page { Text = "First", Value = "1" });
            }

            //Add the Previous Button.
            if (currentPage > 1)
            {
                pages.Add(new Page { Text = "<<", Value = (currentPage - 1).ToString() });
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage });
            }

            //Add the Next Button.
            if (currentPage < pageCount)
            {
                pages.Add(new Page { Text = ">>", Value = (currentPage + 1).ToString() });
            }

            //Add the Last Button.
            if (currentPage != pageCount)
            {
                pages.Add(new Page { Text = "Last", Value = pageCount.ToString() });
            }

            //Clear existing Pager Buttons.
            pnlPager.Controls.Clear();

            //Loop and add Buttons for Pager.
            int count = 0;
            foreach (Page page in pages)
            {
                Button btnPage = new Button();
                btnPage.Location = new System.Drawing.Point(38 * count, 5);
                btnPage.Size = new System.Drawing.Size(35, 20);
                btnPage.Name = page.Value;
                btnPage.Text = page.Text;
                btnPage.Enabled = !page.Selected;
                btnPage.Click += new System.EventHandler(this.Page_Click);
                pnlPager.Controls.Add(btnPage);
                count++;
            }
        }

        private void Page_Click(object sender, EventArgs e)
        {
            Button btnPager = (sender as Button);
            this.BindGrid(int.Parse(btnPager.Name));
        }

        public class Page
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public bool Selected { get; set; }
        }
    }

    public class Customer
    {
        public int RowNumber { get; set; }
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
    }
}
