using AutoMapper;
using SGAR.Dal.CadastroUsuarios;
using SGAR.Dto.Empresa;
using SGAR.Dto.Pessoa;
using SGAR.Model.Models;
using System.Collections.Generic;

namespace SGAR.Bll.CadastroUsuarios
{
    public class CadastroUsuarioBll
    {
        private readonly CadastroUsuarioDal _cadastroUsuarioDal;
        private readonly IMapper _mapper;

        public CadastroUsuarioBll(CadastroUsuarioDal cadastroUsuarioDal, IMapper mapper)
        {
            _cadastroUsuarioDal = cadastroUsuarioDal;
            _mapper = mapper;
        }

        public void CadastrarUsuario(PessoaDTO pessoa)
        {
            if (_cadastroUsuarioDal.VerificarCpfJaCadastrado(pessoa.CPF))
            {
                if (_cadastroUsuarioDal.VerificarEmailJaCadastrado(pessoa.Email))
                {
                    _cadastroUsuarioDal.CadastrarUsuario(_mapper.Map<PessoaDTO, Pessoa>(pessoa));
                }
            }
        }

        public List<EmpresaDto> BuscarEmpresasCadastradas()
        {
            return _mapper.Map<List<Empresa>, List<EmpresaDto>>(_cadastroUsuarioDal.BuscarEmpresasCadastradas());
        }
    }
}