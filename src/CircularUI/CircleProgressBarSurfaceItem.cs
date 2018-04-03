﻿using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CircularUI
{
    /// <summary>
    /// The CircleProgressBarSurfaceItem displays circular progressbar at CirclePage.
    /// </summary>
    /// <since_tizen> 4 </since_tizen>
    public class CircleProgressBarSurfaceItem : CircleSurfaceItem
    {
        /// <summary>
        /// BindableProperty. Identifies the Value bindable property.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(double), typeof(CircleProgressBarSurfaceItem), 0.0 , coerceValue:CoerceValue);

        /// <summary>
        /// Gets or sets the value of the progressbar.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public double Value { get => (double)GetValue(ValueProperty); set => SetValue(ValueProperty, value); }

        internal static object CoerceValue(BindableObject bindable, object value)
        {
            return ((double)value).Clamp(0.0, 1.0);
        }
    }
}