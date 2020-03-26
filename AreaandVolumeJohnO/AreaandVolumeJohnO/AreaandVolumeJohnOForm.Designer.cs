namespace AreaandVolumeJohnO
{
    partial class AreaandVolumeJohnOForm
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
            this.lblTrapezoidAnswer = new System.Windows.Forms.Label();
            this.lblCylinderAnswer = new System.Windows.Forms.Label();
            this.lblSphereAnswer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHeightTrapeziod = new System.Windows.Forms.TextBox();
            this.btnCalculateTrapezoid = new System.Windows.Forms.Button();
            this.txtRadiusCylinder = new System.Windows.Forms.TextBox();
            this.txtHeightCylinder = new System.Windows.Forms.TextBox();
            this.txtBaseTrapeziod = new System.Windows.Forms.TextBox();
            this.txtWidthTrapeziod = new System.Windows.Forms.TextBox();
            this.txtRadiusSphere = new System.Windows.Forms.TextBox();
            this.btnCalculateSphere = new System.Windows.Forms.Button();
            this.btnCalculateCylinder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrapezoidAnswer
            // 
            this.lblTrapezoidAnswer.AutoSize = true;
            this.lblTrapezoidAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrapezoidAnswer.Location = new System.Drawing.Point(2, 20);
            this.lblTrapezoidAnswer.Name = "lblTrapezoidAnswer";
            this.lblTrapezoidAnswer.Size = new System.Drawing.Size(231, 12);
            this.lblTrapezoidAnswer.TabIndex = 0;
            this.lblTrapezoidAnswer.Text = "Enter the height, width and base of the trapezoid (in cm)";
            this.lblTrapezoidAnswer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCylinderAnswer
            // 
            this.lblCylinderAnswer.AutoSize = true;
            this.lblCylinderAnswer.Location = new System.Drawing.Point(1, 192);
            this.lblCylinderAnswer.Name = "lblCylinderAnswer";
            this.lblCylinderAnswer.Size = new System.Drawing.Size(237, 13);
            this.lblCylinderAnswer.TabIndex = 1;
            this.lblCylinderAnswer.Text = "Enter the height and radius of the cylinder (in cm)";
            this.lblCylinderAnswer.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSphereAnswer
            // 
            this.lblSphereAnswer.AutoSize = true;
            this.lblSphereAnswer.Location = new System.Drawing.Point(34, 348);
            this.lblSphereAnswer.Name = "lblSphereAnswer";
            this.lblSphereAnswer.Size = new System.Drawing.Size(180, 13);
            this.lblSphereAnswer.TabIndex = 2;
            this.lblSphereAnswer.Text = "Enter the radius of the sphere (in cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Base";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Radius";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Radius";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtHeightTrapeziod
            // 
            this.txtHeightTrapeziod.Location = new System.Drawing.Point(326, 20);
            this.txtHeightTrapeziod.Name = "txtHeightTrapeziod";
            this.txtHeightTrapeziod.Size = new System.Drawing.Size(100, 20);
            this.txtHeightTrapeziod.TabIndex = 9;
            this.txtHeightTrapeziod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCalculateTrapezoid
            // 
            this.btnCalculateTrapezoid.Location = new System.Drawing.Point(474, 21);
            this.btnCalculateTrapezoid.Name = "btnCalculateTrapezoid";
            this.btnCalculateTrapezoid.Size = new System.Drawing.Size(133, 92);
            this.btnCalculateTrapezoid.TabIndex = 10;
            this.btnCalculateTrapezoid.Text = "Calculate Trapezoid";
            this.btnCalculateTrapezoid.UseVisualStyleBackColor = true;
            this.btnCalculateTrapezoid.Click += new System.EventHandler(this.btnCalculateTrapezoid_Click);
            // 
            // txtRadiusCylinder
            // 
            this.txtRadiusCylinder.Location = new System.Drawing.Point(326, 228);
            this.txtRadiusCylinder.Name = "txtRadiusCylinder";
            this.txtRadiusCylinder.Size = new System.Drawing.Size(100, 20);
            this.txtRadiusCylinder.TabIndex = 11;
            // 
            // txtHeightCylinder
            // 
            this.txtHeightCylinder.Location = new System.Drawing.Point(326, 189);
            this.txtHeightCylinder.Name = "txtHeightCylinder";
            this.txtHeightCylinder.Size = new System.Drawing.Size(100, 20);
            this.txtHeightCylinder.TabIndex = 12;
            // 
            // txtBaseTrapeziod
            // 
            this.txtBaseTrapeziod.Location = new System.Drawing.Point(326, 84);
            this.txtBaseTrapeziod.Name = "txtBaseTrapeziod";
            this.txtBaseTrapeziod.Size = new System.Drawing.Size(100, 20);
            this.txtBaseTrapeziod.TabIndex = 13;
            // 
            // txtWidthTrapeziod
            // 
            this.txtWidthTrapeziod.Location = new System.Drawing.Point(326, 46);
            this.txtWidthTrapeziod.Name = "txtWidthTrapeziod";
            this.txtWidthTrapeziod.Size = new System.Drawing.Size(100, 20);
            this.txtWidthTrapeziod.TabIndex = 14;
            // 
            // txtRadiusSphere
            // 
            this.txtRadiusSphere.Location = new System.Drawing.Point(326, 356);
            this.txtRadiusSphere.Name = "txtRadiusSphere";
            this.txtRadiusSphere.Size = new System.Drawing.Size(100, 20);
            this.txtRadiusSphere.TabIndex = 15;
            // 
            // btnCalculateSphere
            // 
            this.btnCalculateSphere.Location = new System.Drawing.Point(474, 314);
            this.btnCalculateSphere.Name = "btnCalculateSphere";
            this.btnCalculateSphere.Size = new System.Drawing.Size(133, 81);
            this.btnCalculateSphere.TabIndex = 16;
            this.btnCalculateSphere.Text = "Calculate Sphere";
            this.btnCalculateSphere.UseVisualStyleBackColor = true;
            this.btnCalculateSphere.Click += new System.EventHandler(this.btnCalculateSphere_Click);
            // 
            // btnCalculateCylinder
            // 
            this.btnCalculateCylinder.Location = new System.Drawing.Point(474, 168);
            this.btnCalculateCylinder.Name = "btnCalculateCylinder";
            this.btnCalculateCylinder.Size = new System.Drawing.Size(133, 90);
            this.btnCalculateCylinder.TabIndex = 17;
            this.btnCalculateCylinder.Text = "Calculate Cylinder";
            this.btnCalculateCylinder.UseVisualStyleBackColor = true;
            this.btnCalculateCylinder.Click += new System.EventHandler(this.btnCalculateCylinder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AreaandVolumeJohnOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculateCylinder);
            this.Controls.Add(this.btnCalculateSphere);
            this.Controls.Add(this.txtRadiusSphere);
            this.Controls.Add(this.txtWidthTrapeziod);
            this.Controls.Add(this.txtBaseTrapeziod);
            this.Controls.Add(this.txtHeightCylinder);
            this.Controls.Add(this.txtRadiusCylinder);
            this.Controls.Add(this.btnCalculateTrapezoid);
            this.Controls.Add(this.txtHeightTrapeziod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSphereAnswer);
            this.Controls.Add(this.lblCylinderAnswer);
            this.Controls.Add(this.lblTrapezoidAnswer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AreaandVolumeJohnOForm";
            this.Text = "Area and Volume by JohnO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrapezoidAnswer;
        private System.Windows.Forms.Label lblCylinderAnswer;
        private System.Windows.Forms.Label lblSphereAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHeightTrapeziod;
        private System.Windows.Forms.Button btnCalculateTrapezoid;
        private System.Windows.Forms.TextBox txtRadiusCylinder;
        private System.Windows.Forms.TextBox txtHeightCylinder;
        private System.Windows.Forms.TextBox txtBaseTrapeziod;
        private System.Windows.Forms.TextBox txtWidthTrapeziod;
        private System.Windows.Forms.TextBox txtRadiusSphere;
        private System.Windows.Forms.Button btnCalculateSphere;
        private System.Windows.Forms.Button btnCalculateCylinder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

