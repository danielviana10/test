using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mercadinho.DataBase;
using Mercadinho.Models;

namespace Mercadinho.Controllers
{
    public class PedidoController : Controller
    {

        private MercadinhoContext _context;

        private static IList<Item> _listaItens = new List<Item>();


        public PedidoController(MercadinhoContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            _listaItens = _context.Itens.ToList();
            ViewBag.Pedido = new Pedido();

            return View(_listaItens);
        }


        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Pedido pedido, int ItemId)
        {

            ItemController ItemValorPesquisa = new ItemController(_context);
            

            pedido.DataPedido = DateTime.Now;
            pedido.FkItemId =  ItemId;

            // Valor
            pedido.valorPedido = ItemValorPesquisa.PesquisaValor(ItemId);

            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            TempData["mensagem"] = "Pedido cadastrado!";

            return RedirectToAction("Index");

        }
    }
}
