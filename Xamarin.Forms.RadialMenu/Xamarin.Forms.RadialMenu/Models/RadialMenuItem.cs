﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xamarin.Forms.RadialMenu.Models
{
    public class RadialMenuItem : ContentView
    {
        public Enumerations.Enumerations.RadialMenuLocation Location { get; set; }
        public ObservableCollection<RadialMenuItem> DetailItems { get; set; }
        public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(ImageSource), typeof(RadialMenuItem), default(ImageSource));

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(RadialMenuItem), default(string));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public virtual void Draw()
        {
            var itemGrid = new Grid();
            if (Source != null)
            {
                itemGrid.Children.Add(new Image() { Source=this.Source});
                this.Content = itemGrid;
            }
        }

    }
}
