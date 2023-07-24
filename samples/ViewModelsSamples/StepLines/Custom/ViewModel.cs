﻿using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace ViewModelsSamples.StepLines.Custom;

public partial class ViewModel : ObservableObject
{
    public ViewModel()
    {
        Series = new ISeries[]
        {
            new StepLineSeries<double>
            {
                Values = new double[] { 3, 1, 4, 3, 2, -5, -2 },
                GeometrySize = 10,
                Fill = null
            },

            // use the second argument type to specify the geometry to draw for every point
            // there are already many predefined geometries in the
            // LiveChartsCore.SkiaSharpView.Drawing.Geometries namespace
            new StepLineSeries<double, RectangleGeometry>
            {
                Values = new double[] { 3, 3, -3, -2, -4, -3, -1 },
                Fill = null
            },

            new StepLineSeries<double, SVGPathGeometry>
            {
                Values = new double[] { -2, 2, 1, 3, -1, 4, 3 },

                Stroke = new SolidColorPaint(SKColors.DarkOliveGreen, 3),
                Fill = null,
                GeometryStroke = new SolidColorPaint(SKColors.DarkOliveGreen, 3),
                GeometryFill = new SolidColorPaint(SKColors.White),
                GeometrySize = 35
            }
        };
    }

    public ISeries[] Series { get; set; }
}
