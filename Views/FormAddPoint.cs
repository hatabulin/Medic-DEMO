﻿using Quantium.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quantium
{
    public partial class FormAddPoint : Form
    {
        FormMain _form;
        int x, y;
        String _humanSide;
        int _humanModelId;
        List<PointModel> pointModels = new List<PointModel>();

        public FormAddPoint(FormMain form, int humanModelId, int x, int y,String humanSide)
        {
            _form = form;
            this.x = x;
            this.y = y;
            _humanSide = humanSide;
            _humanModelId = humanModelId;

            InitializeComponent();
            cbPointLink.SelectedIndex = 0;
            SetPointData(x, y, humanSide);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointModel pointModel = new PointModel(
                Convert.ToInt16(textBoxPointX.Text),
                Convert.ToInt16(textBoxPointY.Text),
                cbPointLink.SelectedIndex,
                comboBoxPointSide.Text,
                textBoxPointName.Text,
                0, _humanModelId);
            DataAccess.AddToHumanPointsTable(pointModel);

            _form.DrawPoint(x,y,_humanSide);
            
            this.Close();
        }

        private void FormAddPoint_Load(object sender, EventArgs e)
        {
            this.Region = new Region(
            CustomFormClass.RoundedRect(
            new Rectangle(0, 0, this.Width, this.Height)
                    , 10
                )
            );
            DataAccess.GetPointsFromHumanTable(pointModels, _humanModelId);
        }

        private void cbPointLink_DrawItem(object sender, DrawItemEventArgs e)
        {
            string text = ((ComboBox)sender).Items[e.Index].ToString();
            e.DrawBackground();
            Brush brush = Brushes.Black;
            Color HighlightColor = Color.Red;

            for (int i=0;i<pointModels.Count;i++)
            {
                if (e.Index == pointModels[i].channel)
                {
                    brush = Brushes.Red;
                    break;
                }
            }

            e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
