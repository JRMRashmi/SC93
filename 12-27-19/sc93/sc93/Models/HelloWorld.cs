using System;
using Glass.Mapper.Sc.Fields;


namespace sc93.Models
{
    public class HelloWorld : GlassBase
    {
        public virtual string Title { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual Link Url { get; set; }

        public virtual Image Logo { get; set; }

    }
}