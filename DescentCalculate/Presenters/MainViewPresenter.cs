// ***********************************************************************
// Assembly         : DescentCalculate
// Author           : Claude
// Created          : 03-18-2022
//
// Last Modified By : Claude
// Last Modified On : 03-24-2022
// ***********************************************************************
// <copyright file="MainViewPresenter.cs" company="Mesquite Information Technologies LLC">
//     2022
// </copyright>
// <summary></summary>
// ***********************************************************************

using DescentCalculate.Views.Interface;
using DescentCalculate.Models;
using DescentCalculate.Common;

namespace DescentCalculate.Presenters
{
    public class MainViewPresenter
    {
        private IMainView _mainView;
        private bool calculate = true;
        private double result = 0;

        public MainViewPresenter(IMainView view)
        {
            _mainView = view;
        }

        /// <summary>
        ///   <para>
        /// Calculates the descend only.
        /// </para>
        ///   <para>Calculates how quickly you need to descend by feet</para>
        /// </summary>
        public void CalculateDescendOnly()
        {
            try
            {
                DescneInfoModle descneInfoModle = new DescneInfoModle();


                if (RegularExpression.CheckDecimal(_mainView.DescntFrom))
                {
                    descneInfoModle.DescntFrom = double.Parse(_mainView.DescntFrom);
                }
                else
                {

                    calculate = false;
                }

                if (RegularExpression.CheckDecimal(_mainView.DescntTo))
                {
                    descneInfoModle.DescntTo = double.Parse(_mainView.DescntTo);
                }
                else
                {
                    calculate = false;
                }

                if (RegularExpression.CheckDecimal(_mainView.DistanceTravled))
                {
                    descneInfoModle.DistanceTravled = double.Parse(_mainView.DistanceTravled);
                }
                else
                {
                    calculate = false;
                }

                if (calculate)
                {
                    if (descneInfoModle.DescntFrom == 0 || descneInfoModle.DescntTo == 0 ||
                        descneInfoModle.DistanceTravled == 0)
                    {
                        MessageBox.Show(
                            "No Calculation was performed due to all/or some required Inputs equal Zero (0)",
                            "INPUT WARNING!");
                    }
                    else
                    {
                        result = (descneInfoModle.DescntFrom - descneInfoModle.DescntTo) /
                                 descneInfoModle.DistanceTravled;
                        _mainView.CalculateDescendOnlyResult =
                            $"You need to descend {Math.Round(result).ToString()} feet per nautical mile.";
                    }

                }
                else
                {
                    MessageBox.Show("On or more inputs have invalid input. Your inputs can only except numeric values.",
                        "INPUT WARNING!");
                    _mainView.CalculateDescendOnlyResult = "ERROR: Re-Check your Inputs.";
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "ERROR");
            }



        }

        /// <summary>Calculates the descend rate.</summary>
        public void CalculateDescendRate()
        {
            try
            {
                DescneInfoModle descneInfoModle = new DescneInfoModle();

                if (RegularExpression.CheckDecimal(_mainView.PitchAngle))
                {
                    descneInfoModle.PitchAngle = double.Parse(_mainView.PitchAngle);
                }
                else
                {

                    calculate = false;
                }

                if (RegularExpression.CheckDecimal(_mainView.DescntSpeed))
                {
                    descneInfoModle.DescntSpeed = double.Parse(_mainView.DescntSpeed);
                }
                else
                {
                    calculate = false;
                }

                // perform calculations
                if (calculate)
                {
                    if (descneInfoModle.PitchAngle == 0 || descneInfoModle.DescntSpeed == 0)
                    {
                        MessageBox.Show(
                            "No Calculation was performed due to all/or some required Inputs equal Zero (0)",
                            "INPUT WARNING!");
                    }
                    else
                    {
                        descneInfoModle.DistanceTravled = descneInfoModle.DescntSpeed / 60;

                        result = descneInfoModle.PitchAngle * descneInfoModle.DistanceTravled * 100;
                        _mainView.CalculateDescendOnlyResult =
                            $" At {descneInfoModle.DescntSpeed.ToString()} NM, you will to descend {Math.Round(result).ToString()} feet per nautical mile.";
                    }

                }
                else
                {
                    MessageBox.Show("On or more inputs have invalid input. Your inputs can only except numeric values.",
                        "INPUT WARNING!");
                    _mainView.CalculateDescendOnlyResult = "ERROR: Re-Check your Inputs.";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR");

            }
        }

        public void CalculateDescentAngle()
        {
            try
            {
                DescneInfoModle descneInfoModle = new DescneInfoModle();

                if (RegularExpression.CheckDecimal(_mainView.DescntFrom))
                {
                    descneInfoModle.DescntFrom = double.Parse(_mainView.DescntFrom);
                }
                else
                {

                    calculate = false;
                }

                if (RegularExpression.CheckDecimal(_mainView.DescntTo))
                {
                    descneInfoModle.DescntTo = double.Parse(_mainView.DescntTo);
                }
                else
                {
                    calculate = false;
                }

                if (RegularExpression.CheckDecimal(_mainView.DistanceTravled))
                {
                    descneInfoModle.DistanceTravled = double.Parse(_mainView.DistanceTravled);
                }
                else
                {
                    calculate = false;
                }

                // perform calculations
                if (calculate)
                {
                    if (descneInfoModle.DescntFrom == 0 || descneInfoModle.DescntTo == 0 || descneInfoModle.DistanceTravled == 0)
                    {
                        MessageBox.Show(
                            "No Calculation was performed due to all/or some required Inputs equal Zero (0)",
                            "INPUT WARNING!");
                    }
                    else
                    {
                        // you'll need to descend at {FPNM} feet per nautical mile
                        double FPNM = 0;
                        FPNM = (descneInfoModle.DescntFrom - descneInfoModle.DescntTo) / descneInfoModle.DistanceTravled;
                        descneInfoModle.PitchAngle = FPNM / 100;

                        _mainView.CalculateDescendOnlyResult = $"You will need to pitch down {Math.Round(descneInfoModle.PitchAngle,2).ToString()} " +
                            $"degrees at {Math.Round(FPNM).ToString()} FPNM to accomplish the descent";
                    }
                    


                }
                else
                {
                    MessageBox.Show("On or more inputs have invalid input. Your inputs can only except numeric values.",
                        "INPUT WARNING!");
                    _mainView.CalculateDescendOnlyResult = "ERROR: Re-Check your Inputs.";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR");
            }
        }
    }
}
