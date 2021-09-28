using SGAR.Dal.CadastroUsuarios;
using SGAR.Dto.Empresa;
using SGAR.Dto.Pessoa;
using SGAR.Model.Models;
using System;
using System.Collections.Generic;

namespace SGAR.Bll.CadastroUsuarios
{
    public class CadastroUsuarioBll
    {
        private readonly CadastroUsuarioDal _cadastroUsuarioDal;

        public CadastroUsuarioBll(CadastroUsuarioDal cadastroUsuarioDal)
        {
            _cadastroUsuarioDal = cadastroUsuarioDal;
        }

        public void CadastrarUsuario(PessoaDTO pessoa)
        {
            if (_cadastroUsuarioDal.VerificarCpfJaCadastrado(pessoa.CPF))
            {
                if (_cadastroUsuarioDal.VerificarEmailJaCadastrado(pessoa.Email))
                {
                    _cadastroUsuarioDal.CadastrarUsuario(pessoa);
                }
            }
        }

        public List<EmpresaDto> BuscarEmpresasCadastradas()
        {
            //List<EmpresaDto> listaEmpresasCadastradas = _cadastroUsuarioDal.BuscarEmpresasCadastradas();

            return null;
        }
    }
}