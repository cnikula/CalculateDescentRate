// ***********************************************************************
// Assembly         : DescentCalculate
// Author           : Claude
// Created          : 03-18-2022
//
// Last Modified By : Claude
// Last Modified On : 03-18-2022
// ***********************************************************************
// <copyright file="IMainView.cs" company="Mesquite Information Technologies LLC">
//     2022
// </copyright>
// <summary>Interface between Main view and Presenter </summary>
// ***********************************************************************
namespace DescentCalculate.Views.Interface;

/// <summary>Interface IMainView</summary>
public interface IMainView
{
    public string DescntFrom { get; set; }
    public string DescntTo { get; set; }
    public string DescntSpeed { get; set; }
    public string PitchAngle { get; set; }
    public string DistanceTravled { get; set; }
    public string CalculateDescendOnlyResult { get; set; }

}