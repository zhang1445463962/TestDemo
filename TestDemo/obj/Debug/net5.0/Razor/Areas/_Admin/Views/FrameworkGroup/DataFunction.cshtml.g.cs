#pragma checksum "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e102974f13968f4f4264862fad4589ae01641d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas__Admin_Views_FrameworkGroup_DataFunction), @"mvc.1.0.view", @"/Areas/_Admin/Views/FrameworkGroup/DataFunction.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_ViewImports.cshtml"
using TestDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e102974f13968f4f4264862fad4589ae01641d4", @"/Areas/_Admin/Views/FrameworkGroup/DataFunction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94fec5400794bd0dd67b81c5484828d681d7aba9", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5af7bad1a013aa83ed4e7fe5690b1e15f4509763", @"/Areas/_Admin/Views/_ViewImports.cshtml")]
    public class Areas__Admin_Views_FrameworkGroup_DataFunction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalkingTec.Mvvm.Mvc.Admin.ViewModels.FrameworkGroupVMs.FrameworkGroupMDVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label-text", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.ComboBoxTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.Form.SelectorTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SearchPanelTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SearchPanelTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e102974f13968f4f4264862fad4589ae01641d44981", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
   for (int i = 0; i < Model.DpLists.Count; i++)
  {

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e102974f13968f4f4264862fad4589ae01641d45507", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper);
#nullable restore
#line 8 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DpLists[i].List.Searcher.TableName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:combobox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e102974f13968f4f4264862fad4589ae01641d47030", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.ComboBoxTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper);
#nullable restore
#line 9 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.MultiSelect = false;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("multi-select", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.MultiSelect, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DpLists[i].IsAll);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                                                             WriteLiteral(Localizer["_Admin.AllPris"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.YesText = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("yes-text", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.YesText, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                                                                                                    WriteLiteral(Localizer["_Admin.SelectPris"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.NoText = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("no-text", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.NoText, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                                                                                                                                                 WriteLiteral(Localizer["_Admin.NoPris"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.EmptyText = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("empty-text", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.EmptyText, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                                                                                                                                                                                          WriteLiteral(Model.DpLists[i].DpName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.LabelText = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("label-text", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.LabelText, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                WriteLiteral("IsAllChange");
#nullable restore
#line 9 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                                                                                                                                                                                                                                             WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.ChangeFunc = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("change-func", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.ChangeFunc, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e102974f13968f4f4264862fad4589ae01641d413182", async() => {
                    WriteLiteral("\r\n      ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:selector", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e102974f13968f4f4264862fad4589ae01641d413457", async() => {
                        WriteLiteral("\r\n        ");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:searchpanel", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e102974f13968f4f4264862fad4589ae01641d413747", async() => {
                            WriteLiteral("\r\n          ");
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e102974f13968f4f4264862fad4589ae01641d414050", async() => {
                                WriteLiteral("\r\n            ");
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e102974f13968f4f4264862fad4589ae01641d414355", async() => {
                                }
                                );
                                __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 14 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DpLists[i].List.Searcher.Filter);

#line default
#line hidden
#nullable disable
                                __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                WriteLiteral("\r\n          ");
                            }
                            );
                            __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#nullable restore
#line 13 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.ItemsPerRow =  ItemsPerRowEnum.Two;

#line default
#line hidden
#nullable disable
                            __tagHelperExecutionContext.AddTagHelperAttribute("items-per-row", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.ItemsPerRow, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            WriteLiteral("\r\n        ");
                        }
                        );
                        __WalkingTec_Mvvm_TagHelpers_LayUI_SearchPanelTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SearchPanelTagHelper>();
                        __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SearchPanelTagHelper);
#nullable restore
#line 12 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_SearchPanelTagHelper.Vm = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DpLists[i].List);

#line default
#line hidden
#nullable disable
                        __tagHelperExecutionContext.AddTagHelperAttribute("vm", __WalkingTec_Mvvm_TagHelpers_LayUI_SearchPanelTagHelper.Vm, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        WriteLiteral("\r\n      ");
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.Form.SelectorTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper);
#nullable restore
#line 11 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper.ListVM = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DpLists[i].List);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("list-vm", __WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper.ListVM, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DpLists[i].SelectedIds);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper.TextBind = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DpLists[i].List.EntityList[0].Name);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("text-bind", __WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper.TextBind, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __WalkingTec_Mvvm_TagHelpers_LayUI_Form_SelectorTagHelper.LabelText = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("selector");
#nullable restore
#line 10 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
             WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Id = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("id", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("    <script>\r\n            IsAllChange");
#nullable restore
#line 21 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("({ value: \'");
#nullable restore
#line 21 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                                 Write(Model.DpLists[i].IsAll.ToString().ToLower());

#line default
#line hidden
#nullable disable
                WriteLiteral("\' });\r\n            function IsAllChange");
#nullable restore
#line 22 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                            Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("(data) {\r\n                if (data.value == \'true\' || data.value == \'\') {\r\n                    $(\'#selector");
#nullable restore
#line 24 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                            Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').css(\'display\', \'none\');\r\n                }\r\n                else {\r\n                    $(\'#selector");
#nullable restore
#line 27 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
                            Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').css(\'display\', \'block\');\r\n                }\r\n            }\r\n\r\n    </script>\r\n");
#nullable restore
#line 32 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
  }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e102974f13968f4f4264862fad4589ae01641d425003", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper);
#nullable restore
#line 34 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GroupCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e102974f13968f4f4264862fad4589ae01641d426501", async() => {
                    WriteLiteral("\r\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:submitbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e102974f13968f4f4264862fad4589ae01641d426774", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:closebutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e102974f13968f4f4264862fad4589ae01641d427812", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n  ");
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#nullable restore
#line 35 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align = AlignEnum.Right;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("align", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper>();
            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper);
#nullable restore
#line 5 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Areas\_Admin\Views\FrameworkGroup\DataFunction.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper.Vm = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("vm", __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper.Vm, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- WTM默认页面 Wtm buidin page-->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<Program> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalkingTec.Mvvm.Mvc.Admin.ViewModels.FrameworkGroupVMs.FrameworkGroupMDVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
