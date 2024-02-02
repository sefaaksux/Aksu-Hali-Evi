﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AksuHaliEvi
{
    public partial class Kasa : Form
    {

        private readonly MyDbContext _context;
        public Kasa()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }

       

        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            var query = from item in _context.Turnovers
                        select new
                        {
                            ToplamGiris = item.TotalIncome,
                            ToplamCikis = item.TotalExpense
                        };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
