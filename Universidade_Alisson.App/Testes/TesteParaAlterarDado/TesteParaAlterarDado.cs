using Universidade.Context;
using Universidade.Enuns;
using Universidade.Interfaces;
using Universidade.Models;
using Universidade.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Universidade.Extensoes;

namespace Testes;

[TestClass]
public class TesteParaAlterarDado
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

    public TesteParaAlterarDado()
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
    [DataRow(1, "Nome Alterado")]
    public async Task AlterarAlunoPorTeste(int id, string nome)
    {
       var aluno = await _alunoRepositorio.BuscarPorId(id);

       aluno.Nome = nome;
       aluno.DataAlteracao = _dataAlteracao;

       await _alunoRepositorio.AlterarAsync(aluno);

       var alunoAlterado = await _alunoRepositorio.BuscarPorId(id);
       Assert.AreEqual(aluno.Nome, alunoAlterado.Nome);
    }

    [TestMethod]
    [DataRow(1, "Nome Alterado")]
    public async Task AlterarCursoTeste(int id, string nome)
    {
       var curso = await _cursoRepositorio.BuscarPorId(id);

       curso.Nome = nome;
       curso.DataAlteracao = _dataAlteracao;

       await _cursoRepositorio.AlterarAsync(curso);

       var cursoAlterado = await _cursoRepositorio.BuscarPorId(id);
       Assert.AreEqual(curso.Nome, cursoAlterado.Nome);
    }

    // Teste para CursoDisciplina não necessário pois não tem atributos que não sejam FK
    
    [TestMethod]
    [DataRow(1, "Nome Alterado")]
    public async Task AlterarDepartamentoTeste(int id, string nome)
    {
       var departamento = await _departamentoRepositorio.BuscarPorId(id);

       departamento.Nome = nome;
       departamento.DataAlteracao = _dataAlteracao;

       await _departamentoRepositorio.AlterarAsync(departamento);

       var departamentoAlterado = await _departamentoRepositorio.BuscarPorId(id);
       Assert.AreEqual(departamento.Nome, departamentoAlterado.Nome);
    }

    [TestMethod]
    [DataRow(1, "Nome Alterado")]
    public async Task AlterarDependenteTeste(int id, string nome)
    {
       var dependente = await _dependenteRepositorio.BuscarPorId(id);

       dependente.Nome = nome;
       dependente.DataAlteracao = _dataAlteracao;

       await _dependenteRepositorio.AlterarAsync(dependente);

       var dependenteAlterado = await _dependenteRepositorio.BuscarPorId(id);
       Assert.AreEqual(dependente.Nome, dependenteAlterado.Nome);
    }

    [TestMethod]
    [DataRow(1, "Nome Alterado")]
    public async Task AlterarDisciplinaTeste(int id, string nome)
    {
       var disciplina = await _disciplinaRepositorio.BuscarPorId(id);

       disciplina.Nome = nome;
       disciplina.DataAlteracao = _dataAlteracao;

       await _disciplinaRepositorio.AlterarAsync(disciplina);

       var disciplinaAlterado = await _disciplinaRepositorio.BuscarPorId(id);
       Assert.AreEqual(disciplina.Nome, disciplinaAlterado.Nome);
    }
    
    [TestMethod]
    [DataRow(1, "Nome Alterado")]
    public async Task AlterarEnderecoTeste(int id, string rua)
    {
       var endereco = await _enderecoRepositorio.BuscarPorId(id);

       endereco.Rua = rua;
       endereco.DataAlteracao = _dataAlteracao;

       await _enderecoRepositorio.AlterarAsync(endereco);

       var enderecoAlterado = await _enderecoRepositorio.BuscarPorId(id);
       Assert.AreEqual(endereco.Rua, enderecoAlterado.Rua);
    }

    
    [TestMethod]
    [DataRow(1)]
    public async Task AlterarOfertaTeste(int id)
    {
       var oferta = await _ofertaRepositorio.BuscarPorId(id);

       oferta.Ano = $"{id+100}";
       oferta.DataAlteracao = _dataAlteracao;

       await _ofertaRepositorio.AlterarAsync(oferta);

       var ofertaAlterado = await _ofertaRepositorio.BuscarPorId(id);
       Assert.AreEqual(oferta.Ano, ofertaAlterado.Ano);
    }

    [TestMethod]
    [DataRow(1, "Grau Alterado")]
    public async Task AlterarTitulacaoTeste(int id, string grau)
    {
       var titulacao = await _titulacaoRepositorio.BuscarPorId(id);

       titulacao.Grau = grau;
       titulacao.DataAlteracao = _dataAlteracao;

       await _titulacaoRepositorio.AlterarAsync(titulacao);

       var titulacaoAlterado = await _titulacaoRepositorio.BuscarPorId(id);
       Assert.AreEqual(titulacao.Grau, titulacaoAlterado.Grau);
    }

}