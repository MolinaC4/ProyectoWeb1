using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoWeb1.Data;
using ProyectoWeb1.Models;
using ProyectoWeb1.Models.Domain;

namespace ProyectoWeb1.Controllers
{
    public class MedicosController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public MedicosController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var medico = await mvcDemoDbContext.Medicos.ToListAsync();
            return View(medico);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMedicoViewModel addMedicoRequest)
        {
            var medico = new Medico()
            {
                Id = Guid.NewGuid(),
                Nombre = addMedicoRequest.Nombre,
                Ced = addMedicoRequest.Ced,
                Correo = addMedicoRequest.Correo,
                Pais = addMedicoRequest.Pais,
                Provincia = addMedicoRequest.Provincia
            };
            await mvcDemoDbContext.Medicos.AddAsync(medico);
            await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
