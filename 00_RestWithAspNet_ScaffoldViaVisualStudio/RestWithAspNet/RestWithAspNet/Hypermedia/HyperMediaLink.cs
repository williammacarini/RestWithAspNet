﻿using System.Text;

namespace RestWithAspNet.HyperMedia
{
    public class HyperMediaLink
    {
        private string href;
        public string Rel { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        public string Href
        {
            get
            {
                object _lock = new();
                lock (_lock)
                {
                    StringBuilder sb = new(href);
                    return sb.Replace("%2F", "/").ToString();
                }
            }
            set
            {
                href = value;
            }
        }
    }
}
