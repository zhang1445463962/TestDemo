#pragma checksum "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\Home\FrontPage.en.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2056776ddf5b0dbd826e7e934990bd117eec0a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FrontPage_en), @"mvc.1.0.view", @"/Views/Home/FrontPage.en.cshtml")]
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
#line 1 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\_ViewImports.cshtml"
using TestDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\Home\FrontPage.en.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2056776ddf5b0dbd826e7e934990bd117eec0a10", @"/Views/Home/FrontPage.en.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94fec5400794bd0dd67b81c5484828d681d7aba9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FrontPage_en : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalkingTec.Mvvm.Core.BaseVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""layui-row layui-col-space15"" id=""frontpage"">
  <div class=""layui-col-md8"">
    <div class=""layui-row layui-col-space15"">
      <div class=""layui-col-md6"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">ShortCut</div>
          <div class=""layui-card-body"">

            <div class=""layui-carousel layadmin-carousel layadmin-shortcut"">
              <div carousel-item>
                <ul class=""layui-row layui-col-space10"">
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/FrameworkUser/Index"">
                      <i class=""layui-icon layui-icon-username""></i>
                      <cite>Users</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/FrameworkRole/Index"">
                      <i class=""layui-icon layui-icon-tabs""></i>
                      <cite>Roles</cite>
                    </a>
                  </li>
      ");
            WriteLiteral(@"            <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/FrameworkMenu/Index"">
                      <i class=""layui-icon layui-icon-app""></i>
                      <cite>Menu</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/FrameworkGroup/Index"">
                      <i class=""layui-icon layui-icon-user""></i>
                      <cite>Groups</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/DataPrivilege/Index"">
                      <i class=""layui-icon layui-icon-auz""></i>
                      <cite>DataPris</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/ActionLog/Index"">
                      <i class=""layui-icon layui-icon-console""></i>
                      <cite>Logs</cite>
         ");
            WriteLiteral(@"           </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a href=""/_codegen/index"" target=""_blank"">
                      <i class=""layui-icon layui-icon-template-1""></i>
                      <cite>CodeGen</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a href=""https://wtmdoc.walkingtec.cn"" target=""_blank"">
                      <i class=""layui-icon layui-icon-read""></i>
                      <cite>Doc</cite>
                    </a>
                  </li>
                </ul>

              </div>
            </div>

          </div>
        </div>
      </div>
      <div class=""layui-col-md6"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">WTM Open Source</div>
          <div class=""layui-card-body"">

            <div class=""layui-carousel layadmin-carousel layadmin-backlog"">
              <div carousel-item>
                <ul ");
            WriteLiteral(@"class=""layui-row layui-col-space10"">
                  <li class=""layui-col-xs6"">
                    <a href=""https://github.com/dotnetcore/WTM/stargazers"" class=""layadmin-backlog-body""
                       target=""_blank"">
                      <h3>Star</h3>
                      <p><cite id=""githubstar""></cite></p>
                    </a>
                  </li>
                  <li class=""layui-col-xs6"">
                    <a href=""https://github.com/dotnetcore/WTM/network/members"" class=""layadmin-backlog-body""
                       target=""_blank"">
                      <h3>Fork</h3>
                      <p><cite id=""githubfork""></cite></p>
                    </a>
                  </li>
                  <li class=""layui-col-xs6"">
                    <a href=""https://github.com/dotnetcore/WTM/watchers"" class=""layadmin-backlog-body""
                       target=""_blank"">
                      <h3>Watch</h3>
                      <p><cite id=""githubwatch""></cite></p>
         ");
            WriteLiteral(@"           </a>
                  </li>
                  <li class=""layui-col-xs6"">
                    <a href=""https://github.com/dotnetcore/WTM/issues"" class=""layadmin-backlog-body"" target=""_blank"">
                      <h3>Issue</h3>
                      <p><cite id=""githubissue""></cite></p>
                    </a>
                  </li>
                </ul>
                <ul class=""layui-row layui-col-space10"">
                  <li class=""layui-col-xs12"">
                    <span style=""font-size:16px;line-height:50px;"">WTM is free and open source, if you like wtm, please star us at Github~~</span>

                    <p style=""text-align:center"">
                      <a href=""https://github.com/dotnetcore/wtm"" target=""_blank""
                         style=""background-color:#eee;background-image:linear-gradient(to bottom, #fcfcfc 0, #eee 100%);background-repeat:no-repeat;border:1px solid #d5d5d5;color:#333;padding:3px 10px 3px 8px;font-size:16px;line-height:22px"">
           ");
            WriteLiteral(@"             <span width=""20""
                              style=""width:20px;height:20px;font-size:16px;line-height:22px;box-sizing:border-box; background-size:100% 100%; background-image:url('data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB2ZXJzaW9uPSIxLjEiIGlkPSJMYXllcl8xIiB4PSIwcHgiIHk9IjBweCIgd2lkdGg9IjQwcHgiIGhlaWdodD0iNDBweCIgdmlld0JveD0iMTIgMTIgNDAgNDAiIGVuYWJsZS1iYWNrZ3JvdW5kPSJuZXcgMTIgMTIgNDAgNDAiIHhtbDpzcGFjZT0icHJlc2VydmUiPjxwYXRoIGZpbGw9IiMzMzMzMzMiIGQ9Ik0zMiAxMy40Yy0xMC41IDAtMTkgOC41LTE5IDE5YzAgOC40IDUuNSAxNS41IDEzIDE4YzEgMC4yIDEuMy0wLjQgMS4zLTAuOWMwLTAuNSAwLTEuNyAwLTMuMiBjLTUuMyAxLjEtNi40LTIuNi02LjQtMi42QzIwIDQxLjYgMTguOCA0MSAxOC44IDQxYy0xLjctMS4yIDAuMS0xLjEgMC4xLTEuMWMxLjkgMC4xIDIuOSAyIDIuOSAyYzEuNyAyLjkgNC41IDIuMSA1LjUgMS42IGMwLjItMS4yIDAuNy0yLjEgMS4yLTIuNmMtNC4yLTAuNS04LjctMi4xLTguNy05LjRjMC0yLjEgMC43LTMuNyAyLTUuMWMtMC4yLTAuNS0wLjgtMi40IDAuMi01YzAgMCAxLjYtMC41IDUuMiAyIGMxLjUtMC40IDMuMS0wLjcgNC44LTAuN2M");
            WriteLiteral(@"xLjYgMCAzLjMgMC4yIDQuNyAwLjdjMy42LTIuNCA1LjItMiA1LjItMmMxIDIuNiAwLjQgNC42IDAuMiA1YzEuMiAxLjMgMiAzIDIgNS4xYzAgNy4zLTQuNSA4LjktOC43IDkuNCBjMC43IDAuNiAxLjMgMS43IDEuMyAzLjVjMCAyLjYgMCA0LjYgMCA1LjJjMCAwLjUgMC40IDEuMSAxLjMgMC45YzcuNS0yLjYgMTMtOS43IDEzLTE4LjFDNTEgMjEuOSA0Mi41IDEzLjQgMzIgMTMuNHoiLz48L3N2Zz4=')"">&nbsp;&nbsp;&nbsp;&nbsp;</span>
                        <span>Stars <cite id=""githubstars""></cite></span>
                      </a>
                    </p>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div class=""layui-col-md6"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">Controllers</div>
          <div class=""layui-carousel layadmin-carousel layadmin-dataview"">
            <div carousel-item>
              <div id=""chart_Controller"" style="" height:300px;"">
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class=""layui");
            WriteLiteral(@"-col-md6"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">Others</div>
          <div class=""layui-carousel layadmin-carousel layadmin-dataview"">
            <div carousel-item>
              <div id=""chart_Other"" style="" height:300px;"">
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class=""layui-col-md12"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">Mock data</div>
          <div class=""layui-card-body"">

            <div class=""layui-carousel layadmin-carousel layadmin-dataview"" data-anim=""fade""
                 lay-filter=""LAY-index-dataview"">
              <div carousel-item id=""LAY-index-dataview"">
                <div><i class=""layui-icon layui-icon-loading1 layadmin-loading""></i></div>
                <div></div>
                <div></div>
              </div>
            </div>

          </div>
        </div>
      </div>
    </div>
  </div>

  <div class=""layui-co");
            WriteLiteral("l-md4\">\r\n    <div class=\"layui-card\">\r\n      <div class=\"layui-card-header\">Version</div>\r\n      <div class=\"layui-card-body layui-text\">\r\n");
#nullable restore
#line 173 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\Home\FrontPage.en.cshtml"
         if (Model.ConfigInfo.IsQuickDebug == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <p>You are in <font color=""Red"">debug mode</font>，in debug mode, WTM will：</p>
          <p><span class=""layui-badge layui-bg-cyan"">1</span>&nbsp;Reflect all controllers' Index action to be the menu on left</p>
          <p><span class=""layui-badge layui-bg-cyan"">2</span>&nbsp;Fill in default user name and password</p>
          <p><span class=""layui-badge layui-bg-cyan"">3</span>&nbsp;Skip authorization</p>
          <p>
            Modify isquickdebug in the Appsettings file to turn off debugging mode. <a href=""http://wtmdoc.walkingtec.cn/#/QuickStart/FAQ"" target=""_blank"">详见文档</a>
          </p>
");
#nullable restore
#line 182 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\Home\FrontPage.en.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <p>You are in production mode，it is the mode you should use when you publish the system.In production mode, WTM will:</p>
          <p><span class=""layui-badge layui-bg-cyan"">1</span>&nbsp;Load menu and authorization info from database</p>
          <p><span class=""layui-badge layui-bg-cyan"">2</span>&nbsp;Do authentication and authorization check</p>
          <p><span class=""layui-badge layui-bg-cyan"">3</span>&nbsp;Do not output debug messages</p>
          <p>
            Modify isquickdebug in the Appsettings file to turn on debugging mode.<a href=""http://wtmdoc.walkingtec.cn/#/QuickStart/FAQ"" target=""_blank"">详见文档</a>
          </p>
");
#nullable restore
#line 192 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\Home\FrontPage.en.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      </div>
    </div>

    <div class=""layui-card"">
      <div class=""layui-card-header"">Why WTM</div>
      <div class=""layui-card-body layadmin-takerates"">
        <ul>
          <li><i class=""layui-icon layui-icon-ok""></i>One click WTM project generation</li>
          <li><i class=""layui-icon layui-icon-ok""></i>One click generate CRUD,search,import/export,batch operation code</li>
          <li><i class=""layui-icon layui-icon-ok""></i>Support one to many, many to many association model identification and code generation</li>
          <li><i class=""layui-icon layui-icon-ok""></i>Support React and VUE</li>
          <li><i class=""layui-icon layui-icon-ok""></i>Support sqlserver，mysql，pgsql, sqlite</li>
          <li><i class=""layui-icon layui-icon-ok""></i>Encapsulates most of the controls of layui, antd and element, making writing the view easier</li>
          <li><i class=""layui-icon layui-icon-ok""></i>Many base classes are provided to encapsulate most common background operations</li>
     ");
            WriteLiteral(@"     <li><i class=""layui-icon layui-icon-ok""></i>It provides common modules such as user, role, user group, menu, log, etc</li>
          <li><i class=""layui-icon layui-icon-ok""></i>Support the development and configuration of Data permission</li>
          <li><i class=""layui-icon layui-icon-ok""></i>Support read-write separation and multi database</li>
        </ul>
      </div>
    </div>

    <div class=""layui-card"">
      <div class=""layui-card-header"">
        From author
        <i class=""layui-icon layui-icon-tips"" lay-tips=""To pursue goodness is as difficult as ascending a mountain"" lay-offset=""5""></i>
      </div>
      <div class=""layui-card-body layui-text layadmin-text"">
        <p>
          WTM stands for Walkingtec MVVM , WTM is a rapid development framework, how fast is it? At least at present, in the open source project of dotnetcore, I haven't seen a more grounded and faster development framework. The design concept of WTM is to speed up the development speed and reduce the dev");
            WriteLiteral(@"elopment cost to the greatest extent.
        </p>
        <p>
          Microsoft has finally figured it out in the past two years,
          The emergence of dotnet core and the acquisition of GitHub are both very right directions. Of course, there is still a long way to go to reach the Java ecosystem, so I will contribute a little.
        </p>
        <p>
          WTM has been loved by more and more developers since its open source. WTM will surely repay your love with a more mature and stable attitude. Improve yourself, benefit others, I am not alone!
        </p>
        <p>
          —— Github：<a href=""https://github.com/dotnetcore/WTM"" target=""_blank"">https://github.com/dotnetcore/WTM</a>
        </p>
        <p>—— Docs：<a href=""https://wtmdoc.walkingtec.cn"" target=""_blank"">https://wtmdoc.walkingtec.cn</a></p>
        <p>—— QQ：694148336</p>
      </div>
    </div>
  </div>

</div>
<script>
  $(""#frontpage"").parent().css(""background-color"", ""#eee"");
  $.get(""/Home/GetGithubInfo"", ");
            WriteLiteral(@"function (r) {
    if (r === undefined || r === null) {
      return;
    }
    $(""#githubstar"").html(r.stargazers_count);
    $(""#githubstars"").html(r.stargazers_count);
    $(""#githubfork"").html(r.forks_count);
    $(""#githubwatch"").html(r.subscribers_count);
    $(""#githubissue"").html(r.open_issues_count);
  });

  layui.use(['admin', 'carousel'], function () {
    var $ = layui.$
      , admin = layui.admin
      , carousel = layui.carousel
      , element = layui.element
      , device = layui.device();

    $('.layadmin-carousel').each(function () {
      var othis = $(this);
      carousel.render({
        elem: this
        , width: '100%'
        , arrow: 'none'
        , interval: othis.data('interval')
        , autoplay: othis.data('autoplay') === true
        , trigger: (device.ios || device.android) ? 'click' : 'hover'
        , anim: othis.data('anim')
      });
    });

    element.render('progress');

  });

  layui.use(['admin', 'carousel', 'echarts'], func");
            WriteLiteral(@"tion () {
    var $ = layui.$
      , admin = layui.admin
      , carousel = layui.carousel
      , echarts = layui.echarts;

      var control = echarts.init(document.getElementById('chart_Controller'), 'default');
      var controlOption = {
        title: { text: 'Controller' },
        tooltip: {},
         legend: {
          data: ");
#nullable restore
#line 288 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\Home\FrontPage.en.cshtml"
           Write(Html.Raw(JsonSerializer.Serialize(ViewData["controller.legend"])));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        },\r\n       xAxis: {},\r\n        yAxis: {\r\n          data: [\'Controller\', \'Action\']\r\n        },\r\n        series: ");
#nullable restore
#line 294 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\Home\FrontPage.en.cshtml"
           Write(Html.Raw(JsonSerializer.Serialize(ViewData["controller.series"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      };
      control.setOption(controlOption);

      var other = echarts.init(document.getElementById('chart_Other'), 'default');
      var otherOption = {
        title: { text: 'Others' },
        tooltip: {},
        xAxis: {},
        yAxis: {
          data: ['Model', 'Dll', 'DataPri', 'ConnectionString', 'App Settings']
        },
        series: ");
#nullable restore
#line 306 "D:\Work\Asp.Core框架\TestDemo\TestDemo\Views\Home\FrontPage.en.cshtml"
           Write(Html.Raw(JsonSerializer.Serialize(ViewData["other.series"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      };
      other.setOption(otherOption);

    var echartsApp = [], options = [
      {
        title: {
          text: 'Today\'s traffic trends',
          x: 'center',
          textStyle: {
            fontSize: 14
          }
        },
        tooltip: {
          trigger: 'axis'
        },
        legend: {
          data: ['', '']
        },
        xAxis: [{
          type: 'category',
          boundaryGap: false,
          data: ['06:00', '06:30', '07:00', '07:30', '08:00', '08:30', '09:00', '09:30', '10:00', '11:30', '12:00', '12:30', '13:00', '13:30', '14:00', '14:30', '15:00', '15:30', '16:00', '16:30', '17:00', '17:30', '18:00', '18:30', '19:00', '19:30', '20:00', '20:30', '21:00', '21:30', '22:00', '22:30', '23:00', '23:30']
        }],
        yAxis: [{
          type: 'value'
        }],
        series: [{
          name: 'PV',
          type: 'line',
          smooth: true,
          itemStyle: { normal: { areaStyle: { type: 'default' } } },
          dat");
            WriteLiteral(@"a: [111, 222, 333, 444, 555, 666, 3333, 33333, 55555, 66666, 33333, 3333, 6666, 11888, 26666, 38888, 56666, 42222, 39999, 28888, 17777, 9666, 6555, 5555, 3333, 2222, 3111, 6999, 5888, 2777, 1666, 999, 888, 777]
        }, {
          name: 'UV',
          type: 'line',
          smooth: true,
          itemStyle: { normal: { areaStyle: { type: 'default' } } },
          data: [11, 22, 33, 44, 55, 66, 333, 3333, 5555, 12666, 3333, 333, 666, 1188, 2666, 3888, 6666, 4222, 3999, 2888, 1777, 966, 655, 555, 333, 222, 311, 699, 588, 277, 166, 99, 88, 77]
        }]
      },

      {
        title: {
          text: 'Visitor browser distribution',
          x: 'center',
          textStyle: {
            fontSize: 14
          }
        },
        tooltip: {
          trigger: 'item',
          formatter: ""{a} <br/>{b} : {c} ({d}%)""
        },
        legend: {
          orient: 'vertical',
          x: 'left',
          data: ['Chrome', 'Firefox', 'IE 8.0', 'Safari', 'Others']
        },
 ");
            WriteLiteral(@"       series: [{
          name: 'Access source',
          type: 'pie',
          radius: '55%',
          center: ['50%', '50%'],
          data: [
            { value: 9052, name: 'Chrome' },
            { value: 1610, name: 'Firefox' },
            { value: 3200, name: 'IE 8.0' },
            { value: 535, name: 'Safari' },
            { value: 1700, name: 'Others' }
          ]
        }]
      },

      {
        title: {
          text: 'New users in the last week',
          x: 'center',
          textStyle: {
            fontSize: 14
          }
        },
        tooltip: { 
          trigger: 'axis',
          formatter: ""{b}<br>New users：{c}""
        },
        xAxis: [{ 
          type: 'category',
          data: ['11-07', '11-08', '11-09', '11-10', '11-11', '11-12', '11-13']
        }],
        yAxis: [{  
          type: 'value'
        }],
        series: [{ 
          type: 'line',
          data: [200, 300, 400, 610, 150, 270, 380],
        }]
      }");
            WriteLiteral(@"
    ]
      , elemDataView = $('#LAY-index-dataview').children('div')
      , renderDataView = function (index) {
        echartsApp[index] = echarts.init(elemDataView[index], layui.echartsTheme);
        echartsApp[index].setOption(options[index]);
        //window.onresize = echartsApp[index].resize;
        admin.resize(function () {
          echartsApp[index].resize();
          control.resize();
          other.resize();
        });
      };


    if (!elemDataView[0]) return;

    renderDataView(0);

    var carouselIndex = 0;
    carousel.on('change(LAY-index-dataview)', function (obj) {
      renderDataView(carouselIndex = obj.index);
    });

    layui.admin.on('side', function () {
      setTimeout(function () {
        renderDataView(carouselIndex);
      }, 300);
    });

    layui.admin.on('hash(tab)', function () {
      layui.router().path.join('') || renderDataView(carouselIndex);
    });
  });

</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalkingTec.Mvvm.Core.BaseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
