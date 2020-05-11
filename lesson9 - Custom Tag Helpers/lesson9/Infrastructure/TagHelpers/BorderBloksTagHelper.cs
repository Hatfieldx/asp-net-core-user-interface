using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace lesson9.Infrastructure.TagHelpers
{
    [HtmlTargetElement("div")]
    public class BorderBloksTagHelper : TagHelper
    {
        public string MyBorderColor { get; set; } = "black";
                
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {         
            var borderAttr = new TagHelperAttribute("style", $"border: 1px solid {MyBorderColor}");
            
            output.Attributes.Add(borderAttr);
        }
    }
}
