using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc93.Models
{
    public interface InterfaceModel
    {
        [SitecoreId]
        Guid Id { get; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

        string Title { get; set; }

        DateTime Updated { get; set; }

        string Url { get; set; }
    }


    public abstract partial class GlassBase
    {

        [SitecoreId]
        public virtual Guid Id { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }

        public virtual DateTime Updated { get; private set; }

        public virtual string Title { get; private set; }
    }
}
