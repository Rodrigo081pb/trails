using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_OBG_COUSER_AV.Classes;

namespace WEB_OBG_COUSER_AV
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // vincular a lista de produtos ao gridview
                gridProduto.DataSource = ObterProdutos();
                gridProduto.DataBind();
            }

        }

        // Adicionando uma ação ao botão de enviar
        protected void btnEnvio_Click(object sender, EventArgs e)
        {
            string nomeUsuario = name.Text;
            string cidadeUsuario = ddlCidades.SelectedValue;

            labelEnviadoName.Text = $"Olá {nomeUsuario}";

            labelEnviadoCidade.Text = $"Você mora em {cidadeUsuario}";

        }

        private List<Produto> ObterProdutos()
        {
            return new List<Produto>
            {
                new Produto { Id = 1, Nome = "Teclado", Preco = 10.00 },
                new Produto { Id = 2, Nome = "Mouse", Preco = 20.00},
                new Produto { Id = 3, Nome = "Cadeira", Preco = 30.00 }
            };
        }

    }
}