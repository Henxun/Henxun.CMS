using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Henxun.Cms.Admin.TagHelpers
{
    [HtmlTargetElement(SwitchTagName)]
    public class SwitchTagHelper : TagHelper
    {
        private const string SwitchTagName = "cl-switch";
        private const string ForAttributeName = "asp-for";
        private const string SwitchTextAttributeName = "asp-switch-text";

        protected IHtmlGenerator Generator { get; }
        public SwitchTagHelper(IHtmlGenerator generator)
        {
            Generator = generator;
        }

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        [HtmlAttributeName(SwitchTextAttributeName)]
        public string SwitchText { get; set; } = "ON|OFF";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string inputName = ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(For?.Name);
            output.TagName = "input";
            output.TagMode = TagMode.SelfClosing;
            if (For?.Model?.ToString().ToLower() == "true")
            {
                output.Attributes.Add("checked", "checked");
            }
            output.Attributes.Add("type", "checkbox");
            output.Attributes.Add("id", inputName);
            output.Attributes.Add("name", inputName);
            output.Attributes.Add("value", "true");
            output.Attributes.Add("lay-skin", "switch");
            output.Attributes.Add("lay-text", SwitchText);

        }
    }
}
