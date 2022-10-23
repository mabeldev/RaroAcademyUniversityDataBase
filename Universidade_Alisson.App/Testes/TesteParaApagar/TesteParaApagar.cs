using Universidade.Context;
using Universidade.Enuns;
using Universidade.Interfaces;
using Universidade.Models;
using Universidade.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Universidade.Extensoes;

namespace Testes;

[TestClass]
public class TesteParaApagar
{
    public readonly IAlunoRepositorio _alunoRepositorio;
    public readonly ICursoDisciplinaRepositorio _cursoDisciplinaRepositorio;
    public readonly ICursoRepositorio _cursoRepositorio;
    public readonly IDepartamentoRepositorio _departamentoRepositorio;
    public readonly IDependenteRepositorio _dependenteRepositorio;
    public readonly IDisciplinaRepositorio _disciplinaRepositorio;
    public readonly IEnderecoRepositorio _enderecoRepositorio;
    public readonly IOfertaRepositorio _ofertaRepositorio;
    public readonly IProfessorRepositorio _professorRepositorio;
    public readonly ITitulacaoRepositorio _titulacaoRepositorio;
    public readonly DateTime _dataAlteracao = DateTime.Now;   

    public TesteParaApagar()
    {
        _alunoRepositorio = InjectionDependency.Provider().GetService<IAlunoRepositorio>();
        _cursoRepositorio = InjectionDependency.Provider().GetService<ICursoRepositorio>();
        _cursoDisciplinaRepositorio = InjectionDependency.Provider().GetService<ICursoDisciplinaRepositorio>();
        _departamentoRepositorio = InjectionDependency.Provider().GetService<IDepartamentoRepositorio>();
        _dependenteRepositorio = InjectionDependency.Provider().GetService<IDependenteRepositorio>();
        _disciplinaRepositorio = InjectionDependency.Provider().GetService<IDisciplinaRepositorio>();
        _enderecoRepositorio = InjectionDependency.Provider().GetService<IEnderecoRepositorio>();
        _ofertaRepositorio = InjectionDependency.Provider().GetService<IOfertaRepositorio>();
        _professorRepositorio = InjectionDependency.Provider().GetService<IProfessorRepositorio>();
        _titulacaoRepositorio = InjectionDependency.Provider().GetService<ITitulacaoRepositorio>();
    }

    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarAlunoPorTeste(int id, bool ativo)
    {
       var aluno = await _alunoRepositorio.BuscarPorId(id);

       aluno.Ativo = ativo;
       aluno.DataAlteracao = _dataAlteracao;

       await _alunoRepositorio.AlterarAsync(aluno);

       var alunoAlterado = await _alunoRepositorio.BuscarPorId(id);
       Assert.AreEqual(aluno.Ativo, alunoAlterado.Ativo);
    }

    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarCursoTeste(int id, bool ativo)
    {
       var curso = await _cursoRepositorio.BuscarPorId(id);

       curso.Ativo = ativo;
       curso.DataAlteracao = _dataAlteracao;

       await _cursoRepositorio.AlterarAsync(curso);

       var cursoAlterado = await _cursoRepositorio.BuscarPorId(id);
       Assert.AreEqual(curso.Ativo, cursoAlterado.Ativo);
    }

    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarCursoDisciplinaTeste(int id, bool ativo)
    {
       var cursoDisciplina = await _cursoDisciplinaRepositorio.BuscarPorId(id);

       cursoDisciplina.Ativo = ativo;
       cursoDisciplina.DataAlteracao = _dataAlteracao;

       await _cursoDisciplinaRepositorio.AlterarAsync(cursoDisciplina);

       var cursoDisciplinaAlterado = await _cursoDisciplinaRepositorio.BuscarPorId(id);
       Assert.AreEqual(cursoDisciplina.Ativo, cursoDisciplinaAlterado.Ativo);
    }
    
    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarDepartamentoTeste(int id, bool ativo)
    {
       var departamento = await _departamentoRepositorio.BuscarPorId(id);

       departamento.Ativo = ativo;
       departamento.DataAlteracao = _dataAlteracao;

       await _departamentoRepositorio.AlterarAsync(departamento);

       var departamentoAlterado = await _departamentoRepositorio.BuscarPorId(id);
       Assert.AreEqual(departamento.Ativo, departamentoAlterado.Ativo);
    }

    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarDependenteTeste(int id, bool ativo)
    {
       var dependente = await _dependenteRepositorio.BuscarPorId(id);

       dependente.Ativo = ativo;
       dependente.DataAlteracao = _dataAlteracao;

       await _dependenteRepositorio.AlterarAsync(dependente);

       var dependenteAlterado = await _dependenteRepositorio.BuscarPorId(id);
       Assert.AreEqual(dependente.Ativo, dependenteAlterado.Ativo);
    }

    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarDisciplinaTeste(int id, bool ativo)
    {
       var disciplina = await _disciplinaRepositorio.BuscarPorId(id);

       disciplina.Ativo = ativo;
       disciplina.DataAlteracao = _dataAlteracao;

       await _disciplinaRepositorio.AlterarAsync(disciplina);

       var disciplinaAlterado = await _disciplinaRepositorio.BuscarPorId(id);
       Assert.AreEqual(disciplina.Ativo, disciplinaAlterado.Ativo);
    }
    
    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarEnderecoTeste(int id, bool ativo)
    {
       var endereco = await _enderecoRepositorio.BuscarPorId(id);

       endereco.Ativo = ativo;
       endereco.DataAlteracao = _dataAlteracao;

       await _enderecoRepositorio.AlterarAsync(endereco);

       var enderecoAlterado = await _enderecoRepositorio.BuscarPorId(id);
       Assert.AreEqual(endereco.Ativo, enderecoAlterado.Ativo);
    }

    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarOfertaTeste(int id, bool ativo)
    {
       var oferta = await _ofertaRepositorio.BuscarPorId(id);

       oferta.Ativo = ativo;
       oferta.DataAlteracao = _dataAlteracao;

       await _ofertaRepositorio.AlterarAsync(oferta);

       var ofertaAlterado = await _ofertaRepositorio.BuscarPorId(id);
       Assert.AreEqual(oferta.Ativo, ofertaAlterado.Ativo);
    }

    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    public async Task AlterarTitulacaoTeste(int id, bool ativo)
    {
       var titulacao = await _titulacaoRepositorio.BuscarPorId(id);

       titulacao.Ativo = ativo;
       titulacao.DataAlteracao = _dataAlteracao;

       await _titulacaoRepositorio.AlterarAsync(titulacao);

       var titulacaoAlterado = await _titulacaoRepositorio.BuscarPorId(id);
       Assert.AreEqual(titulacao.Ativo, titulacaoAlterado.Ativo);
    }

}