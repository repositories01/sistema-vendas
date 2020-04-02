#pragma checksum "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e03787e9ae0f1a887dbb90f236c75eaa6026fd2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
#line 1 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\_ViewImports.cshtml"
using SistemaVendas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\_ViewImports.cshtml"
using SistemaVendas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e03787e9ae0f1a887dbb90f236c75eaa6026fd2b", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c82d9cea325684eeeaf0450c735c45ad27ec96", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Listagem de Produtos</h3>\r\n\r\n\r\n<table class=\"table table-bordered\">\r\n<thead>\r\n<tr>\r\n<th>Id</th>\r\n<th>Nome</th>\r\n<th>Preço Unitario</th>\r\n<th>Quantidade Estoque</th>\r\n<th>Unidade de Medida</th>\r\n<th>Foto</th>\r\n\r\n\r\n</tr>\r\n\r\n\r\n</thead>\r\n\r\n<tbody>\r\n");
#nullable restore
#line 22 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
      
        foreach(var item in(List<ProdutoModel>) ViewBag.ListaProdutos){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 415, "\"", 441, 3);
            WriteAttributeValue("", 425, "Editar(", 425, 7, true);
#nullable restore
#line 25 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
WriteAttributeValue("", 432, item.Id, 432, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 440, ")", 440, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button></td>\r\n                                <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 546, "\"", 573, 3);
            WriteAttributeValue("", 556, "Excluir(", 556, 8, true);
#nullable restore
#line 26 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
WriteAttributeValue("", 564, item.Id, 564, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 572, ")", 572, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button></td>\r\n\r\n               <td>");
#nullable restore
#line 28 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 29 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
              Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>      \r\n               <td>");
#nullable restore
#line 30 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
              Write(item.Preco_Unitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 31 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
              Write(item.Quantidade_Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 32 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
              Write(item.Unidade_Medida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td><img");
            BeginWriteAttribute("src", " src=\"", 841, "\"", 862, 1);
#nullable restore
#line 33 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
WriteAttributeValue("", 847, item.Link_Foto, 847, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"150\" weight=\"150\"></td>\r\n               \r\n\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Thiag\Documents\projetos\sistema-vendas\Views\Produto\Index.cshtml"
            
            
            }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

</tbody>


</table>

<button class=""btn btn-block btn-primary"" type=""button"" onclick=""Cadastrar()"">Cadastrar</button>


<script>

    funcion Cadastrar(){
        window.location.href=""../Produto/Cadastro"";
    }


    function Editar(id){
        window.location.href=""../Produto/Editar"" + id;

    }

      function Excluir(id){
        window.location.href=""../Produto/Excluir"" + id;

    }
</script>");
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
