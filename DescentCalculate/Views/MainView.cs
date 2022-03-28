// ***********************************************************************
// Assembly         : DescentCalculate
// Author           : Claude
// Created          : 03-17-2022
//
// Last Modified By : Claude
// Last Modified On : 03-18-2022
// ***********************************************************************
// <copyright file="MainView.cs" company="Mesquite Information Technologies LLC">
//     2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DescentCalculate.Common;
using Krypton.Toolkit;
using DescentCalculate.Views.Interface;
using DescentCalculate.Presenters;

namespace DescentCalculate.Views
{
    public partial class MainView : Form, IMainView
    {
        #region IMainView properties

        public string DescntFrom
        {
            get 
            {
                return txtDescndFrom.Text;
            }

            set
            {
                txtDescndFrom.Text = value;
            }
        }

        public string DescntTo
        {
            get
            {
                return txtDescndTo.Text;
            }

            set
            {
                txtDescndTo.Text = value;
            }

        }

        public string DescntSpeed
        {
            get
            {
                return txtSpeed.Text;
            }

            set
            {
                txtSpeed.Text = value;
            }
        }

        public string PitchAngle
        {
            get
            {
                return txtPitchAngle.Text;
            }

            set
            {
                txtPitchAngle.Text = value;
            }
        }

        public string DistanceTravled
        {
            get
            {
                return txtTravle.Text;
            }

            set
            {
                txtDescndTo.Text = value;
            }
        }

        public string CalculateDescendOnlyResult
        {
            get
            {
                return lblDescendOnlyResult.Text;
            }

            set
            {
                lblDescendOnlyResult.Text = value;
            }
        }

       

        #endregion


        public MainView()
        {
            InitializeComponent();
            txtDescndFrom.Text = "0000";
            txtDescndFrom.Font = new Font("Microsoft Sans Serif", 9f);
            txtDescndFrom.MaxLength = 6;
            

            txtDescndTo.Text = "0000";
            txtDescndTo.Font = new Font("Microsoft Sans Serif", 9f);
            txtDescndTo.MaxLength = 6;

            txtSpeed.Text = "000";
            txtSpeed.Font = new Font("Microsoft Sans Serif", 9f);
            txtSpeed.MaxLength = 3;
            txtSpeed.Enabled = false;

            txtPitchAngle.Text = "1";
            txtPitchAngle.Font = new Font("Microsoft Sans Serif", 9f);
            txtPitchAngle.MaxLength = 3;
            txtPitchAngle.Enabled = false;

            txtTravle.Text = "000";
            txtTravle.Font = new Font("Microsoft Sans Serif", 9f);
            txtTravle.MaxLength = 6;

            lblDescendOnlyResult.Text = "";
            rbCalcDescendOnly.Checked = true;

            bntDescentAngle.Enabled = false;
            butCalDescendOnly.Enabled = true;

        }

        #region Key Press events

        /*
         * Ensure we only allow digit to be enter in the text boxs
         */
        private void txtDescndFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = SetDigit.SetTextBoxCharSet(e);
        }

        private void txtDescndTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = SetDigit.SetTextBoxCharSet(e);
        }

        private void txtSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = SetDigit.SetTextBoxCharSet(e);
        }

        private void txtPitchAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = SetDigit.SetTextBoxCharSet(e);
        }

        private void txtTravle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = SetDigit.SetTextBoxCharSet(e);
        }

        private void butCalDescendOnly_Click(object sender, EventArgs e)
        {
            MainViewPresenter mainViewPresenter = new MainViewPresenter(this);

            mainViewPresenter.CalculateDescendOnly();
        }


        #endregion

        /// <summary>
        ///   <para>
        /// Rbs the checked changed.
        /// </para>
        ///   <para>Enable or disable tex boxs based on what radio button is selected</para>
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            if (rbCalcDescendOnly.Checked)
            {
                #region comment out not used

                //foreach (Control control in this.Controls)
                //{
                //    if (control.GetType() == typeof(TextBox))
                //    {
                //        if (control.Name == "txtDescndFrom")
                //        {
                //            control.Enabled = true;
                //        }

                //        if (control.Name == "txtDescndTo")
                //        {
                //            control.Enabled = true;
                //        }

                //        if (control.Name == "txtSpeed")
                //        {
                //            control.Enabled = false;
                //        }

                //        if (control.Name == "txtPitchAngle")
                //        {
                //            control.Enabled = false;
                //        }
                //    }
                //}

                #endregion

                txtDescndFrom.Enabled = true;
                txtDescndTo.Enabled = true;
                txtPitchAngle.Enabled = false;
                txtSpeed.Enabled = false;
                txtTravle.Enabled = true;

                txtDescndFrom.Focus();
                txtDescndFrom.SelectAll();

                bntDescentAngle.Enabled = false;
                butCalDescendOnly.Enabled = true;

            }
            else
            {
                txtDescndFrom.Enabled = false;
                txtDescndTo.Enabled = false;
                txtPitchAngle.Enabled = true;
                txtSpeed.Enabled = true;
                txtTravle.Enabled = false;

                txtSpeed.Focus();
                txtSpeed.SelectAll();

                bntDescentAngle.Enabled = true;
                butCalDescendOnly.Enabled = false;
            }

            
            
        }

        private void bntDescentAngle_Click(object sender, EventArgs e)
        {
            MainViewPresenter mainViewPresenter = new MainViewPresenter(this);
            mainViewPresenter.CalculateDescendAngle();
        }
    }
}
