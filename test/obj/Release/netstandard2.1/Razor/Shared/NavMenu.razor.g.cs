#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab67e2980199d3884f1edd6bdc2044f3d1ae2bb0"
// <auto-generated/>
#pragma warning disable 1591
namespace test.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using blazormaterialise;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<blazormaterialise.BM_collapsible>(0);
            __builder.AddAttribute(1, "Visibility", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_show>(
#nullable restore
#line 2 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                            enum_show.hide_mobile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_collapsible_item>(4);
                __builder2.AddAttribute(5, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n            Base\r\n        ");
                }
                ));
                __builder2.AddAttribute(7, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenComponent<blazormaterialise.BM_collection>(9);
                    __builder3.AddAttribute(10, "Header", "");
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(12, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(13);
                        __builder4.AddAttribute(14, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "Href", "Grid");
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(17, "\r\n                    Grid\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(18, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(19);
                        __builder4.AddAttribute(20, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "Href", "Helpers");
                        __builder4.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(23, "\r\n                    Helpers\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(25);
                        __builder4.AddAttribute(26, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 15 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "Href", "Media");
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(29, "\r\n                    Media\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(31);
                        __builder4.AddAttribute(32, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 18 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Href", "Styles");
                        __builder4.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(35, "\r\n                    Styles\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(36, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(37);
                        __builder4.AddAttribute(38, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 21 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "Href", "Forms");
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(41, "\r\n                    Forms\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_collapsible_item>(45);
                __builder2.AddAttribute(46, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(47, "\r\n            Components\r\n        ");
                }
                ));
                __builder2.AddAttribute(48, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n        ");
                    __builder3.OpenComponent<blazormaterialise.BM_collection>(50);
                    __builder3.AddAttribute(51, "Header", "");
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(53, "\r\n            ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(54);
                        __builder4.AddAttribute(55, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 33 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                           enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(56, "Href", "Button");
                        __builder4.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(58, "\r\n                Button\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n            ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(60);
                        __builder4.AddAttribute(61, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 36 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                           enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(62, "Href", "Badge");
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(64, "\r\n                Badge\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\r\n            ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(66);
                        __builder4.AddAttribute(67, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 39 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                           enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(68, "Href", "Breadcrumbs");
                        __builder4.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(70, "\r\n                Breadcrumbs\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(71, "\r\n            ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(72);
                        __builder4.AddAttribute(73, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 42 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                           enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "Href", "Card");
                        __builder4.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(76, "\r\n                Card\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\r\n            ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(78);
                        __builder4.AddAttribute(79, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 45 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                           enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(80, "Href", "Collections");
                        __builder4.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(82, "\r\n                Collections\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(83, "\r\n            ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(84);
                        __builder4.AddAttribute(85, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 48 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                           enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "Href", "FloatingActionButton");
                        __builder4.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(88, "\r\n                Floating Action Button\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(89, "\r\n            ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(90);
                        __builder4.AddAttribute(91, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 51 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                           enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(92, "Href", "Footer");
                        __builder4.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(94, "\r\n                Footer\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(95, "\r\n            ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(96);
                        __builder4.AddAttribute(97, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 54 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                           enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(98, "Href", "Preloader");
                        __builder4.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(100, "\r\n                Preloader\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(101, "\r\n\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_collapsible_item>(104);
                __builder2.AddAttribute(105, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(106, "\r\n            Javascript\r\n        ");
                }
                ));
                __builder2.AddAttribute(107, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(108, "\r\n            ");
                    __builder3.OpenComponent<blazormaterialise.BM_collection>(109);
                    __builder3.AddAttribute(110, "Header", "");
                    __builder3.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(112, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(113);
                        __builder4.AddAttribute(114, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 67 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(115, "Href", "Carousel");
                        __builder4.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(117, "\r\n                    Carousel\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(118, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(119);
                        __builder4.AddAttribute(120, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 70 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(121, "Href", "Dropdown");
                        __builder4.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(123, "\r\n                    Dropdown\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(124, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(125);
                        __builder4.AddAttribute(126, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 73 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(127, "Href", "Collapsible");
                        __builder4.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(129, "\r\n                    Collapsible\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(130, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(131);
                        __builder4.AddAttribute(132, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 76 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(133, "Href", "Featurediscovery");
                        __builder4.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(135, "\r\n                    FeatureDiscovery\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(136, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(137);
                        __builder4.AddAttribute(138, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 79 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(139, "Href", "Js_media");
                        __builder4.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(141, "\r\n                    Media\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(142, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(143);
                        __builder4.AddAttribute(144, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 82 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(145, "Href", "Slider");
                        __builder4.AddAttribute(146, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(147, "\r\n                    Slider\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(148, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(149);
                        __builder4.AddAttribute(150, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 85 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(151, "Href", "Modal");
                        __builder4.AddAttribute(152, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(153, "\r\n                    Modal\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(154, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(155);
                        __builder4.AddAttribute(156, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 88 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(157, "Href", "Tooltip");
                        __builder4.AddAttribute(158, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(159, "\r\n                    Tooltip\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(160, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(161);
                        __builder4.AddAttribute(162, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 91 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(163, "Href", "Toast");
                        __builder4.AddAttribute(164, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(165, "\r\n                    Toast\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(166, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(167);
                        __builder4.AddAttribute(168, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 94 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(169, "Href", "Tabs");
                        __builder4.AddAttribute(170, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(171, "\r\n                    Tabs\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(172, "\r\n                ");
                        __builder4.OpenComponent<blazormaterialise.BM_collection_item>(173);
                        __builder4.AddAttribute(174, "Type_item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_collection>(
#nullable restore
#line 97 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
                                               enum_collection.Links

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(175, "Href", "Parallax");
                        __builder4.AddAttribute(176, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(177, "\r\n                   Parallax\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(178, "\r\n\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(179, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(180, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Shared/NavMenu.razor"
      

    public bool ok = false;

    public enum_color bac= enum_color.amber_accent_1;

   

    private void cl()
    {        
        if (ok)
        {
            ok = false;
            bac= enum_color.amber_accent_1;
        }
        else
        {
            ok = true;
            bac = enum_color.blue_accent_2;
        }
        
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
