using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TergusWEB.Data;
using TergusWEB.Models;

namespace TergusWEB.Controllers
{
    public class ClientesController : Controller
    {
        private readonly TergusWEBContext _context;

        public ClientesController(TergusWEBContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cliente.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> DetailsPF(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> DetailsPJ(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }


        // GET: Clientes/CreatePF
        public IActionResult CreatePF()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePF([Bind("Id,Nome_Razao_Social,Cpf_CNPJ,Rg_IE,Data_da_expedicao,Afiliacao1,Afiliacao2,Naturalidade_cidade,Naturalidade_estado,Data_de_nascimento,Cep,Endereco,Numero,Bairro,Cidade,Estado,Complemento,Data_do_cadastro,Status,Observacao,Telefone_1,Telefone_2,Telefone_3,Email")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/CreatePJ
        public IActionResult CreatePJ()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePJ([Bind("Id,Nome_Razao_Social,Cpf_CNPJ,Rg_IE,Cep,Endereco,Numero,Bairro,Cidade,Estado,Complemento,Data_do_cadastro,Status,Observacao,Telefone_1,Telefone_2,Telefone_3,Email,Nome_Fantasia,Inscricao_Municipal,Site,Cliente_Juridico,")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }


        // GET: Clientes/EditPF/5
        public async Task<IActionResult> EditPF(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPF(int id, [Bind("Id,Nome_Razao_Social,Cpf_CNPJ,Rg_IE,Data_da_expedicao,Afiliacao1,Afiliacao2,Naturalidade_cidade,Naturalidade_estado,Data_de_nascimento,Cep,Endereco,Numero,Bairro,Cidade,Estado,Complemento,Data_do_cadastro,Status,Observacao,Telefone_1,Telefone_2,Telefone_3,Email")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/EditPJ/5
        public async Task<IActionResult> EditPJ(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPJ(int id, [Bind("Id,Nome_Razao_Social,Cpf_CNPJ,Rg_IE,Cep,Endereco,Numero,Bairro,Cidade,Estado,Complemento,Data_do_cadastro,Status,Observacao,Telefone_1,Telefone_2,Telefone_3,Email,Nome_Fantasia,Inscricao_Municipal,Site,Cliente_Juridico")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.Id == id);
        }
    }
}
