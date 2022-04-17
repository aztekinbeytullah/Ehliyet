using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebIU.TagHelpers
{
    [HtmlTargetElement("getir")]
    public class DenemeTag:TagHelper
    {

        public int Questionsid { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);  
        }

    }
}
