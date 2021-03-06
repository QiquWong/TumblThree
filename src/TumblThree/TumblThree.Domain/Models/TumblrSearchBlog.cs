﻿using System.Runtime.Serialization;

namespace TumblThree.Domain.Models
{
    [DataContract]
    public class TumblrSearchBlog : Blog
    {
        public TumblrSearchBlog(string url, string location, BlogTypes blogType) : base(url, location, blogType)
        {
        }

        protected override string ExtractName()
        {
            return Url.Split('/')[4];
        }

        protected override string ExtractUrl()
        {
            if (Url.StartsWith("http://"))
                Url = Url.Insert(4, "s");
            int blogNameLength = Url.Split('/')[4].Length;
            var urlLength = 30;
            return Url.Substring(0, blogNameLength + urlLength);
        }
    }
}
