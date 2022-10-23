using Universidade.Context;
using Universidade.Enuns;
using Universidade.Interfaces;
using Universidade.Models;
using Universidade.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Universidade.Extensoes;

namespace Testes;

[TestClass]
public class TesteParaBuscar
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

    public TesteParaBuscar()
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
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarAlunoPorIdTest(int id)
    {
       var aluno = await _alunoRepositorio.BuscarPorId(id);
       Assert.IsNotNull(aluno.Id);
       Assert.AreEqual(id, aluno.Id);
    }

    [TestMethod]
    public async Task BuscarTodosAlunosTest()
    {
       var aluno = await _alunoRepositorio.BuscarTodos();
       Assert.IsTrue(aluno.Count > 0);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarCursoDisciplinaPorIdTest(int id)
    {
       var cursoDisciplina = await _cursoDisciplinaRepositorio.BuscarPorId(id);
       Assert.IsNotNull(cursoDisciplina.Id);
       Assert.AreEqual(id, cursoDisciplina.Id);
    }

    [TestMethod]
    public async Task BuscarTodosCursosDisciplinaTest()
    {
       var cursoDisciplina = await _cursoDisciplinaRepositorio.BuscarTodos();
       Assert.IsTrue(cursoDisciplina.Count > 0);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarCursoPorIdTest(int id)
    {
       var curso = await _cursoRepositorio.BuscarPorId(id);
       Assert.IsNotNull(curso.Id);
       Assert.AreEqual(id, curso.Id);
    }

    [TestMethod]
    public async Task BuscarTodosCursosTest()
    {
       var curso = await _cursoRepositorio.BuscarTodos();
       Assert.IsTrue(curso.Count > 0);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarDepartamentoPorIdTest(int id)
    {
       var departamento = await _departamentoRepositorio.BuscarPorId(id);
       Assert.IsNotNull(departamento.Id);
       Assert.AreEqual(id, departamento.Id);
    }

    [TestMethod]
    public async Task BuscarTodosDepartamentoTest()
    {
       var departamento = await _departamentoRepositorio.BuscarTodos();
       Assert.IsTrue(departamento.Count > 0);
    }
    
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarDependentePorIdTest(int id)
    {
       var dependente = await _dependenteRepositorio.BuscarPorId(id);
       Assert.IsNotNull(dependente.Id);
       Assert.AreEqual(id, dependente.Id);
    }

    [TestMethod]
    public async Task BuscarTodosDependenteTest()
    {
       var dependente = await _dependenteRepositorio.BuscarTodos();
       Assert.IsTrue(dependente.Count > 0);
    }
    
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarDisciplinaPorIdTest(int id)
    {
       var disciplina = await _disciplinaRepositorio.BuscarPorId(id);
       Assert.IsNotNull(disciplina.Id);
       Assert.AreEqual(id, disciplina.Id);
    }

    [TestMethod]
    public async Task BuscarTodosDisciplinaTest()
    {
       var disciplina = await _disciplinaRepositorio.BuscarTodos();
       Assert.IsTrue(disciplina.Count > 0);
    }
    
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarEnderecoPorIdTest(int id)
    {
       var endereco = await _enderecoRepositorio.BuscarPorId(id);
       Assert.IsNotNull(endereco.Id);
       Assert.AreEqual(id, endereco.Id);
    }

    [TestMethod]
    public async Task BuscarTodosEnderecoTest()
    {
       var endereco = await _enderecoRepositorio.BuscarTodos();
       Assert.IsTrue(endereco.Count > 0);
    }
    
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarOfertaPorIdTest(int id)
    {
       var oferta = await _ofertaRepositorio.BuscarPorId(id);
       Assert.IsNotNull(oferta.Id);
       Assert.AreEqual(id, oferta.Id);
    }

    [TestMethod]
    public async Task BuscarTodosOfertaTest()
    {
       var oferta = await _ofertaRepositorio.BuscarTodos();
       Assert.IsTrue(oferta.Count > 0);
    }
    
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarProfessorPorIdTest(int id)
    {
       var professor = await _professorRepositorio.BuscarPorId(id);
       Assert.IsNotNull(professor.Id);
       Assert.AreEqual(id, professor.Id);
    }

    [TestMethod]
    public async Task BuscarTodosProfessorTest()
    {
       var professor = await _professorRepositorio.BuscarTodos();
       Assert.IsTrue(professor.Count > 0);
    }
    
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public async Task BuscarTitulacaoPorIdTest(int id)
    {
       var titulacao = await _titulacaoRepositorio.BuscarPorId(id);
       Assert.IsNotNull(titulacao.Id);
       Assert.AreEqual(id, titulacao.Id);
    }

    [TestMethod]
    public async Task BuscarTodosTitulacaoTest()
    {
       var titulacao = await _titulacaoRepositorio.BuscarTodos();
       Assert.IsTrue(titulacao.Count > 0);
    }

}