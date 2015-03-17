﻿using System;
using System.Collections.Generic;

namespace SimpleMvcSitemap.Sample.SampleBusiness
{
    public class SampleSitemapNodeBuilder : ISampleSitemapNodeBuilder
    {
        public IEnumerable<SitemapIndexNode> BuildSitemapIndex()
        {
            var nodes = new List<SitemapIndexNode>();
            nodes.Add(new SitemapIndexNode("/sitemapcategories")
            {
                LastModificationDate = DateTime.Now
            });

            nodes.Add(new SitemapIndexNode("/sitemapbrands")
            {
                LastModificationDate = DateTime.Now
            });

            return nodes;
        }

        public IEnumerable<SitemapNode> BuildSitemapNodes()
        {
            var nodes = new List<SitemapNode>();
            nodes.Add(new SitemapNode("http://msdn.microsoft.com/en-us/library/ms752244(v=vs.110).aspx")
            {
                LastModificationDate = DateTime.Now,
                ChangeFrequency = ChangeFrequency.Daily,
                Priority = 0.5M,
                Images = new List<SitemapImage>
                         {
                             new SitemapImage("/image1") { Caption = "caption", Title = "title" },
                             new SitemapImage("/image2") { License = "license", Location = "İstanbul, Turkey" }
                         }
            });

            

            nodes.Add(new SitemapNode("http://joelabrahamsson.com/xml-sitemap-with-aspnet-mvc/")
            {
                Link = new SiteMapLink("http://m.joelabrahamsson.com/xml-sitemap-with-aspnet-mvc/")
                {
                    Rel = "alternate",
                    Media = "only screen and (max-width: 640px)"
                }
            });

            return nodes;
        }
    }
}