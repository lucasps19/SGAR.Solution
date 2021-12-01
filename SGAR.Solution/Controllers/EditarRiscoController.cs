using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.EditarRisco;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EditarRiscoController : Controller
    {
        private readonly EditarRiscoBll _editarRiscoBll;
        private readonly IMapper _mapper;

        public EditarRiscoController(EditarRiscoBll editarRiscoBll, IMapper mapper)
        {
            _editarRiscoBll = editarRiscoBll;
            _mapper = mapper;
        }
    }
}
