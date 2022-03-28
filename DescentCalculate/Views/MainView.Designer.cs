namespace DescentCalculate.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.txtDescndFrom = new Krypton.Toolkit.KryptonTextBox();
            this.txtDescndTo = new Krypton.Toolkit.KryptonTextBox();
            this.txtSpeed = new Krypton.Toolkit.KryptonTextBox();
            this.lbltitle = new Krypton.Toolkit.KryptonLabel();
            this.lblMainText = new Krypton.Toolkit.KryptonLabel();
            this.lblDescendFrom = new Krypton.Toolkit.KryptonLabel();
            this.lblDescndTo = new Krypton.Toolkit.KryptonLabel();
            this.lblSpeed = new Krypton.Toolkit.KryptonLabel();
            this.lblPitch = new Krypton.Toolkit.KryptonLabel();
            this.txtPitchAngle = new Krypton.Toolkit.KryptonTextBox();
            this.lblDistance = new Krypton.Toolkit.KryptonLabel();
            this.txtTravle = new Krypton.Toolkit.KryptonTextBox();
            this.butCalDescendOnly = new Krypton.Toolkit.KryptonButton();
            this.lblDescendOnlyResult = new Krypton.Toolkit.KryptonLabel();
            this.bntDescentAngle = new Krypton.Toolkit.KryptonButton();
            this.labAltitudeFrom = new Krypton.Toolkit.KryptonLabel();
            this.labAltitudeTo = new Krypton.Toolkit.KryptonLabel();
            this.labDescendSpeed = new Krypton.Toolkit.KryptonLabel();
            this.labDegree = new Krypton.Toolkit.KryptonLabel();
            this.labDescendIn = new Krypton.Toolkit.KryptonLabel();
            this.rbCalcDescendRate = new Krypton.Toolkit.KryptonRadioButton();
            this.rbCalcDescendOnly = new Krypton.Toolkit.KryptonRadioButton();
            this.SuspendLayout();
            // 
            // txtDescndFrom
            // 
            this.txtDescndFrom.AcceptsTab = true;
            this.txtDescndFrom.Location = new System.Drawing.Point(389, 133);
            this.txtDescndFrom.Name = "txtDescndFrom";
            this.txtDescndFrom.Size = new System.Drawing.Size(118, 23);
            this.txtDescndFrom.TabIndex = 3;
            this.txtDescndFrom.Text = "0000";
            this.txtDescndFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescndFrom.ToolTipValues.Description = "";
            this.txtDescndFrom.ToolTipValues.EnableToolTips = true;
            this.txtDescndFrom.ToolTipValues.Heading = "Enter Value in Feet";
            this.txtDescndFrom.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Right;
            this.txtDescndFrom.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.txtDescndFrom.WordWrap = false;
            this.txtDescndFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescndFrom_KeyPress);
            // 
            // txtDescndTo
            // 
            this.txtDescndTo.AcceptsTab = true;
            this.txtDescndTo.Location = new System.Drawing.Point(389, 169);
            this.txtDescndTo.Name = "txtDescndTo";
            this.txtDescndTo.Size = new System.Drawing.Size(118, 23);
            this.txtDescndTo.TabIndex = 4;
            this.txtDescndTo.Text = "0000";
            this.txtDescndTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescndTo.ToolTipValues.Description = "";
            this.txtDescndTo.ToolTipValues.EnableToolTips = true;
            this.txtDescndTo.ToolTipValues.Heading = "Enter in Feet\r\n";
            this.txtDescndTo.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Right;
            this.txtDescndTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescndTo_KeyPress);
            // 
            // txtSpeed
            // 
            this.txtSpeed.AcceptsTab = true;
            this.txtSpeed.Location = new System.Drawing.Point(389, 201);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(118, 23);
            this.txtSpeed.TabIndex = 5;
            this.txtSpeed.Text = "0000";
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpeed.ToolTipValues.Description = "";
            this.txtSpeed.ToolTipValues.EnableToolTips = true;
            this.txtSpeed.ToolTipValues.Heading = "Enter Descend Speed NM";
            this.txtSpeed.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Right;
            this.txtSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpeed_KeyPress);
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(12, 26);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(372, 36);
            this.lbltitle.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.lbltitle.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.lbltitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbltitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbltitle.TabIndex = 6;
            this.lbltitle.Values.Text = "1 In 60 Rule Saves The Day";
            // 
            // lblMainText
            // 
            this.lblMainText.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.lblMainText.Location = new System.Drawing.Point(22, 62);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(671, 41);
            this.lblMainText.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblMainText.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainText.TabIndex = 7;
            this.lblMainText.Values.Text = "You can take the guesswork out of your descent with a rule-of-thumb: \r\nthe \"1 In " +
    "60\" rule. The rule states that 1 degree of climb or descent closely equals 100\'/" +
    "NM.";
            // 
            // lblDescendFrom
            // 
            this.lblDescendFrom.Location = new System.Drawing.Point(212, 136);
            this.lblDescendFrom.Name = "lblDescendFrom";
            this.lblDescendFrom.Size = new System.Drawing.Size(98, 19);
            this.lblDescendFrom.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescendFrom.TabIndex = 8;
            this.lblDescendFrom.Values.Text = "Descend From";
            // 
            // lblDescndTo
            // 
            this.lblDescndTo.Location = new System.Drawing.Point(212, 169);
            this.lblDescndTo.Name = "lblDescndTo";
            this.lblDescndTo.Size = new System.Drawing.Size(83, 19);
            this.lblDescndTo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescndTo.TabIndex = 9;
            this.lblDescndTo.Values.Text = "Descend To";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Location = new System.Drawing.Point(212, 201);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(70, 19);
            this.lblSpeed.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Values.Text = "Air Speed";
            // 
            // lblPitch
            // 
            this.lblPitch.Location = new System.Drawing.Point(212, 238);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(79, 19);
            this.lblPitch.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPitch.TabIndex = 11;
            this.lblPitch.Values.Text = "Pitch Angle";
            // 
            // txtPitchAngle
            // 
            this.txtPitchAngle.AcceptsTab = true;
            this.txtPitchAngle.Location = new System.Drawing.Point(389, 238);
            this.txtPitchAngle.Name = "txtPitchAngle";
            this.txtPitchAngle.Size = new System.Drawing.Size(118, 23);
            this.txtPitchAngle.TabIndex = 12;
            this.txtPitchAngle.Text = "0";
            this.txtPitchAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPitchAngle.ToolTipValues.Description = "";
            this.txtPitchAngle.ToolTipValues.EnableToolTips = true;
            this.txtPitchAngle.ToolTipValues.Heading = "Enter Pitch Angle";
            this.txtPitchAngle.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Right;
            this.txtPitchAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPitchAngle_KeyPress);
            // 
            // lblDistance
            // 
            this.lblDistance.Location = new System.Drawing.Point(212, 280);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(149, 19);
            this.lblDistance.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistance.TabIndex = 13;
            this.lblDistance.Values.Text = "Distance to Descend In";
            // 
            // txtTravle
            // 
            this.txtTravle.AcceptsTab = true;
            this.txtTravle.Location = new System.Drawing.Point(389, 280);
            this.txtTravle.Name = "txtTravle";
            this.txtTravle.Size = new System.Drawing.Size(118, 23);
            this.txtTravle.TabIndex = 14;
            this.txtTravle.Text = "0";
            this.txtTravle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTravle.ToolTipValues.Description = "";
            this.txtTravle.ToolTipValues.EnableToolTips = true;
            this.txtTravle.ToolTipValues.Heading = "Enter Distance Travle In MN";
            this.txtTravle.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Right;
            this.txtTravle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTravle_KeyPress);
            // 
            // butCalDescendOnly
            // 
            this.butCalDescendOnly.Location = new System.Drawing.Point(69, 332);
            this.butCalDescendOnly.Name = "butCalDescendOnly";
            this.butCalDescendOnly.Size = new System.Drawing.Size(150, 25);
            this.butCalDescendOnly.TabIndex = 15;
            this.butCalDescendOnly.Values.Text = "Calculate Descend Only";
            this.butCalDescendOnly.Click += new System.EventHandler(this.butCalDescendOnly_Click);
            // 
            // lblDescendOnlyResult
            // 
            this.lblDescendOnlyResult.AutoSize = false;
            this.lblDescendOnlyResult.Location = new System.Drawing.Point(55, 381);
            this.lblDescendOnlyResult.Name = "lblDescendOnlyResult";
            this.lblDescendOnlyResult.Size = new System.Drawing.Size(638, 32);
            this.lblDescendOnlyResult.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDescendOnlyResult.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescendOnlyResult.TabIndex = 16;
            this.lblDescendOnlyResult.Values.Text = "You need to descend {100} feet per nautical mile.";
            // 
            // bntDescentAngle
            // 
            this.bntDescentAngle.Location = new System.Drawing.Point(290, 332);
            this.bntDescentAngle.Name = "bntDescentAngle";
            this.bntDescentAngle.Size = new System.Drawing.Size(222, 25);
            this.bntDescentAngle.TabIndex = 17;
            this.bntDescentAngle.Values.Text = "Calculate Descend Rate (Angle/Speed)\r\n";
            this.bntDescentAngle.Click += new System.EventHandler(this.bntDescentAngle_Click);
            // 
            // labAltitudeFrom
            // 
            this.labAltitudeFrom.Location = new System.Drawing.Point(521, 136);
            this.labAltitudeFrom.Name = "labAltitudeFrom";
            this.labAltitudeFrom.Size = new System.Drawing.Size(38, 19);
            this.labAltitudeFrom.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAltitudeFrom.TabIndex = 19;
            this.labAltitudeFrom.Values.Text = "Feet";
            // 
            // labAltitudeTo
            // 
            this.labAltitudeTo.Location = new System.Drawing.Point(521, 172);
            this.labAltitudeTo.Name = "labAltitudeTo";
            this.labAltitudeTo.Size = new System.Drawing.Size(38, 19);
            this.labAltitudeTo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAltitudeTo.TabIndex = 20;
            this.labAltitudeTo.Values.Text = "Feet";
            // 
            // labDescendSpeed
            // 
            this.labDescendSpeed.Location = new System.Drawing.Point(521, 204);
            this.labDescendSpeed.Name = "labDescendSpeed";
            this.labDescendSpeed.Size = new System.Drawing.Size(45, 19);
            this.labDescendSpeed.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDescendSpeed.TabIndex = 21;
            this.labDescendSpeed.Values.Text = "Knots";
            // 
            // labDegree
            // 
            this.labDegree.Location = new System.Drawing.Point(521, 240);
            this.labDegree.Name = "labDegree";
            this.labDegree.Size = new System.Drawing.Size(55, 19);
            this.labDegree.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDegree.TabIndex = 22;
            this.labDegree.Values.Text = "Degree";
            // 
            // labDescendIn
            // 
            this.labDescendIn.Location = new System.Drawing.Point(521, 282);
            this.labDescendIn.Name = "labDescendIn";
            this.labDescendIn.Size = new System.Drawing.Size(32, 19);
            this.labDescendIn.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDescendIn.TabIndex = 23;
            this.labDescendIn.Values.Text = "NM";
            // 
            // rbCalcDescendRate
            // 
            this.rbCalcDescendRate.CheckPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.rbCalcDescendRate.Location = new System.Drawing.Point(259, 339);
            this.rbCalcDescendRate.Name = "rbCalcDescendRate";
            this.rbCalcDescendRate.Size = new System.Drawing.Size(18, 12);
            this.rbCalcDescendRate.TabIndex = 26;
            this.rbCalcDescendRate.Values.Text = "";
            this.rbCalcDescendRate.Click += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbCalcDescendOnly
            // 
            this.rbCalcDescendOnly.CheckPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.rbCalcDescendOnly.Location = new System.Drawing.Point(39, 338);
            this.rbCalcDescendOnly.Name = "rbCalcDescendOnly";
            this.rbCalcDescendOnly.Size = new System.Drawing.Size(18, 12);
            this.rbCalcDescendOnly.TabIndex = 25;
            this.rbCalcDescendOnly.Values.Text = "";
            this.rbCalcDescendOnly.Click += new System.EventHandler(this.rbCheckedChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 522);
            this.Controls.Add(this.rbCalcDescendOnly);
            this.Controls.Add(this.rbCalcDescendRate);
            this.Controls.Add(this.labDescendIn);
            this.Controls.Add(this.labDegree);
            this.Controls.Add(this.labDescendSpeed);
            this.Controls.Add(this.labAltitudeTo);
            this.Controls.Add(this.labAltitudeFrom);
            this.Controls.Add(this.bntDescentAngle);
            this.Controls.Add(this.lblDescendOnlyResult);
            this.Controls.Add(this.butCalDescendOnly);
            this.Controls.Add(this.txtTravle);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtPitchAngle);
            this.Controls.Add(this.lblPitch);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblDescndTo);
            this.Controls.Add(this.lblDescendFrom);
            this.Controls.Add(this.lblMainText);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtDescndTo);
            this.Controls.Add(this.txtDescndFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descent Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtDescndFrom;
        private Krypton.Toolkit.KryptonTextBox txtDescndTo;
        private Krypton.Toolkit.KryptonTextBox txtSpeed;
        private Krypton.Toolkit.KryptonLabel lbltitle;
        private Krypton.Toolkit.KryptonLabel lblMainText;
        private Krypton.Toolkit.KryptonLabel lblDescendFrom;
        private Krypton.Toolkit.KryptonLabel lblDescndTo;
        private Krypton.Toolkit.KryptonLabel lblSpeed;
        private Krypton.Toolkit.KryptonLabel lblPitch;
        private Krypton.Toolkit.KryptonTextBox txtPitchAngle;
        private Krypton.Toolkit.KryptonLabel lblDistance;
        private Krypton.Toolkit.KryptonTextBox txtTravle;
        private Krypton.Toolkit.KryptonButton butCalDescendOnly;
        private Krypton.Toolkit.KryptonLabel lblDescendOnlyResult;
        private Krypton.Toolkit.KryptonButton bntDescentAngle;
        private Krypton.Toolkit.KryptonLabel labAltitudeFrom;
        private Krypton.Toolkit.KryptonLabel labAltitudeTo;
        private Krypton.Toolkit.KryptonLabel labDescendSpeed;
        private Krypton.Toolkit.KryptonLabel labDegree;
        private Krypton.Toolkit.KryptonLabel labDescendIn;
        private Krypton.Toolkit.KryptonRadioButton rbCalcDescendRate;
        private Krypton.Toolkit.KryptonRadioButton rbCalcDescendOnly;
    }
}