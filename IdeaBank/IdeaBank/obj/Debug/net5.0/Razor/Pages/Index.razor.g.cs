#pragma checksum "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd3ecdd0bc01b48e04be01698a5adb7850629745"
// <auto-generated/>
#pragma warning disable 1591
namespace IdeaBank.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using IdeaBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\_Imports.razor"
using IdeaBank.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "main");
            __builder.AddMarkupContent(1, @"<div class=""bgImg""><section class=""py-4 text-center container""><div class=""row py-lg-5""><div class=""col-lg-6 col-md-6 mx-auto""><div class=""d-flex flex-row justify-content-center""><h1 class=""fw-light"">Aalborg Portland Idébank</h1><h4 class=""text-primary"">Prototype</h4></div>
                    <p class=""fs-5 py-1"">
                        Velkommen til Aalborg Portland's idébank. Her er der mulighed for at indsende dine egne
                        idéer til eventuelle forbedringer eller ændringer.
                    </p>
                    <a href=""submitIdeaPage.html"" class=""btn btn-lg btn-primary my-2 p-4"">Tilføj ny idé</a></div></div></section></div>

    ");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "py-5 bg-light");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "<h2 class=\"text-center\">Idéoversigt</h2>\r\n            ");
            __builder.AddMarkupContent(7, "<p class=\"text-center\">Klik på en idé for at læse mere </p>\r\n            ");
            __builder.AddMarkupContent(8, "<p class=\" text-center text-danger mb-4\">Da dette en mark-up, er det kun de to første idéer i listen, der kan klikkes på.</p>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row table-responsive rounded-cos");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table my-0 table-primary table-striped table-hover");
            __builder.AddMarkupContent(13, "<thead><tr><th scope=\"col\" class=\"bg-primary text-white\">\r\n                                Projektnavn <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-filter\" viewBox=\"0 0 16 16\"><path d=\"M6 10.5a.5.5 0 0 1 .5-.5h3a.5.5 0 0 1 0 1h-3a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h11a.5.5 0 0 1 0 1h-11a.5.5 0 0 1-.5-.5z\"></path></svg></th>\r\n                            <th scope=\"col\" class=\"bg-primary text-white\">\r\n                                Forretningsenhed <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-filter\" viewBox=\"0 0 16 16\"><path d=\"M6 10.5a.5.5 0 0 1 .5-.5h3a.5.5 0 0 1 0 1h-3a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h11a.5.5 0 0 1 0 1h-11a.5.5 0 0 1-.5-.5z\"></path></svg></th>\r\n                            <th scope=\"col\" class=\"bg-primary text-white\">\r\n                                Afdeling <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-filter\" viewBox=\"0 0 16 16\"><path d=\"M6 10.5a.5.5 0 0 1 .5-.5h3a.5.5 0 0 1 0 1h-3a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h11a.5.5 0 0 1 0 1h-11a.5.5 0 0 1-.5-.5z\"></path></svg></th>\r\n                            <th scope=\"col\" class=\"bg-primary text-white\">\r\n                                Status <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-filter\" viewBox=\"0 0 16 16\"><path d=\"M6 10.5a.5.5 0 0 1 .5-.5h3a.5.5 0 0 1 0 1h-3a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h11a.5.5 0 0 1 0 1h-11a.5.5 0 0 1-.5-.5z\"></path></svg></th>\r\n                            <th scope=\"col\" class=\"bg-primary text-white\">\r\n                                Prioritet <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-filter\" viewBox=\"0 0 16 16\"><path d=\"M6 10.5a.5.5 0 0 1 .5-.5h3a.5.5 0 0 1 0 1h-3a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zm-2-3a.5.5 0 0 1 .5-.5h11a.5.5 0 0 1 0 1h-11a.5.5 0 0 1-.5-.5z\"></path></svg></th>\r\n                            <th scope=\"col\" class=\"bg-primary text-white\">\r\n                                Dato <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-sort-down\" viewBox=\"0 0 16 16\"><path d=\"M3.5 2.5a.5.5 0 0 0-1 0v8.793l-1.146-1.147a.5.5 0 0 0-.708.708l2 1.999.007.007a.497.497 0 0 0 .7-.006l2-2a.5.5 0 0 0-.707-.708L3.5 11.293V2.5zm3.5 1a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zM7.5 6a.5.5 0 0 0 0 1h5a.5.5 0 0 0 0-1h-5zm0 3a.5.5 0 0 0 0 1h3a.5.5 0 0 0 0-1h-3zm0 3a.5.5 0 0 0 0 1h1a.5.5 0 0 0 0-1h-1z\"></path></svg></th></tr></thead>\r\n                    ");
            __builder.OpenElement(14, "tbody");
            __builder.OpenElement(15, "tr");
            __builder.AddAttribute(16, "title", "Klik for at læse mere");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\Pages\Index.razor"
                                                                    () => Modal.Open()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "<td>Udnyttelse af spildvarme</td>\r\n                            ");
            __builder.AddMarkupContent(19, "<td>Aalborg Portland</td>\r\n                            ");
            __builder.AddMarkupContent(20, "<td>Produktion</td>\r\n                            ");
            __builder.AddMarkupContent(21, "<td>Oprettet</td>\r\n                            ");
            __builder.AddMarkupContent(22, "<td>Høj</td>\r\n                            ");
            __builder.AddMarkupContent(23, "<td>04/10/21</td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n                        ");
            __builder.OpenComponent<IdeaBank.Pages.Modal>(25);
            __builder.AddComponentReferenceCapture(26, (__value) => {
#nullable restore
#line 75 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\Pages\Index.razor"
                                     Modal = (IdeaBank.Pages.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n\r\n                        \r\n                        ");
            __builder.AddMarkupContent(28, "<div class=\"modal fade\" id=\"exampleModal\" tabindex=\"-1\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\"><div class=\"modal-dialog modal-dialog-scrollable  modal-xl\"><div class=\"modal-content rounded-cos border-0\"><div class=\"modal-header bg-primary text-white\" style=\"border-radius: 11px 11px 0px 0px;\"><h5 class=\"modal-title\">Udnyttelse af spildvarme</h5>\r\n                                        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button></div>\r\n                                    <div class=\"modal-body bg-light\"><div class=\"row g-2\"><div class=\"row g-2\"><div class=\"col-12\"><div class=\"row mx-1\"><div class=\"col\"><h6>Initialer</h6>\r\n                                                            <p>HFU</p></div>\r\n                                                        <div class=\"col\"><h6>Forretningsenhed</h6>\r\n                                                            <p> Aalborg Portland</p></div>\r\n                                                        <div class=\"col\"><h6>Afdeling</h6>\r\n                                                            <p>Produktion</p></div>\r\n                                                        <div class=\"col\"><h6>Prioritet</h6>\r\n                                                            <p>Høj</p></div>\r\n                                                        <div class=\"col\"><h6>Dato</h6>\r\n                                                            <p>04/10/21</p></div>\r\n                                                        <div class=\"col\"><h6>Status</h6>\r\n                                                            <p>Oprettet</p></div></div></div>\r\n                                                <div class=\"col-12\"><div class=\"card\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Idébeskrivelse\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                Vores varmeovne skaber en masse spildvarme. Kunne man eventuelt\r\n                                                                udnytte denne spildvarme til at opvarme vand til fjernvarme?\r\n                                                            </p></div></div></div>\r\n                                                <div class=\"col-6\"><div class=\"card\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Risiko\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                Det kan være dyrt at implementere, men kan være billigere i det lange løb.\r\n                                                            </p></div></div></div>\r\n                                                <div class=\"col-6\"><div class=\"card\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Plan\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                Vi kan starte hurtigst muligt med at undersøge om det overhovedet er muligt\r\n                                                                at udnytte denne spildvarme.\r\n                                                            </p></div></div></div>\r\n                                                <div class=\"col-6\"><div class=\"card\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Forventet resultat\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                Det forventede resultat er at vi undgår energispild og i fremtiden kan spare penge på opvarmning og sælge til fjernvarme.\r\n                                                            </p></div></div></div>\r\n                                                <div class=\"col-6\"><div class=\"card h-100\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Team\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                GII, HKU, HUA\r\n                                                            </p></div></div></div></div></div>\r\n                                        <div class=\"p-2 my-3 bg-light rounded-cos\"><div class=\"container-fluid\"><h3 class=\"my-2\">Kommentarspor</h3>\r\n                                                <div class=\"d-flex flex-row mb-2\"><textarea type=\"text\" class=\"form-control rounded-cos my-1\" id=\"initials\" placeholder=\"Skriv din kommentar her\"></textarea>\r\n                                                    <div><input type=\"text\" class=\"form-control mx-2 my-1 rounded-cos\" id=\"initials\" maxlength=\"4\" placeholder=\"Initialer\">\r\n                                                        <button class=\"btn btn-primary mx-2 my-1 rounded-cos w-100\" type=\"button\">\r\n                                                            Kommenter\r\n                                                        </button></div></div>\r\n                                                <ul class=\"list-group list-group-flush\"><li class=\"list-group-item bg-transparent mb-0 pb-0 mt-2\"><h6 class=\"text-primary mb-0\">\r\n                                                            MLJ <small class=\"text-muted\" style=\"font-size: 0.8rem;\">\r\n                                                                For 20 timer\r\n                                                                siden\r\n                                                            </small></h6>\r\n                                                        <p>\r\n                                                            Jeg synes det er en spændende idé. Vil gerne høre mere\r\n                                                            om hvad budgettet for sådan et projekt er?\r\n                                                        </p></li>\r\n                                                    <li class=\"list-group-item bg-transparent mb-0 pb-0 mt-2\"><h6 class=\"text-primary mb-0\">\r\n                                                            GII <small class=\"text-muted\" style=\"font-size: 0.8rem;\"> For 1 dag siden</small></h6>\r\n                                                        <p>Jeg har arbejdet med fjernvarme før og kender nogle der ved en masse om hvordan man opsætter en varmeveksler.</p></li>\r\n                                                    <li class=\"list-group-item bg-transparent mb-0 pb-0 mt-2\"><h6 class=\"text-primary mb-0\">\r\n                                                            KØL <small class=\"text-muted\" style=\"font-size: 0.8rem;\"> For 1 dag siden</small></h6>\r\n                                                        <p>\r\n                                                            Et spændende forslag HFU.\r\n                                                        </p></li></ul></div></div></div></div></div></div>\r\n                        ");
            __builder.AddMarkupContent(29, @"<tr title=""Klik for at læse mere"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal2""><td>Teambuilding efter Corona</td>
                            <td>Aalborg Portland</td>
                            <td>HR</td>
                            <td class=""text-success"">Godkendt</td>
                            <td>Lav</td>
                            <td>29/09/21</td></tr>
                        
                        ");
            __builder.AddMarkupContent(30, "<div class=\"modal fade\" id=\"exampleModal2\" tabindex=\"-1\" aria-labelledby=\"exampleModalLabel2\" aria-hidden=\"true\"><div class=\"modal-dialog modal-dialog-scrollable  modal-xl\"><div class=\"modal-content rounded-cos border-0\"><div class=\"modal-header bg-primary text-white\" style=\"border-radius: 11px 11px 0px 0px;\"><h5 class=\"modal-title\">Teambuilding efter Corona</h5>\r\n                                        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button></div>\r\n                                    <div class=\"modal-body bg-light\"><div class=\"row g-2\"><div class=\"row g-2\"><div class=\"col-12\"><div class=\"row mx-1\"><div class=\"col\"><h6>Initialer</h6>\r\n                                                            <p>MTE</p></div>\r\n                                                        <div class=\"col\"><h6>Forretningsenhed</h6>\r\n                                                            <p> Aalborg Portland</p></div>\r\n                                                        <div class=\"col\"><h6>Afdeling</h6>\r\n                                                            <p>HR</p></div>\r\n                                                        <div class=\"col\"><h6>Prioritet</h6>\r\n                                                            <p>Lav</p></div>\r\n                                                        <div class=\"col\"><h6>Dato</h6>\r\n                                                            <p>29/09/21</p></div>\r\n                                                        <div class=\"col\"><h6>Status</h6>\r\n                                                            <p class=\"text-success\">Godkendt</p></div></div></div>\r\n                                                <div class=\"col-12\"><div class=\"card\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Idébeskrivelse\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                Da vi har fået mange nye kolleger og har arbejdet meget hjemme under corona,\r\n                                                                kunne det være dejligt med noget teambuilding. Men vi mangler idéer til aktiviteter.\r\n                                                                Hvis i har nogle idéer, må i meget gerne skrive dem i kommentersporet. På forhånd tak.\r\n                                                            </p></div></div></div>\r\n                                                <div class=\"col-6\"><div class=\"card\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Risiko\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                Det kan være svært at finde et tidspunkt i kalenderen hvor alle har fri.\r\n                                                                Men hvis vi bare planlægger i god tid skal det nok gå.\r\n                                                            </p></div></div></div>\r\n                                                <div class=\"col-6\"><div class=\"card\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Plan\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                Efter vi har fået nogle gode forslag vil HR-afdelingen begynde at planlægge.\r\n                                                            </p></div></div></div>\r\n                                                <div class=\"col-6\"><div class=\"card\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Forventet resultat\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                Lær alle dine nye kollegaer at kende.\r\n                                                            </p></div></div></div>\r\n                                                <div class=\"col-6\"><div class=\"card h-100\"><div class=\"card-body\"><h5 class=\"card-title mb-2 text-muted\" style=\"margin-top: -0.5rem;\">\r\n                                                                Team\r\n                                                            </h5>\r\n                                                            <p class=\"card-text\">\r\n                                                                -\r\n                                                            </p></div></div></div></div></div>\r\n                                        <div class=\"p-2 my-3 bg-light rounded-cos\"><div class=\"container-fluid\"><h3 class=\"my-2\">Kommentarspor</h3>\r\n                                                <div class=\"d-flex flex-row mb-2\"><textarea type=\"text\" class=\"form-control rounded-cos my-1\" id=\"initials\" placeholder=\"Skriv din kommentar her\"></textarea>\r\n                                                    <div><input type=\"text\" class=\"form-control mx-2 my-1 rounded-cos\" id=\"initials\" maxlength=\"4\" placeholder=\"Initialer\">\r\n                                                        <button class=\"btn btn-primary mx-2 my-1 rounded-cos w-100\" type=\"button\">\r\n                                                            Kommenter\r\n                                                        </button></div></div>\r\n                                                <ul class=\"list-group list-group-flush\"><li class=\"list-group-item bg-transparent mb-0 pb-0 mt-2\"><h6 class=\"text-primary mb-0\">\r\n                                                            HBH <small class=\"text-muted\" style=\"font-size: 0.8rem;\">\r\n                                                                For 20 timer\r\n                                                                siden\r\n                                                            </small></h6>\r\n                                                        <p>\r\n                                                            Vi i HR er vild med idéen!\r\n                                                        </p></li>\r\n                                                    <li class=\"list-group-item bg-transparent mb-0 pb-0 mt-2\"><h6 class=\"text-primary mb-0\">\r\n                                                            GII <small class=\"text-muted\" style=\"font-size: 0.8rem;\"> For 1 dag siden</small></h6>\r\n                                                        <p>Minigolf.</p></li>\r\n                                                    <li class=\"list-group-item bg-transparent mb-0 pb-0 mt-2\"><h6 class=\"text-primary mb-0\">\r\n                                                            KÅL <small class=\"text-muted\" style=\"font-size: 0.8rem;\"> For 2 dag siden</small></h6>\r\n                                                        <p>\r\n                                                            Vi kan spille petanque og stangtennis!\r\n                                                        </p></li>\r\n                                                    <li class=\"list-group-item bg-transparent mb-0 pb-0 mt-2\"><h6 class=\"text-primary mb-0\">\r\n                                                            KÅL <small class=\"text-muted\" style=\"font-size: 0.8rem;\"> For 2 dag siden</small></h6>\r\n                                                        <p>\r\n                                                            Der er \"Et problematisk puslespil\". Formålet med denne øvelse er, at deltagerne bliver bevidste om samarbejdets betydning i en gruppe. Specifikt er målet at skærpe opmærksomheden på hinandens arbejdsprocesser, og værdien i både at give og modtage. Øvelsen tager ca. 45 minutter og fungerer bedst til under 20 personer.\r\n                                                        </p></li></ul></div></div></div></div></div></div>\r\n                        ");
            __builder.AddMarkupContent(31, @"<tr title=""Klik for at læse mere""><td>Tracking af cementproduktion gennem IOT devices</td>
                            <td>Unicon NO</td>
                            <td>SCM</td>
                            <td>Oprettet</td>
                            <td>Høj</td>
                            <td>24/09/21</td></tr>
                        ");
            __builder.AddMarkupContent(32, @"<tr title=""Klik for at læse mere""><td>Ret robotproduktion</td>
                            <td>Kudsk og Dahl</td>
                            <td>Produktion</td>
                            <td class=""text-danger"">Afvist</td>
                            <td>Middel</td>
                            <td>19/09/21</td></tr>
                        ");
            __builder.AddMarkupContent(33, @"<tr title=""Klik for at læse mere""><td>Miljørigtig cementproduktion</td>
                            <td>Unicon NO</td>
                            <td>Vedligehold</td>
                            <td>Oprettet</td>
                            <td>Lav</td>
                            <td>09/09/21</td></tr>
                        ");
            __builder.AddMarkupContent(34, @"<tr title=""Klik for at læse mere""><td>Optimering af pausefordeling</td>
                            <td>Unicon DK</td>
                            <td>PMO & Transformation</td>
                            <td class=""text-success"">Godkendt</td>
                            <td>Middel</td>
                            <td>20/08/21</td></tr>
                        ");
            __builder.AddMarkupContent(35, @"<tr title=""Klik for at læse mere""><td>Forbedring af varmeovn</td>
                            <td>Unicon DK</td>
                            <td>Vedligehold</td>
                            <td>Oprettet</td>
                            <td>Middel</td>
                            <td>14/08/21</td></tr>
                        ");
            __builder.AddMarkupContent(36, @"<tr title=""Klik for at læse mere""><td>Return Concrete NO</td>
                            <td>Unicon NO</td>
                            <td>Produktion</td>
                            <td class=""text-success"">Godkendt</td>
                            <td>Høj</td>
                            <td>13/08/21</td></tr>
                        ");
            __builder.AddMarkupContent(37, @"<tr title=""Klik for at læse mere""><td>Facility Management</td>
                            <td>Aalborg Portland</td>
                            <td>PMO & Transformation</td>
                            <td>Oprettet</td>
                            <td>Høj</td>
                            <td>24/09/21</td></tr>
                        ");
            __builder.AddMarkupContent(38, @"<tr title=""Klik for at læse mere""><td>GAS - plan for usage and BC</td>
                            <td>Kudsk og Dahl</td>
                            <td>Produktion</td>
                            <td class=""text-danger"">Afvist</td>
                            <td>Middel</td>
                            <td>19/09/21</td></tr>
                        ");
            __builder.AddMarkupContent(39, @"<tr title=""Klik for at læse mere""><td>Prøveudtagning</td>
                            <td>Unicon NO</td>
                            <td>Vedligehold</td>
                            <td>Oprettet</td>
                            <td>Lav</td>
                            <td>09/09/21</td></tr>
                        ");
            __builder.AddMarkupContent(40, @"<tr title=""Klik for at læse mere""><td>Inventory Management</td>
                            <td>Unicon NO</td>
                            <td>Vedligehold</td>
                            <td class=""text-success"">Godkendt</td>
                            <td>Middel</td>
                            <td>20/08/21</td></tr>
                        ");
            __builder.AddMarkupContent(41, @"<tr title=""Klik for at læse mere""><td>AP Warehouse: Repair flow spareparts (SAP warehouse)</td>
                            <td>Aalborg Portland</td>
                            <td>Vedligehold</td>
                            <td>Oprettet</td>
                            <td>Middel</td>
                            <td>14/08/21</td></tr>
                        ");
            __builder.AddMarkupContent(42, @"<tr title=""Klik for at læse mere""><td>AP Warehouse: Change Warehouse setup in SAP</td>
                            <td>Aalborg Portland</td>
                            <td>Produktion</td>
                            <td class=""text-success"">Godkendt</td>
                            <td>Høj</td>
                            <td>13/08/21</td></tr>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\JFL\Documents\GitHub\Idea-bank-for-AAportland-P3AAU\IdeaBank\IdeaBank\Pages\Index.razor"
                               
                            private IdeaBank.Pages.Modal Modal { get; set; }
                        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
