﻿using Larkator.Common;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LarkatorGUI
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool asBool) return asBool ? Visibility.Visible : Visibility.Collapsed;
            if (value is int asInt) return asInt != 0 ? Visibility.Visible : Visibility.Collapsed;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PositionToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var pos = (Position)value;
            return (pos == null) ? "<null>" : pos.ToString(PositionFormat.LatLong);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StatsToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stats = (StatPoints)value;
            return (stats == null) ? "" : stats.ToString(true);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PositionToXConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var pos = (Position)value;
            return pos.Lon * 14.175 + 18.25;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PositionToYConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var pos = (Position)value;
            return pos.Lat * 13.7875 + 34.125;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class GenderToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? gender = (bool?)value;
            if (!gender.HasValue) return "imgs/nogender.png";
            if (gender.Value)
                return "imgs/female.png";
            else
                return "imgs/male.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class GenderToLetterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? gender = (bool?)value;
            if (!gender.HasValue) return "";
            if (gender.Value)
                return "F";
            else
                return "M";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class SearchResultToTooltipConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (SearchResult)value;
            return $"{v.Species} {(v.Female ? 'F' : 'M')}{v.Level} @ {v.Location.ToString(PositionFormat.LatLong)}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DinoToTooltipConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (Dino)value;
            String displayStats = "";
            //Build the string to display only shown stats
            //Health, Stamina, Oxygen, Food, Weight, Melee, Speed
            if (Properties.Settings.Default.ShowHealth)
            {
                displayStats += v.WildLevels.Health;
            }
            if (Properties.Settings.Default.ShowStam)
            {
                if (!displayStats.Equals(""))
                {
                    displayStats += "/";
                }
                displayStats += v.WildLevels.Stamina;
            }
            if (Properties.Settings.Default.ShowOxygen)
            {
                if (!displayStats.Equals(""))
                {
                    displayStats += "/";
                }
                displayStats += v.WildLevels.Oxygen;
            }
            if (Properties.Settings.Default.ShowFood)
            {
                if (!displayStats.Equals(""))
                {
                    displayStats += "/";
                }
                displayStats += v.WildLevels.Food;
            }
            if (Properties.Settings.Default.ShowWeight)
            {
                if (!displayStats.Equals(""))
                {
                    displayStats += "/";
                }
                displayStats += v.WildLevels.Weight;
            }
            if (Properties.Settings.Default.ShowMelee)
            {
                if (!displayStats.Equals(""))
                {
                    displayStats += "/";
                }
                displayStats += v.WildLevels.Melee;
            }
            if (Properties.Settings.Default.ShowSpeed)
            {
                if (!displayStats.Equals(""))
                {
                    displayStats += "/";
                }
                displayStats += v.WildLevels.Speed;
            }
            return $"{(String.IsNullOrWhiteSpace(v.Name) ? "" : "\"" + v.Name + "\" ")}{v.Type} {(v.Female ? 'F' : 'M')}{v.BaseLevel} @ {v.Location.ToString(PositionFormat.LatLong)} ({v.Location.ToString(PositionFormat.XYZ)}) ({displayStats})";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class OptionalIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (int?)value;
            var def = (string)parameter;
            return v.HasValue ? v.Value.ToString() : def;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
