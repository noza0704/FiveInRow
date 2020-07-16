using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveInRow
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.startButton.Click += new EventHandler(startButton_Click); 
            
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.b0 = new FiveInRow.EllipseButton();
            this.b88 = new FiveInRow.EllipseButton();
            this.b87 = new FiveInRow.EllipseButton();
            this.b78 = new FiveInRow.EllipseButton();
            this.b77 = new FiveInRow.EllipseButton();
            this.b68 = new FiveInRow.EllipseButton();
            this.b67 = new FiveInRow.EllipseButton();
            this.b86 = new FiveInRow.EllipseButton();
            this.b76 = new FiveInRow.EllipseButton();
            this.b66 = new FiveInRow.EllipseButton();
            this.b85 = new FiveInRow.EllipseButton();
            this.b75 = new FiveInRow.EllipseButton();
            this.b65 = new FiveInRow.EllipseButton();
            this.b84 = new FiveInRow.EllipseButton();
            this.b74 = new FiveInRow.EllipseButton();
            this.b64 = new FiveInRow.EllipseButton();
            this.b83 = new FiveInRow.EllipseButton();
            this.b73 = new FiveInRow.EllipseButton();
            this.b63 = new FiveInRow.EllipseButton();
            this.b98 = new FiveInRow.EllipseButton();
            this.b97 = new FiveInRow.EllipseButton();
            this.b96 = new FiveInRow.EllipseButton();
            this.b95 = new FiveInRow.EllipseButton();
            this.b94 = new FiveInRow.EllipseButton();
            this.b93 = new FiveInRow.EllipseButton();
            this.b62 = new FiveInRow.EllipseButton();
            this.b99 = new FiveInRow.EllipseButton();
            this.b89 = new FiveInRow.EllipseButton();
            this.b79 = new FiveInRow.EllipseButton();
            this.b69 = new FiveInRow.EllipseButton();
            this.b72 = new FiveInRow.EllipseButton();
            this.b82 = new FiveInRow.EllipseButton();
            this.b92 = new FiveInRow.EllipseButton();
            this.b91 = new FiveInRow.EllipseButton();
            this.b81 = new FiveInRow.EllipseButton();
            this.b71 = new FiveInRow.EllipseButton();
            this.b61 = new FiveInRow.EllipseButton();
            this.b90 = new FiveInRow.EllipseButton();
            this.b80 = new FiveInRow.EllipseButton();
            this.b70 = new FiveInRow.EllipseButton();
            this.b60 = new FiveInRow.EllipseButton();
            this.b59 = new FiveInRow.EllipseButton();
            this.b58 = new FiveInRow.EllipseButton();
            this.b57 = new FiveInRow.EllipseButton();
            this.b56 = new FiveInRow.EllipseButton();
            this.b55 = new FiveInRow.EllipseButton();
            this.b54 = new FiveInRow.EllipseButton();
            this.b53 = new FiveInRow.EllipseButton();
            this.b52 = new FiveInRow.EllipseButton();
            this.b51 = new FiveInRow.EllipseButton();
            this.b50 = new FiveInRow.EllipseButton();
            this.b49 = new FiveInRow.EllipseButton();
            this.b48 = new FiveInRow.EllipseButton();
            this.b47 = new FiveInRow.EllipseButton();
            this.b46 = new FiveInRow.EllipseButton();
            this.b45 = new FiveInRow.EllipseButton();
            this.b44 = new FiveInRow.EllipseButton();
            this.b43 = new FiveInRow.EllipseButton();
            this.b42 = new FiveInRow.EllipseButton();
            this.b41 = new FiveInRow.EllipseButton();
            this.b40 = new FiveInRow.EllipseButton();
            this.b39 = new FiveInRow.EllipseButton();
            this.b38 = new FiveInRow.EllipseButton();
            this.b37 = new FiveInRow.EllipseButton();
            this.b36 = new FiveInRow.EllipseButton();
            this.b35 = new FiveInRow.EllipseButton();
            this.b34 = new FiveInRow.EllipseButton();
            this.b33 = new FiveInRow.EllipseButton();
            this.b32 = new FiveInRow.EllipseButton();
            this.b31 = new FiveInRow.EllipseButton();
            this.b30 = new FiveInRow.EllipseButton();
            this.b29 = new FiveInRow.EllipseButton();
            this.b28 = new FiveInRow.EllipseButton();
            this.b27 = new FiveInRow.EllipseButton();
            this.b26 = new FiveInRow.EllipseButton();
            this.b25 = new FiveInRow.EllipseButton();
            this.b24 = new FiveInRow.EllipseButton();
            this.b23 = new FiveInRow.EllipseButton();
            this.b22 = new FiveInRow.EllipseButton();
            this.b21 = new FiveInRow.EllipseButton();
            this.b19 = new FiveInRow.EllipseButton();
            this.b17 = new FiveInRow.EllipseButton();
            this.b18 = new FiveInRow.EllipseButton();
            this.b9 = new FiveInRow.EllipseButton();
            this.b8 = new FiveInRow.EllipseButton();
            this.b7 = new FiveInRow.EllipseButton();
            this.b6 = new FiveInRow.EllipseButton();
            this.b16 = new FiveInRow.EllipseButton();
            this.b15 = new FiveInRow.EllipseButton();
            this.b14 = new FiveInRow.EllipseButton();
            this.b13 = new FiveInRow.EllipseButton();
            this.b12 = new FiveInRow.EllipseButton();
            this.b11 = new FiveInRow.EllipseButton();
            this.b20 = new FiveInRow.EllipseButton();
            this.b10 = new FiveInRow.EllipseButton();
            this.b1 = new FiveInRow.EllipseButton();
            this.b2 = new FiveInRow.EllipseButton();
            this.b3 = new FiveInRow.EllipseButton();
            this.b4 = new FiveInRow.EllipseButton();
            this.b5 = new FiveInRow.EllipseButton();
            this.ellipseButton3 = new FiveInRow.EllipseButton();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b0
            // 
            this.b0.BorderColor = System.Drawing.Color.Gray;
            this.b0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b0.DisplayBorder = true;
            this.b0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b0.Location = new System.Drawing.Point(22, 22);
            this.b0.Name = "b0";
            this.b0.Radius = 15;
            this.b0.Size = new System.Drawing.Size(36, 36);
            this.b0.TabIndex = 106;
            this.b0.Click += new System.EventHandler(this.button_Click);
            // 
            // b88
            // 
            this.b88.BorderColor = System.Drawing.Color.Gray;
            this.b88.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b88.DisplayBorder = true;
            this.b88.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b88.Location = new System.Drawing.Point(582, 582);
            this.b88.Name = "b88";
            this.b88.Radius = 15;
            this.b88.Size = new System.Drawing.Size(36, 36);
            this.b88.TabIndex = 206;
            this.b88.Click += new System.EventHandler(this.button_Click);
            // 
            // b87
            // 
            this.b87.BorderColor = System.Drawing.Color.Gray;
            this.b87.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b87.DisplayBorder = true;
            this.b87.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b87.Location = new System.Drawing.Point(512, 582);
            this.b87.Name = "b87";
            this.b87.Radius = 15;
            this.b87.Size = new System.Drawing.Size(36, 36);
            this.b87.TabIndex = 205;
            this.b87.Click += new System.EventHandler(this.button_Click);
            // 
            // b78
            // 
            this.b78.BorderColor = System.Drawing.Color.Gray;
            this.b78.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b78.DisplayBorder = true;
            this.b78.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b78.Location = new System.Drawing.Point(582, 512);
            this.b78.Name = "b78";
            this.b78.Radius = 15;
            this.b78.Size = new System.Drawing.Size(36, 36);
            this.b78.TabIndex = 204;
            this.b78.Click += new System.EventHandler(this.button_Click);
            // 
            // b77
            // 
            this.b77.BorderColor = System.Drawing.Color.Gray;
            this.b77.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b77.DisplayBorder = true;
            this.b77.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b77.Location = new System.Drawing.Point(512, 512);
            this.b77.Name = "b77";
            this.b77.Radius = 15;
            this.b77.Size = new System.Drawing.Size(36, 36);
            this.b77.TabIndex = 203;
            this.b77.Click += new System.EventHandler(this.button_Click);
            // 
            // b68
            // 
            this.b68.BorderColor = System.Drawing.Color.Gray;
            this.b68.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b68.DisplayBorder = true;
            this.b68.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b68.Location = new System.Drawing.Point(582, 442);
            this.b68.Name = "b68";
            this.b68.Radius = 15;
            this.b68.Size = new System.Drawing.Size(36, 36);
            this.b68.TabIndex = 202;
            this.b68.Click += new System.EventHandler(this.button_Click);
            // 
            // b67
            // 
            this.b67.BorderColor = System.Drawing.Color.Gray;
            this.b67.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b67.DisplayBorder = true;
            this.b67.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b67.Location = new System.Drawing.Point(512, 442);
            this.b67.Name = "b67";
            this.b67.Radius = 15;
            this.b67.Size = new System.Drawing.Size(36, 36);
            this.b67.TabIndex = 201;
            this.b67.Click += new System.EventHandler(this.button_Click);
            // 
            // b86
            // 
            this.b86.BorderColor = System.Drawing.Color.Gray;
            this.b86.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b86.DisplayBorder = true;
            this.b86.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b86.Location = new System.Drawing.Point(442, 582);
            this.b86.Name = "b86";
            this.b86.Radius = 15;
            this.b86.Size = new System.Drawing.Size(36, 36);
            this.b86.TabIndex = 200;
            this.b86.Click += new System.EventHandler(this.button_Click);
            // 
            // b76
            // 
            this.b76.BorderColor = System.Drawing.Color.Gray;
            this.b76.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b76.DisplayBorder = true;
            this.b76.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b76.Location = new System.Drawing.Point(442, 512);
            this.b76.Name = "b76";
            this.b76.Radius = 15;
            this.b76.Size = new System.Drawing.Size(36, 36);
            this.b76.TabIndex = 199;
            this.b76.Click += new System.EventHandler(this.button_Click);
            // 
            // b66
            // 
            this.b66.BorderColor = System.Drawing.Color.Gray;
            this.b66.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b66.DisplayBorder = true;
            this.b66.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b66.Location = new System.Drawing.Point(442, 442);
            this.b66.Name = "b66";
            this.b66.Radius = 15;
            this.b66.Size = new System.Drawing.Size(36, 36);
            this.b66.TabIndex = 198;
            this.b66.Click += new System.EventHandler(this.button_Click);
            // 
            // b85
            // 
            this.b85.BorderColor = System.Drawing.Color.Gray;
            this.b85.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b85.DisplayBorder = true;
            this.b85.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b85.Location = new System.Drawing.Point(372, 582);
            this.b85.Name = "b85";
            this.b85.Radius = 15;
            this.b85.Size = new System.Drawing.Size(36, 36);
            this.b85.TabIndex = 197;
            this.b85.Click += new System.EventHandler(this.button_Click);
            // 
            // b75
            // 
            this.b75.BorderColor = System.Drawing.Color.Gray;
            this.b75.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b75.DisplayBorder = true;
            this.b75.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b75.Location = new System.Drawing.Point(372, 512);
            this.b75.Name = "b75";
            this.b75.Radius = 15;
            this.b75.Size = new System.Drawing.Size(36, 36);
            this.b75.TabIndex = 196;
            this.b75.Click += new System.EventHandler(this.button_Click);
            // 
            // b65
            // 
            this.b65.BorderColor = System.Drawing.Color.Gray;
            this.b65.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b65.DisplayBorder = true;
            this.b65.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b65.Location = new System.Drawing.Point(372, 442);
            this.b65.Name = "b65";
            this.b65.Radius = 15;
            this.b65.Size = new System.Drawing.Size(36, 36);
            this.b65.TabIndex = 195;
            this.b65.Click += new System.EventHandler(this.button_Click);
            // 
            // b84
            // 
            this.b84.BorderColor = System.Drawing.Color.Gray;
            this.b84.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b84.DisplayBorder = true;
            this.b84.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b84.Location = new System.Drawing.Point(302, 582);
            this.b84.Name = "b84";
            this.b84.Radius = 15;
            this.b84.Size = new System.Drawing.Size(36, 36);
            this.b84.TabIndex = 194;
            this.b84.Click += new System.EventHandler(this.button_Click);
            // 
            // b74
            // 
            this.b74.BorderColor = System.Drawing.Color.Gray;
            this.b74.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b74.DisplayBorder = true;
            this.b74.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b74.Location = new System.Drawing.Point(302, 512);
            this.b74.Name = "b74";
            this.b74.Radius = 15;
            this.b74.Size = new System.Drawing.Size(36, 36);
            this.b74.TabIndex = 193;
            this.b74.Click += new System.EventHandler(this.button_Click);
            // 
            // b64
            // 
            this.b64.BorderColor = System.Drawing.Color.Gray;
            this.b64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b64.DisplayBorder = true;
            this.b64.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b64.Location = new System.Drawing.Point(302, 442);
            this.b64.Name = "b64";
            this.b64.Radius = 15;
            this.b64.Size = new System.Drawing.Size(36, 36);
            this.b64.TabIndex = 192;
            this.b64.Click += new System.EventHandler(this.button_Click);
            // 
            // b83
            // 
            this.b83.BorderColor = System.Drawing.Color.Gray;
            this.b83.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b83.DisplayBorder = true;
            this.b83.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b83.Location = new System.Drawing.Point(232, 582);
            this.b83.Name = "b83";
            this.b83.Radius = 15;
            this.b83.Size = new System.Drawing.Size(36, 36);
            this.b83.TabIndex = 191;
            this.b83.Click += new System.EventHandler(this.button_Click);
            // 
            // b73
            // 
            this.b73.BorderColor = System.Drawing.Color.Gray;
            this.b73.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b73.DisplayBorder = true;
            this.b73.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b73.Location = new System.Drawing.Point(232, 512);
            this.b73.Name = "b73";
            this.b73.Radius = 15;
            this.b73.Size = new System.Drawing.Size(36, 36);
            this.b73.TabIndex = 190;
            this.b73.Click += new System.EventHandler(this.button_Click);
            // 
            // b63
            // 
            this.b63.BorderColor = System.Drawing.Color.Gray;
            this.b63.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b63.DisplayBorder = true;
            this.b63.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b63.Location = new System.Drawing.Point(232, 442);
            this.b63.Name = "b63";
            this.b63.Radius = 15;
            this.b63.Size = new System.Drawing.Size(36, 36);
            this.b63.TabIndex = 189;
            this.b63.Click += new System.EventHandler(this.button_Click);
            // 
            // b98
            // 
            this.b98.BorderColor = System.Drawing.Color.Gray;
            this.b98.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b98.DisplayBorder = true;
            this.b98.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b98.Location = new System.Drawing.Point(582, 652);
            this.b98.Name = "b98";
            this.b98.Radius = 15;
            this.b98.Size = new System.Drawing.Size(36, 36);
            this.b98.TabIndex = 188;
            this.b98.Click += new System.EventHandler(this.button_Click);
            // 
            // b97
            // 
            this.b97.BorderColor = System.Drawing.Color.Gray;
            this.b97.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b97.DisplayBorder = true;
            this.b97.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b97.Location = new System.Drawing.Point(512, 652);
            this.b97.Name = "b97";
            this.b97.Radius = 15;
            this.b97.Size = new System.Drawing.Size(36, 36);
            this.b97.TabIndex = 187;
            this.b97.Click += new System.EventHandler(this.button_Click);
            // 
            // b96
            // 
            this.b96.BorderColor = System.Drawing.Color.Gray;
            this.b96.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b96.DisplayBorder = true;
            this.b96.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b96.Location = new System.Drawing.Point(442, 652);
            this.b96.Name = "b96";
            this.b96.Radius = 15;
            this.b96.Size = new System.Drawing.Size(36, 36);
            this.b96.TabIndex = 186;
            this.b96.Click += new System.EventHandler(this.button_Click);
            // 
            // b95
            // 
            this.b95.BorderColor = System.Drawing.Color.Gray;
            this.b95.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b95.DisplayBorder = true;
            this.b95.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b95.Location = new System.Drawing.Point(372, 652);
            this.b95.Name = "b95";
            this.b95.Radius = 15;
            this.b95.Size = new System.Drawing.Size(36, 36);
            this.b95.TabIndex = 185;
            this.b95.Click += new System.EventHandler(this.button_Click);
            // 
            // b94
            // 
            this.b94.BorderColor = System.Drawing.Color.Gray;
            this.b94.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b94.DisplayBorder = true;
            this.b94.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b94.Location = new System.Drawing.Point(302, 652);
            this.b94.Name = "b94";
            this.b94.Radius = 15;
            this.b94.Size = new System.Drawing.Size(36, 36);
            this.b94.TabIndex = 184;
            this.b94.Click += new System.EventHandler(this.button_Click);
            // 
            // b93
            // 
            this.b93.BorderColor = System.Drawing.Color.Gray;
            this.b93.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b93.DisplayBorder = true;
            this.b93.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b93.Location = new System.Drawing.Point(232, 652);
            this.b93.Name = "b93";
            this.b93.Radius = 15;
            this.b93.Size = new System.Drawing.Size(36, 36);
            this.b93.TabIndex = 183;
            this.b93.Click += new System.EventHandler(this.button_Click);
            // 
            // b62
            // 
            this.b62.BorderColor = System.Drawing.Color.Gray;
            this.b62.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b62.DisplayBorder = true;
            this.b62.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b62.Location = new System.Drawing.Point(162, 442);
            this.b62.Name = "b62";
            this.b62.Radius = 15;
            this.b62.Size = new System.Drawing.Size(36, 36);
            this.b62.TabIndex = 182;
            this.b62.Click += new System.EventHandler(this.button_Click);
            // 
            // b99
            // 
            this.b99.BorderColor = System.Drawing.Color.Gray;
            this.b99.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b99.DisplayBorder = true;
            this.b99.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b99.Location = new System.Drawing.Point(652, 652);
            this.b99.Name = "b99";
            this.b99.Radius = 15;
            this.b99.Size = new System.Drawing.Size(36, 36);
            this.b99.TabIndex = 181;
            this.b99.Click += new System.EventHandler(this.button_Click);
            // 
            // b89
            // 
            this.b89.BorderColor = System.Drawing.Color.Gray;
            this.b89.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b89.DisplayBorder = true;
            this.b89.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b89.Location = new System.Drawing.Point(652, 582);
            this.b89.Name = "b89";
            this.b89.Radius = 15;
            this.b89.Size = new System.Drawing.Size(36, 36);
            this.b89.TabIndex = 180;
            this.b89.Click += new System.EventHandler(this.button_Click);
            // 
            // b79
            // 
            this.b79.BorderColor = System.Drawing.Color.Gray;
            this.b79.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b79.DisplayBorder = true;
            this.b79.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b79.Location = new System.Drawing.Point(652, 512);
            this.b79.Name = "b79";
            this.b79.Radius = 15;
            this.b79.Size = new System.Drawing.Size(36, 36);
            this.b79.TabIndex = 179;
            this.b79.Click += new System.EventHandler(this.button_Click);
            // 
            // b69
            // 
            this.b69.BorderColor = System.Drawing.Color.Gray;
            this.b69.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b69.DisplayBorder = true;
            this.b69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b69.Location = new System.Drawing.Point(652, 442);
            this.b69.Name = "b69";
            this.b69.Radius = 15;
            this.b69.Size = new System.Drawing.Size(36, 36);
            this.b69.TabIndex = 178;
            this.b69.Click += new System.EventHandler(this.button_Click);
            // 
            // b72
            // 
            this.b72.BorderColor = System.Drawing.Color.Gray;
            this.b72.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b72.DisplayBorder = true;
            this.b72.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b72.Location = new System.Drawing.Point(162, 512);
            this.b72.Name = "b72";
            this.b72.Radius = 15;
            this.b72.Size = new System.Drawing.Size(36, 36);
            this.b72.TabIndex = 177;
            this.b72.Click += new System.EventHandler(this.button_Click);
            // 
            // b82
            // 
            this.b82.BorderColor = System.Drawing.Color.Gray;
            this.b82.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b82.DisplayBorder = true;
            this.b82.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b82.Location = new System.Drawing.Point(162, 582);
            this.b82.Name = "b82";
            this.b82.Radius = 15;
            this.b82.Size = new System.Drawing.Size(36, 36);
            this.b82.TabIndex = 176;
            this.b82.Click += new System.EventHandler(this.button_Click);
            // 
            // b92
            // 
            this.b92.BorderColor = System.Drawing.Color.Gray;
            this.b92.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b92.DisplayBorder = true;
            this.b92.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b92.Location = new System.Drawing.Point(162, 652);
            this.b92.Name = "b92";
            this.b92.Radius = 15;
            this.b92.Size = new System.Drawing.Size(36, 36);
            this.b92.TabIndex = 175;
            this.b92.Click += new System.EventHandler(this.button_Click);
            // 
            // b91
            // 
            this.b91.BorderColor = System.Drawing.Color.Gray;
            this.b91.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b91.DisplayBorder = true;
            this.b91.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b91.Location = new System.Drawing.Point(92, 652);
            this.b91.Name = "b91";
            this.b91.Radius = 15;
            this.b91.Size = new System.Drawing.Size(36, 36);
            this.b91.TabIndex = 174;
            this.b91.Click += new System.EventHandler(this.button_Click);
            // 
            // b81
            // 
            this.b81.BorderColor = System.Drawing.Color.Gray;
            this.b81.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b81.DisplayBorder = true;
            this.b81.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b81.Location = new System.Drawing.Point(92, 582);
            this.b81.Name = "b81";
            this.b81.Radius = 15;
            this.b81.Size = new System.Drawing.Size(36, 36);
            this.b81.TabIndex = 173;
            this.b81.Click += new System.EventHandler(this.button_Click);
            // 
            // b71
            // 
            this.b71.BorderColor = System.Drawing.Color.Gray;
            this.b71.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b71.DisplayBorder = true;
            this.b71.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b71.Location = new System.Drawing.Point(92, 512);
            this.b71.Name = "b71";
            this.b71.Radius = 15;
            this.b71.Size = new System.Drawing.Size(36, 36);
            this.b71.TabIndex = 172;
            this.b71.Click += new System.EventHandler(this.button_Click);
            // 
            // b61
            // 
            this.b61.BorderColor = System.Drawing.Color.Gray;
            this.b61.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b61.DisplayBorder = true;
            this.b61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b61.Location = new System.Drawing.Point(92, 442);
            this.b61.Name = "b61";
            this.b61.Radius = 15;
            this.b61.Size = new System.Drawing.Size(36, 36);
            this.b61.TabIndex = 171;
            this.b61.Click += new System.EventHandler(this.button_Click);
            // 
            // b90
            // 
            this.b90.BorderColor = System.Drawing.Color.Gray;
            this.b90.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b90.DisplayBorder = true;
            this.b90.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b90.Location = new System.Drawing.Point(22, 652);
            this.b90.Name = "b90";
            this.b90.Radius = 15;
            this.b90.Size = new System.Drawing.Size(36, 36);
            this.b90.TabIndex = 170;
            this.b90.Click += new System.EventHandler(this.button_Click);
            // 
            // b80
            // 
            this.b80.BorderColor = System.Drawing.Color.Gray;
            this.b80.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b80.DisplayBorder = true;
            this.b80.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b80.Location = new System.Drawing.Point(22, 582);
            this.b80.Name = "b80";
            this.b80.Radius = 15;
            this.b80.Size = new System.Drawing.Size(36, 36);
            this.b80.TabIndex = 169;
            this.b80.Click += new System.EventHandler(this.button_Click);
            // 
            // b70
            // 
            this.b70.BorderColor = System.Drawing.Color.Gray;
            this.b70.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b70.DisplayBorder = true;
            this.b70.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b70.Location = new System.Drawing.Point(22, 512);
            this.b70.Name = "b70";
            this.b70.Radius = 15;
            this.b70.Size = new System.Drawing.Size(36, 36);
            this.b70.TabIndex = 168;
            this.b70.Click += new System.EventHandler(this.button_Click);
            // 
            // b60
            // 
            this.b60.BorderColor = System.Drawing.Color.Gray;
            this.b60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b60.DisplayBorder = true;
            this.b60.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b60.Location = new System.Drawing.Point(22, 442);
            this.b60.Name = "b60";
            this.b60.Radius = 15;
            this.b60.Size = new System.Drawing.Size(36, 36);
            this.b60.TabIndex = 167;
            this.b60.Click += new System.EventHandler(this.button_Click);
            // 
            // b59
            // 
            this.b59.BorderColor = System.Drawing.Color.Gray;
            this.b59.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b59.DisplayBorder = true;
            this.b59.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b59.Location = new System.Drawing.Point(652, 372);
            this.b59.Name = "b59";
            this.b59.Radius = 15;
            this.b59.Size = new System.Drawing.Size(36, 36);
            this.b59.TabIndex = 166;
            this.b59.Click += new System.EventHandler(this.button_Click);
            // 
            // b58
            // 
            this.b58.BorderColor = System.Drawing.Color.Gray;
            this.b58.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b58.DisplayBorder = true;
            this.b58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b58.Location = new System.Drawing.Point(582, 372);
            this.b58.Name = "b58";
            this.b58.Radius = 15;
            this.b58.Size = new System.Drawing.Size(36, 36);
            this.b58.TabIndex = 165;
            this.b58.Click += new System.EventHandler(this.button_Click);
            // 
            // b57
            // 
            this.b57.BorderColor = System.Drawing.Color.Gray;
            this.b57.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b57.DisplayBorder = true;
            this.b57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b57.Location = new System.Drawing.Point(512, 372);
            this.b57.Name = "b57";
            this.b57.Radius = 15;
            this.b57.Size = new System.Drawing.Size(36, 36);
            this.b57.TabIndex = 164;
            this.b57.Click += new System.EventHandler(this.button_Click);
            // 
            // b56
            // 
            this.b56.BorderColor = System.Drawing.Color.Gray;
            this.b56.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b56.DisplayBorder = true;
            this.b56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b56.Location = new System.Drawing.Point(440, 372);
            this.b56.Name = "b56";
            this.b56.Radius = 15;
            this.b56.Size = new System.Drawing.Size(36, 36);
            this.b56.TabIndex = 163;
            this.b56.Click += new System.EventHandler(this.button_Click);
            // 
            // b55
            // 
            this.b55.BorderColor = System.Drawing.Color.Gray;
            this.b55.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b55.DisplayBorder = true;
            this.b55.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b55.Location = new System.Drawing.Point(372, 372);
            this.b55.Name = "b55";
            this.b55.Radius = 15;
            this.b55.Size = new System.Drawing.Size(36, 36);
            this.b55.TabIndex = 162;
            this.b55.Click += new System.EventHandler(this.button_Click);
            // 
            // b54
            // 
            this.b54.BorderColor = System.Drawing.Color.Gray;
            this.b54.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b54.DisplayBorder = true;
            this.b54.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b54.Location = new System.Drawing.Point(302, 372);
            this.b54.Name = "b54";
            this.b54.Radius = 15;
            this.b54.Size = new System.Drawing.Size(36, 36);
            this.b54.TabIndex = 161;
            this.b54.Click += new System.EventHandler(this.button_Click);
            // 
            // b53
            // 
            this.b53.BorderColor = System.Drawing.Color.Gray;
            this.b53.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b53.DisplayBorder = true;
            this.b53.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b53.Location = new System.Drawing.Point(232, 372);
            this.b53.Name = "b53";
            this.b53.Radius = 15;
            this.b53.Size = new System.Drawing.Size(36, 36);
            this.b53.TabIndex = 160;
            this.b53.Click += new System.EventHandler(this.button_Click);
            // 
            // b52
            // 
            this.b52.BorderColor = System.Drawing.Color.Gray;
            this.b52.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b52.DisplayBorder = true;
            this.b52.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b52.Location = new System.Drawing.Point(162, 372);
            this.b52.Name = "b52";
            this.b52.Radius = 15;
            this.b52.Size = new System.Drawing.Size(36, 36);
            this.b52.TabIndex = 159;
            this.b52.Click += new System.EventHandler(this.button_Click);
            // 
            // b51
            // 
            this.b51.BorderColor = System.Drawing.Color.Gray;
            this.b51.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b51.DisplayBorder = true;
            this.b51.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b51.Location = new System.Drawing.Point(92, 372);
            this.b51.Name = "b51";
            this.b51.Radius = 15;
            this.b51.Size = new System.Drawing.Size(36, 36);
            this.b51.TabIndex = 158;
            this.b51.Click += new System.EventHandler(this.button_Click);
            // 
            // b50
            // 
            this.b50.BorderColor = System.Drawing.Color.Gray;
            this.b50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b50.DisplayBorder = true;
            this.b50.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b50.Location = new System.Drawing.Point(22, 372);
            this.b50.Name = "b50";
            this.b50.Radius = 15;
            this.b50.Size = new System.Drawing.Size(36, 36);
            this.b50.TabIndex = 157;
            this.b50.Click += new System.EventHandler(this.button_Click);
            // 
            // b49
            // 
            this.b49.BorderColor = System.Drawing.Color.Gray;
            this.b49.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b49.DisplayBorder = true;
            this.b49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b49.Location = new System.Drawing.Point(652, 302);
            this.b49.Name = "b49";
            this.b49.Radius = 15;
            this.b49.Size = new System.Drawing.Size(36, 36);
            this.b49.TabIndex = 156;
            this.b49.Click += new System.EventHandler(this.button_Click);
            // 
            // b48
            // 
            this.b48.BorderColor = System.Drawing.Color.Gray;
            this.b48.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b48.DisplayBorder = true;
            this.b48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b48.Location = new System.Drawing.Point(582, 302);
            this.b48.Name = "b48";
            this.b48.Radius = 15;
            this.b48.Size = new System.Drawing.Size(36, 36);
            this.b48.TabIndex = 155;
            this.b48.Click += new System.EventHandler(this.button_Click);
            // 
            // b47
            // 
            this.b47.BorderColor = System.Drawing.Color.Gray;
            this.b47.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b47.DisplayBorder = true;
            this.b47.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b47.Location = new System.Drawing.Point(512, 302);
            this.b47.Name = "b47";
            this.b47.Radius = 15;
            this.b47.Size = new System.Drawing.Size(36, 36);
            this.b47.TabIndex = 154;
            this.b47.Click += new System.EventHandler(this.button_Click);
            // 
            // b46
            // 
            this.b46.BorderColor = System.Drawing.Color.Gray;
            this.b46.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b46.DisplayBorder = true;
            this.b46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b46.Location = new System.Drawing.Point(442, 302);
            this.b46.Name = "b46";
            this.b46.Radius = 15;
            this.b46.Size = new System.Drawing.Size(36, 36);
            this.b46.TabIndex = 153;
            this.b46.Click += new System.EventHandler(this.button_Click);
            // 
            // b45
            // 
            this.b45.BorderColor = System.Drawing.Color.Gray;
            this.b45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b45.DisplayBorder = true;
            this.b45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b45.Location = new System.Drawing.Point(372, 302);
            this.b45.Name = "b45";
            this.b45.Radius = 15;
            this.b45.Size = new System.Drawing.Size(36, 36);
            this.b45.TabIndex = 152;
            this.b45.Click += new System.EventHandler(this.button_Click);
            // 
            // b44
            // 
            this.b44.BorderColor = System.Drawing.Color.Gray;
            this.b44.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b44.DisplayBorder = true;
            this.b44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b44.Location = new System.Drawing.Point(302, 302);
            this.b44.Name = "b44";
            this.b44.Radius = 15;
            this.b44.Size = new System.Drawing.Size(36, 36);
            this.b44.TabIndex = 151;
            this.b44.Click += new System.EventHandler(this.button_Click);
            // 
            // b43
            // 
            this.b43.BorderColor = System.Drawing.Color.Gray;
            this.b43.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b43.DisplayBorder = true;
            this.b43.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b43.Location = new System.Drawing.Point(232, 302);
            this.b43.Name = "b43";
            this.b43.Radius = 15;
            this.b43.Size = new System.Drawing.Size(36, 36);
            this.b43.TabIndex = 150;
            this.b43.Click += new System.EventHandler(this.button_Click);
            // 
            // b42
            // 
            this.b42.BorderColor = System.Drawing.Color.Gray;
            this.b42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b42.DisplayBorder = true;
            this.b42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b42.Location = new System.Drawing.Point(162, 302);
            this.b42.Name = "b42";
            this.b42.Radius = 15;
            this.b42.Size = new System.Drawing.Size(36, 36);
            this.b42.TabIndex = 149;
            this.b42.Click += new System.EventHandler(this.button_Click);
            // 
            // b41
            // 
            this.b41.BorderColor = System.Drawing.Color.Gray;
            this.b41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b41.DisplayBorder = true;
            this.b41.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b41.Location = new System.Drawing.Point(92, 302);
            this.b41.Name = "b41";
            this.b41.Radius = 15;
            this.b41.Size = new System.Drawing.Size(36, 36);
            this.b41.TabIndex = 148;
            this.b41.Click += new System.EventHandler(this.button_Click);
            // 
            // b40
            // 
            this.b40.BorderColor = System.Drawing.Color.Gray;
            this.b40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b40.DisplayBorder = true;
            this.b40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b40.Location = new System.Drawing.Point(22, 302);
            this.b40.Name = "b40";
            this.b40.Radius = 15;
            this.b40.Size = new System.Drawing.Size(36, 36);
            this.b40.TabIndex = 147;
            this.b40.Click += new System.EventHandler(this.button_Click);
            // 
            // b39
            // 
            this.b39.BorderColor = System.Drawing.Color.Gray;
            this.b39.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b39.DisplayBorder = true;
            this.b39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b39.Location = new System.Drawing.Point(652, 232);
            this.b39.Name = "b39";
            this.b39.Radius = 15;
            this.b39.Size = new System.Drawing.Size(36, 36);
            this.b39.TabIndex = 146;
            this.b39.Click += new System.EventHandler(this.button_Click);
            // 
            // b38
            // 
            this.b38.BorderColor = System.Drawing.Color.Gray;
            this.b38.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b38.DisplayBorder = true;
            this.b38.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b38.Location = new System.Drawing.Point(582, 232);
            this.b38.Name = "b38";
            this.b38.Radius = 15;
            this.b38.Size = new System.Drawing.Size(36, 36);
            this.b38.TabIndex = 145;
            this.b38.Click += new System.EventHandler(this.button_Click);
            // 
            // b37
            // 
            this.b37.BorderColor = System.Drawing.Color.Gray;
            this.b37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b37.DisplayBorder = true;
            this.b37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b37.Location = new System.Drawing.Point(512, 232);
            this.b37.Name = "b37";
            this.b37.Radius = 15;
            this.b37.Size = new System.Drawing.Size(36, 36);
            this.b37.TabIndex = 144;
            this.b37.Click += new System.EventHandler(this.button_Click);
            // 
            // b36
            // 
            this.b36.BorderColor = System.Drawing.Color.Gray;
            this.b36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b36.DisplayBorder = true;
            this.b36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b36.Location = new System.Drawing.Point(442, 232);
            this.b36.Name = "b36";
            this.b36.Radius = 15;
            this.b36.Size = new System.Drawing.Size(36, 36);
            this.b36.TabIndex = 143;
            this.b36.Click += new System.EventHandler(this.button_Click);
            // 
            // b35
            // 
            this.b35.BorderColor = System.Drawing.Color.Gray;
            this.b35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b35.DisplayBorder = true;
            this.b35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b35.Location = new System.Drawing.Point(372, 232);
            this.b35.Name = "b35";
            this.b35.Radius = 15;
            this.b35.Size = new System.Drawing.Size(36, 36);
            this.b35.TabIndex = 142;
            this.b35.Click += new System.EventHandler(this.button_Click);
            // 
            // b34
            // 
            this.b34.BorderColor = System.Drawing.Color.Gray;
            this.b34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b34.DisplayBorder = true;
            this.b34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b34.Location = new System.Drawing.Point(302, 232);
            this.b34.Name = "b34";
            this.b34.Radius = 15;
            this.b34.Size = new System.Drawing.Size(36, 36);
            this.b34.TabIndex = 141;
            this.b34.Click += new System.EventHandler(this.button_Click);
            // 
            // b33
            // 
            this.b33.BorderColor = System.Drawing.Color.Gray;
            this.b33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b33.DisplayBorder = true;
            this.b33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b33.Location = new System.Drawing.Point(232, 232);
            this.b33.Name = "b33";
            this.b33.Radius = 15;
            this.b33.Size = new System.Drawing.Size(36, 36);
            this.b33.TabIndex = 140;
            this.b33.Click += new System.EventHandler(this.button_Click);
            // 
            // b32
            // 
            this.b32.BorderColor = System.Drawing.Color.Gray;
            this.b32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b32.DisplayBorder = true;
            this.b32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b32.Location = new System.Drawing.Point(162, 232);
            this.b32.Name = "b32";
            this.b32.Radius = 15;
            this.b32.Size = new System.Drawing.Size(36, 36);
            this.b32.TabIndex = 139;
            this.b32.Click += new System.EventHandler(this.button_Click);
            // 
            // b31
            // 
            this.b31.BorderColor = System.Drawing.Color.Gray;
            this.b31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b31.DisplayBorder = true;
            this.b31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b31.Location = new System.Drawing.Point(92, 232);
            this.b31.Name = "b31";
            this.b31.Radius = 15;
            this.b31.Size = new System.Drawing.Size(36, 36);
            this.b31.TabIndex = 138;
            this.b31.Click += new System.EventHandler(this.button_Click);
            // 
            // b30
            // 
            this.b30.BorderColor = System.Drawing.Color.Gray;
            this.b30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b30.DisplayBorder = true;
            this.b30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b30.Location = new System.Drawing.Point(22, 232);
            this.b30.Name = "b30";
            this.b30.Radius = 15;
            this.b30.Size = new System.Drawing.Size(36, 36);
            this.b30.TabIndex = 137;
            this.b30.Click += new System.EventHandler(this.button_Click);
            // 
            // b29
            // 
            this.b29.BorderColor = System.Drawing.Color.Gray;
            this.b29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b29.DisplayBorder = true;
            this.b29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b29.Location = new System.Drawing.Point(652, 162);
            this.b29.Name = "b29";
            this.b29.Radius = 15;
            this.b29.Size = new System.Drawing.Size(36, 36);
            this.b29.TabIndex = 136;
            this.b29.Click += new System.EventHandler(this.button_Click);
            // 
            // b28
            // 
            this.b28.BorderColor = System.Drawing.Color.Gray;
            this.b28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b28.DisplayBorder = true;
            this.b28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b28.Location = new System.Drawing.Point(582, 162);
            this.b28.Name = "b28";
            this.b28.Radius = 15;
            this.b28.Size = new System.Drawing.Size(36, 36);
            this.b28.TabIndex = 135;
            this.b28.Click += new System.EventHandler(this.button_Click);
            // 
            // b27
            // 
            this.b27.BorderColor = System.Drawing.Color.Gray;
            this.b27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b27.DisplayBorder = true;
            this.b27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b27.Location = new System.Drawing.Point(512, 162);
            this.b27.Name = "b27";
            this.b27.Radius = 15;
            this.b27.Size = new System.Drawing.Size(36, 36);
            this.b27.TabIndex = 134;
            this.b27.Click += new System.EventHandler(this.button_Click);
            // 
            // b26
            // 
            this.b26.BorderColor = System.Drawing.Color.Gray;
            this.b26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b26.DisplayBorder = true;
            this.b26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b26.Location = new System.Drawing.Point(442, 162);
            this.b26.Name = "b26";
            this.b26.Radius = 15;
            this.b26.Size = new System.Drawing.Size(36, 36);
            this.b26.TabIndex = 133;
            this.b26.Click += new System.EventHandler(this.button_Click);
            // 
            // b25
            // 
            this.b25.BorderColor = System.Drawing.Color.Gray;
            this.b25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b25.DisplayBorder = true;
            this.b25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b25.Location = new System.Drawing.Point(372, 162);
            this.b25.Name = "b25";
            this.b25.Radius = 15;
            this.b25.Size = new System.Drawing.Size(36, 36);
            this.b25.TabIndex = 132;
            this.b25.Click += new System.EventHandler(this.button_Click);
            // 
            // b24
            // 
            this.b24.BorderColor = System.Drawing.Color.Gray;
            this.b24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b24.DisplayBorder = true;
            this.b24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b24.Location = new System.Drawing.Point(302, 162);
            this.b24.Name = "b24";
            this.b24.Radius = 15;
            this.b24.Size = new System.Drawing.Size(36, 36);
            this.b24.TabIndex = 131;
            this.b24.Click += new System.EventHandler(this.button_Click);
            // 
            // b23
            // 
            this.b23.BorderColor = System.Drawing.Color.Gray;
            this.b23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b23.DisplayBorder = true;
            this.b23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b23.Location = new System.Drawing.Point(232, 162);
            this.b23.Name = "b23";
            this.b23.Radius = 15;
            this.b23.Size = new System.Drawing.Size(36, 36);
            this.b23.TabIndex = 130;
            this.b23.Click += new System.EventHandler(this.button_Click);
            // 
            // b22
            // 
            this.b22.BorderColor = System.Drawing.Color.Gray;
            this.b22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b22.DisplayBorder = true;
            this.b22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b22.Location = new System.Drawing.Point(162, 162);
            this.b22.Name = "b22";
            this.b22.Radius = 15;
            this.b22.Size = new System.Drawing.Size(36, 36);
            this.b22.TabIndex = 129;
            this.b22.Click += new System.EventHandler(this.button_Click);
            // 
            // b21
            // 
            this.b21.BorderColor = System.Drawing.Color.Gray;
            this.b21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b21.DisplayBorder = true;
            this.b21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b21.Location = new System.Drawing.Point(92, 162);
            this.b21.Name = "b21";
            this.b21.Radius = 15;
            this.b21.Size = new System.Drawing.Size(36, 36);
            this.b21.TabIndex = 128;
            this.b21.Click += new System.EventHandler(this.button_Click);
            // 
            // b19
            // 
            this.b19.BorderColor = System.Drawing.Color.Gray;
            this.b19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b19.DisplayBorder = true;
            this.b19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b19.Location = new System.Drawing.Point(652, 88);
            this.b19.Name = "b19";
            this.b19.Radius = 15;
            this.b19.Size = new System.Drawing.Size(36, 36);
            this.b19.TabIndex = 127;
            this.b19.Click += new System.EventHandler(this.button_Click);
            // 
            // b17
            // 
            this.b17.BorderColor = System.Drawing.Color.Gray;
            this.b17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b17.DisplayBorder = true;
            this.b17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b17.Location = new System.Drawing.Point(512, 88);
            this.b17.Name = "b17";
            this.b17.Radius = 15;
            this.b17.Size = new System.Drawing.Size(36, 36);
            this.b17.TabIndex = 126;
            this.b17.Click += new System.EventHandler(this.button_Click);
            // 
            // b18
            // 
            this.b18.BorderColor = System.Drawing.Color.Gray;
            this.b18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b18.DisplayBorder = true;
            this.b18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b18.Location = new System.Drawing.Point(582, 88);
            this.b18.Name = "b18";
            this.b18.Radius = 15;
            this.b18.Size = new System.Drawing.Size(36, 36);
            this.b18.TabIndex = 125;
            this.b18.Click += new System.EventHandler(this.button_Click);
            // 
            // b9
            // 
            this.b9.BorderColor = System.Drawing.Color.Gray;
            this.b9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b9.DisplayBorder = true;
            this.b9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b9.Location = new System.Drawing.Point(652, 22);
            this.b9.Name = "b9";
            this.b9.Radius = 15;
            this.b9.Size = new System.Drawing.Size(36, 36);
            this.b9.TabIndex = 124;
            this.b9.Click += new System.EventHandler(this.button_Click);
            // 
            // b8
            // 
            this.b8.BorderColor = System.Drawing.Color.Gray;
            this.b8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b8.DisplayBorder = true;
            this.b8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b8.Location = new System.Drawing.Point(582, 22);
            this.b8.Name = "b8";
            this.b8.Radius = 15;
            this.b8.Size = new System.Drawing.Size(36, 36);
            this.b8.TabIndex = 123;
            this.b8.Click += new System.EventHandler(this.button_Click);
            // 
            // b7
            // 
            this.b7.BorderColor = System.Drawing.Color.Gray;
            this.b7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b7.DisplayBorder = true;
            this.b7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b7.Location = new System.Drawing.Point(512, 22);
            this.b7.Name = "b7";
            this.b7.Radius = 15;
            this.b7.Size = new System.Drawing.Size(36, 36);
            this.b7.TabIndex = 122;
            this.b7.Click += new System.EventHandler(this.button_Click);
            // 
            // b6
            // 
            this.b6.BorderColor = System.Drawing.Color.Gray;
            this.b6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b6.DisplayBorder = true;
            this.b6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b6.Location = new System.Drawing.Point(442, 22);
            this.b6.Name = "b6";
            this.b6.Radius = 15;
            this.b6.Size = new System.Drawing.Size(36, 36);
            this.b6.TabIndex = 121;
            this.b6.Click += new System.EventHandler(this.button_Click);
            // 
            // b16
            // 
            this.b16.BorderColor = System.Drawing.Color.Gray;
            this.b16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b16.DisplayBorder = true;
            this.b16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b16.Location = new System.Drawing.Point(442, 92);
            this.b16.Name = "b16";
            this.b16.Radius = 15;
            this.b16.Size = new System.Drawing.Size(36, 36);
            this.b16.TabIndex = 120;
            this.b16.Click += new System.EventHandler(this.button_Click);
            // 
            // b15
            // 
            this.b15.BorderColor = System.Drawing.Color.Gray;
            this.b15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b15.DisplayBorder = true;
            this.b15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b15.Location = new System.Drawing.Point(372, 92);
            this.b15.Name = "b15";
            this.b15.Radius = 15;
            this.b15.Size = new System.Drawing.Size(36, 36);
            this.b15.TabIndex = 119;
            this.b15.Click += new System.EventHandler(this.button_Click);
            // 
            // b14
            // 
            this.b14.BorderColor = System.Drawing.Color.Gray;
            this.b14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b14.DisplayBorder = true;
            this.b14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b14.Location = new System.Drawing.Point(302, 88);
            this.b14.Name = "b14";
            this.b14.Radius = 15;
            this.b14.Size = new System.Drawing.Size(36, 36);
            this.b14.TabIndex = 118;
            this.b14.Click += new System.EventHandler(this.button_Click);
            // 
            // b13
            // 
            this.b13.BorderColor = System.Drawing.Color.Gray;
            this.b13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b13.DisplayBorder = true;
            this.b13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b13.Location = new System.Drawing.Point(232, 92);
            this.b13.Name = "b13";
            this.b13.Radius = 15;
            this.b13.Size = new System.Drawing.Size(36, 36);
            this.b13.TabIndex = 117;
            this.b13.Click += new System.EventHandler(this.button_Click);
            // 
            // b12
            // 
            this.b12.BorderColor = System.Drawing.Color.Gray;
            this.b12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b12.DisplayBorder = true;
            this.b12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b12.Location = new System.Drawing.Point(162, 92);
            this.b12.Name = "b12";
            this.b12.Radius = 15;
            this.b12.Size = new System.Drawing.Size(36, 36);
            this.b12.TabIndex = 116;
            this.b12.Click += new System.EventHandler(this.button_Click);
            // 
            // b11
            // 
            this.b11.BorderColor = System.Drawing.Color.Gray;
            this.b11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b11.DisplayBorder = true;
            this.b11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b11.Location = new System.Drawing.Point(92, 92);
            this.b11.Name = "b11";
            this.b11.Radius = 15;
            this.b11.Size = new System.Drawing.Size(36, 36);
            this.b11.TabIndex = 115;
            this.b11.Click += new System.EventHandler(this.button_Click);
            // 
            // b20
            // 
            this.b20.BorderColor = System.Drawing.Color.Gray;
            this.b20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b20.DisplayBorder = true;
            this.b20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b20.Location = new System.Drawing.Point(22, 162);
            this.b20.Name = "b20";
            this.b20.Radius = 15;
            this.b20.Size = new System.Drawing.Size(36, 36);
            this.b20.TabIndex = 114;
            this.b20.Click += new System.EventHandler(this.button_Click);
            // 
            // b10
            // 
            this.b10.BorderColor = System.Drawing.Color.Gray;
            this.b10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b10.DisplayBorder = true;
            this.b10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b10.Location = new System.Drawing.Point(22, 92);
            this.b10.Name = "b10";
            this.b10.Radius = 15;
            this.b10.Size = new System.Drawing.Size(36, 36);
            this.b10.TabIndex = 113;
            this.b10.Click += new System.EventHandler(this.button_Click);
            // 
            // b1
            // 
            this.b1.BorderColor = System.Drawing.Color.Gray;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.DisplayBorder = true;
            this.b1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b1.Location = new System.Drawing.Point(92, 22);
            this.b1.Name = "b1";
            this.b1.Radius = 15;
            this.b1.Size = new System.Drawing.Size(36, 36);
            this.b1.TabIndex = 107;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.BorderColor = System.Drawing.Color.Gray;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.DisplayBorder = true;
            this.b2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b2.Location = new System.Drawing.Point(162, 22);
            this.b2.Name = "b2";
            this.b2.Radius = 15;
            this.b2.Size = new System.Drawing.Size(36, 36);
            this.b2.TabIndex = 112;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.BorderColor = System.Drawing.Color.Gray;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.DisplayBorder = true;
            this.b3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b3.Location = new System.Drawing.Point(232, 22);
            this.b3.Name = "b3";
            this.b3.Radius = 15;
            this.b3.Size = new System.Drawing.Size(36, 36);
            this.b3.TabIndex = 111;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // b4
            // 
            this.b4.BorderColor = System.Drawing.Color.Gray;
            this.b4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b4.DisplayBorder = true;
            this.b4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b4.Location = new System.Drawing.Point(302, 22);
            this.b4.Name = "b4";
            this.b4.Radius = 15;
            this.b4.Size = new System.Drawing.Size(36, 36);
            this.b4.TabIndex = 110;
            this.b4.Click += new System.EventHandler(this.button_Click);
            // 
            // b5
            // 
            this.b5.BorderColor = System.Drawing.Color.Gray;
            this.b5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b5.DisplayBorder = true;
            this.b5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b5.Location = new System.Drawing.Point(372, 22);
            this.b5.Name = "b5";
            this.b5.Radius = 15;
            this.b5.Size = new System.Drawing.Size(36, 36);
            this.b5.TabIndex = 109;
            this.b5.Click += new System.EventHandler(this.button_Click);
            // 
            // ellipseButton3
            // 
            this.ellipseButton3.BorderColor = System.Drawing.Color.Gray;
            this.ellipseButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipseButton3.DisplayBorder = true;
            this.ellipseButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ellipseButton3.Location = new System.Drawing.Point(344, 343);
            this.ellipseButton3.Name = "ellipseButton3";
            this.ellipseButton3.Radius = 15;
            this.ellipseButton3.Size = new System.Drawing.Size(32, 34);
            this.ellipseButton3.TabIndex = 108;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(318, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 207;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(220)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b88);
            this.Controls.Add(this.b87);
            this.Controls.Add(this.b78);
            this.Controls.Add(this.b77);
            this.Controls.Add(this.b68);
            this.Controls.Add(this.b67);
            this.Controls.Add(this.b86);
            this.Controls.Add(this.b76);
            this.Controls.Add(this.b66);
            this.Controls.Add(this.b85);
            this.Controls.Add(this.b75);
            this.Controls.Add(this.b65);
            this.Controls.Add(this.b84);
            this.Controls.Add(this.b74);
            this.Controls.Add(this.b64);
            this.Controls.Add(this.b83);
            this.Controls.Add(this.b73);
            this.Controls.Add(this.b63);
            this.Controls.Add(this.b98);
            this.Controls.Add(this.b97);
            this.Controls.Add(this.b96);
            this.Controls.Add(this.b95);
            this.Controls.Add(this.b94);
            this.Controls.Add(this.b93);
            this.Controls.Add(this.b62);
            this.Controls.Add(this.b99);
            this.Controls.Add(this.b89);
            this.Controls.Add(this.b79);
            this.Controls.Add(this.b69);
            this.Controls.Add(this.b72);
            this.Controls.Add(this.b82);
            this.Controls.Add(this.b92);
            this.Controls.Add(this.b91);
            this.Controls.Add(this.b81);
            this.Controls.Add(this.b71);
            this.Controls.Add(this.b61);
            this.Controls.Add(this.b90);
            this.Controls.Add(this.b80);
            this.Controls.Add(this.b70);
            this.Controls.Add(this.b60);
            this.Controls.Add(this.b59);
            this.Controls.Add(this.b58);
            this.Controls.Add(this.b57);
            this.Controls.Add(this.b56);
            this.Controls.Add(this.b55);
            this.Controls.Add(this.b54);
            this.Controls.Add(this.b53);
            this.Controls.Add(this.b52);
            this.Controls.Add(this.b51);
            this.Controls.Add(this.b50);
            this.Controls.Add(this.b49);
            this.Controls.Add(this.b48);
            this.Controls.Add(this.b47);
            this.Controls.Add(this.b46);
            this.Controls.Add(this.b45);
            this.Controls.Add(this.b44);
            this.Controls.Add(this.b43);
            this.Controls.Add(this.b42);
            this.Controls.Add(this.b41);
            this.Controls.Add(this.b40);
            this.Controls.Add(this.b39);
            this.Controls.Add(this.b38);
            this.Controls.Add(this.b37);
            this.Controls.Add(this.b36);
            this.Controls.Add(this.b35);
            this.Controls.Add(this.b34);
            this.Controls.Add(this.b33);
            this.Controls.Add(this.b32);
            this.Controls.Add(this.b31);
            this.Controls.Add(this.b30);
            this.Controls.Add(this.b29);
            this.Controls.Add(this.b28);
            this.Controls.Add(this.b27);
            this.Controls.Add(this.b26);
            this.Controls.Add(this.b25);
            this.Controls.Add(this.b24);
            this.Controls.Add(this.b23);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b19);
            this.Controls.Add(this.b17);
            this.Controls.Add(this.b18);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b16);
            this.Controls.Add(this.b15);
            this.Controls.Add(this.b14);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b20);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.ellipseButton3);
            this.Name = "Form1";
            this.Text = "五目並べ";
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int boardSize = 720;
            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 1);
            for(int row = 40; row < boardSize-10; row += 70)
            {
                for(int column = 40; column < boardSize-10; column += 70)
                {
                    Point startPoint1 = new Point(row, column);
                    Point endPoint1 = new Point(boardSize-80, column);
                    Point startPoint2 = new Point(row, column);
                    Point endPoint2 = new Point(row, boardSize-80);
                    g.DrawLine(blackPen, startPoint1, endPoint1);
                    g.DrawLine(blackPen, startPoint2, endPoint2);
                }
            }
            this.Paint -= new PaintEventHandler(this.Form1_Paint);
            
        }

        Check check = new Check();

        private void button_Click(object sender, EventArgs e)
        {
            EllipseButton btn = (EllipseButton)sender;
            string name = ((EllipseButton)sender).Name.Substring(1);

            if (check.getTurn())
            {
                btn.BackgroundImage = global::FiveInRow.Properties.Resources.black;
                
                
            }
            else
            {
                btn.BackgroundImage = global::FiveInRow.Properties.Resources.white;
            }
            check.onChip(Int32.Parse(name), check.getTurn());
            btn.Click -= new System.EventHandler(button_Click);
            check.nextTurn();
            if(check.isFive())
            {
                if (!check.getTurn())
                    MessageBox.Show("黒の勝ちです");
                else
                    MessageBox.Show("白の勝ちです");
                this.Close();
            }
        }

    }
}
