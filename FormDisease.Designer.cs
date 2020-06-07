﻿namespace Quantium
{
    partial class FormDisease
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundButton1 = new Quantium.RoundButton();
            this.buttonOk = new Quantium.RoundButton();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddDisease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Teal;
            this.roundButton1.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 10;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.ForeColor = System.Drawing.Color.Yellow;
            this.roundButton1.Location = new System.Drawing.Point(164, 80);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(84, 20);
            this.roundButton1.TabIndex = 35;
            this.roundButton1.Text = "Отмена";
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Teal;
            this.buttonOk.BackColor2 = System.Drawing.Color.Silver;
            this.buttonOk.ButtonBorderColor = System.Drawing.Color.Black;
            this.buttonOk.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.buttonOk.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.buttonOk.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.buttonOk.ButtonPressedColor = System.Drawing.Color.Red;
            this.buttonOk.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.buttonOk.ButtonPressedForeColor = System.Drawing.Color.White;
            this.buttonOk.ButtonRoundRadius = 10;
            this.buttonOk.Enabled = false;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.ForeColor = System.Drawing.Color.Yellow;
            this.buttonOk.Location = new System.Drawing.Point(74, 80);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(84, 20);
            this.buttonOk.TabIndex = 34;
            this.buttonOk.Text = "Сохранить";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(62, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(192, 21);
            this.label27.TabIndex = 32;
            this.label27.Text = "Название Болезни";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // btnAddDisease
            // 
            this.btnAddDisease.BackgroundImage = global::Quantium.Properties.Resources.add_to_queue_button;
            this.btnAddDisease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDisease.Location = new System.Drawing.Point(260, 43);
            this.btnAddDisease.Name = "btnAddDisease";
            this.btnAddDisease.Size = new System.Drawing.Size(23, 23);
            this.btnAddDisease.TabIndex = 40;
            this.btnAddDisease.UseVisualStyleBackColor = true;
            // 
            // FormDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 112);
            this.Controls.Add(this.btnAddDisease);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label27);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormDisease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDisease";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton roundButton1;
        private RoundButton buttonOk;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddDisease;
    }
}