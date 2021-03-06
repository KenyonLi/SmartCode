﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCode.Configuration
{
    public class Build
    {
        /// <summary>
        /// 构建类型
        /// Table | Project | Clear
        /// </summary>
        public String Type { get; set; }
        public String Module { get; set; }
        public String TemplateEngine { get; set; } 
        public String Template { get; set; }
        public Output Output { get; set; }
        public IEnumerable<String> IncludeTables { get; set; }
        public IEnumerable<String> IgnoreTables { get; set; }
        public NamingConverter NamingConverter { get; set; }
        /// <summary>
        /// 自定义构建参数
        /// </summary>
        public IDictionary<String, String> Paramters { get; set; }
    }
}
