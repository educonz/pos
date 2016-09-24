using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exercicio.Models;
using Exercicio.CorreiosReference;

namespace Exercicio.Controllers
{
    public class CalcPrecoPrazoesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: CalcPrecoPrazoes
        public ActionResult Index()
        {
            return View(db.CalcPrecoPrazo.ToList());
        }

        
        // GET: CalcPrecoPrazoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalcPrecoPrazoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CdEmpresa,DsSenha,CdServico,CepOrigem,CepDestino,VlPeso,CdFormato,VlComprimento,VlAltura,VlLargura,VlDiametro,CdMaoPropria,VlValorDeclarado,CdAvisoRecebimento")] CalcPrecoPrazo calcPrecoPrazo)
        {
            if (ModelState.IsValid)
            {
                CalcPrecoPrazoWSSoapClient c = new CalcPrecoPrazoWSSoapClient();
                
                try
                {
                   var resultado = c.CalcPrecoPrazo(calcPrecoPrazo.CdEmpresa, calcPrecoPrazo.DsSenha, calcPrecoPrazo.CdServico, calcPrecoPrazo.CepOrigem, calcPrecoPrazo.CepDestino, calcPrecoPrazo.VlPeso, calcPrecoPrazo.CdFormato, calcPrecoPrazo.VlComprimento, calcPrecoPrazo.VlAltura, calcPrecoPrazo.VlLargura, calcPrecoPrazo.VlDiametro, calcPrecoPrazo.CdMaoPropria, calcPrecoPrazo.VlValorDeclarado, calcPrecoPrazo.CdAvisoRecebimento);
                }
                catch (Exception ex)
                {
                    
                }

                return RedirectToAction("Index");
            }

            return View(calcPrecoPrazo);
        }
   }
}
