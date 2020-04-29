﻿namespace Blazored.Toast.Configuration
{
    public class ToastSettings
    {
        public ToastSettings(
            string heading, 
            string message,
            IconType iconType,
            string baseClass,
            string additionalClasses,
            string icon)
        {
            Heading = heading;
            Message = message;
            IconType = iconType;
            BaseClass = baseClass;
            AdditionalClasses = additionalClasses;
            Icon = icon;
        }

        public string Heading { get; set; }
        public string Message { get; set; }
        public string BaseClass { get; set; }
        public string AdditionalClasses { get; set; }
        public string Icon { get; set; }
        public IconType IconType { get; set; }
    }
}
