using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JiaJiao.Model
{
    public class ClassInfo
    {
        public string Day { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
        public string Time3 { get; set; }
        public string Time4 { get; set; }
        public string Time5 { get; set; }
        public string Time6 { get; set; }
        public string Time7 { get; set; }
     
        public Dictionary<int, ClassSetting> KeyValues { get; set; }
    }
}
