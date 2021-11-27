﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.NovoRisco;
using SGAR.Dto.NR12100;
using SGAR.WebApi.ViewModel.NR12100;
using System;
using System.Collections.Generic;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NovoRiscoController : ControllerBase
    {
        private readonly NovoRiscoBll _novoRiscoBll;
        private readonly IMapper _mapper;

        public NovoRiscoController(NovoRiscoBll novoRiscoBll, IMapper mapper)
        {
            _novoRiscoBll = novoRiscoBll;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/BuscarCicloVida")]
        public ActionResult<List<CicloVidaViewModel>> BuscarCicloVida()
        {
            try
            {
                return _mapper.Map<List<CicloVidaDto>, List<CicloVidaViewModel>>(_novoRiscoBll.BuscarCicloVida());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}