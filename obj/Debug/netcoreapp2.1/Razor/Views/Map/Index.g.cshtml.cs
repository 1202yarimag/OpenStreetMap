#pragma checksum "C:\Users\hyarimaga\source\repos\OpenStreetMap\OpenStreetMap\Views\Map\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac2893362be7bcd7bcdef4d829ceef5aa8a5dcb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Map_Index), @"mvc.1.0.view", @"/Views/Map/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Map/Index.cshtml", typeof(AspNetCore.Views_Map_Index))]
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
#line 1 "C:\Users\hyarimaga\source\repos\OpenStreetMap\OpenStreetMap\Views\_ViewImports.cshtml"
using OpenStreetMap;

#line default
#line hidden
#line 2 "C:\Users\hyarimaga\source\repos\OpenStreetMap\OpenStreetMap\Views\_ViewImports.cshtml"
using OpenStreetMap.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2893362be7bcd7bcdef4d829ceef5aa8a5dcb1", @"/Views/Map/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c161ce951b59e01b62ada1935d31c950e094f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Map_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\hyarimaga\source\repos\OpenStreetMap\OpenStreetMap\Views\Map\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 1076, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf980057125460d99737f7858f2b274", async() => {
                BeginContext(64, 1063, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.css""
          integrity=""sha512-puBpdR0798OZvTTbP4A8Ix/l+A4dHDD0DGqYW6RQ+9jxkRFclaxxQb/SJAWZfWAkuyeQUytO7+7N4QKrDh+drA==""
          crossorigin="""" />
    <script src=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.js""
            integrity=""sha512-nMMmRyTVoLYqjP9hrbed9S+FzjZHW5gY1TWCHA5ckwXZBadntCNs8kEqAWdrb9O7rxbCaA4lKTIWjDXZxflOcA==""
            crossorigin=""""></script>
    <script src=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.js""
            integrity=""sha512-nMMmRyTVoLYqjP9hrbed9S+FzjZHW5gY1TWCHA5ckwXZBadntCNs8kEqAWdrb9O7rxbCaA4lKTIWjDXZxflOcA==""
            crossorigin=""""></script>
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet-control-geocoder/dist/Control.Geocoder.css"" />
    <script src=""https://unpkg.com/leaflet-control-geocoder/dist/Control.Geocoder.js""></script>

    <style>
        #mapid {
            heig");
                WriteLiteral("ht: 860px;\r\n        }\r\n    </style>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1136, 3672, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "658524ce0ddc495099ad21c859c5e650", async() => {
                BeginContext(1142, 3659, true);
                WriteLiteral(@"
  
            <div id=""mapid"">

            </div>


            <script>

                var mymap = L.map('mapid', {
                    center: [38.9392248407919, 34.84912109375],
                    zoom: 6,
                    maxZoom: 20,
                    minZoom: 6
                });
                    //.setView([41.00527, 28.97696], 8);
            var circle = L.circle([41.00530, 28.97690], {
                color: 'red',
                fillColor: '#f03',
                fillOpacity: 0.5,
                radius: 500
            }).addTo(mymap);
            var polygon = L.polygon([
                [41.01630, 28.91690],
                [41.00720, 28.93790],
                [41.01220, 28.95890]
                ]).addTo(mymap);
                
                //var marker = L.marker([41.01620, 28.9779]).addTo(mymap);
                var marker = L.marker([35.189115, 26.012367],
                    {
                        draggable: true,        // Make the ico");
                WriteLiteral(@"n dragable
                        title: 'Hover Text',     // Add a title
                        opacity: 0.5
                    }            // Adjust the opacity
                ).addTo(mymap);
            var marker = L.marker([42.113759, 44.232809]).addTo(mymap);
             var marker = L.marker([38.9392248407919, 34.84912109375]).addTo(mymap);

            marker.bindPopup(""<b>Hello world!</b><br>I am a popup."");
            circle.bindPopup(""I am a circle."");
                polygon.bindPopup(""I am a polygon."");
              
                L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                    attribution: 'Map data &copy; <a href=""https://www.openstreetmap.org/"">OpenStreetMap</a> contributors, <a href=""https://creativecommons.org/licenses/by-sa/2.0/"">CC-BY-SA</a>, Imagery © <a href=""https://www.mapbox.com/"">Mapbox</a>',
                    maxZoom: 18,
                    preferCanvas: true,
                    detectRetina: true,
              ");
                WriteLiteral(@"      id: 'mapbox.satellite',
                    accessToken: 'pk.eyJ1IjoiMTIwMnlhcmltYWdhIiwiYSI6ImNqb3M4ZGh5MDBhYmgza282YTk1dDAwMjkifQ.Kt_Q7o89zGJCMJ9n011iMw'
                }).addTo(mymap);
                L.Control.geocoder().addTo(mymap);
                //var allowedBounds = L.LatLngBounds(
                //    L.latLng(35.189115, 26.012367),
                //    L.latLng(42.113759, 44.232809)
                //);
                var corner1 = L.latLng(35.189115, 26.012367),
                    corner2 = L.latLng(42.113759, 44.232809),
                    allowedBounds = L.latLngBounds(corner1, corner2);
                var latlng = L.latLng(38.9392248407919, 34.84912109375);
                var lastValidCenter;
                lastValidCenter = latlng;

                mymap.on('dragstart', function () {

                    //posdetail.lastAdvID = 0;
                    if (allowedBounds.contains(mymap.getCenter())) {
                        lastValidCenter = mymap.getCenter();");
                WriteLiteral(@"
                        return;
                    }
                    mymap.panTo(L.latLng(25.189115, 16.012367));
                });

            var popup = L.popup();

            function onMapClick(e) {
                //popup
                //    .setLatLng(e.latlng)
                //    .setContent(""You clicked the map at "" + bounds.contains(mymap.getCenter()).toString())
                //    .openOn(mymap);
                mymap.flyToBounds(allowedBounds);
            }

                mymap.on('click', onMapClick);

            </script>



");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4808, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
