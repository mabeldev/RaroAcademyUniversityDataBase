using Universidade.Context;
using Universidade.Enuns;
using Universidade.Interfaces;
using Universidade.Models;
using Universidade.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Universidade.Extensoes;

namespace Testes;

[TestClass]
public class TesteParaPopular
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
    public readonly DateTime _dataCriacao = DateTime.Now;
    public readonly Random _random = new Random();

    

    public TesteParaPopular()
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
    [DataRow(4)]
    [DataRow(5)]
    public async Task TestDisciplinaADD(int Ref)
    {
        //Criação das Disciplinas
        var disciplina = new Disciplina($"Disciplina {Ref}", TimeSpan.FromHours(Ref));
        disciplina.DataCriacao = _dataCriacao;
        await _disciplinaRepositorio.AdicionarAsync(disciplina);
        Assert.IsTrue(disciplina.Id > 0);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    [DataRow(5)]
    public async Task TestEnderecoADD(int Ref)
    {
        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        Assert.IsTrue(endereco.Id > 0);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    [DataRow(5)]
    public async Task TestDepartamentoADD(int Ref)
    {
        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        //Criação Dos Departamentos (Precisa de Criação de Endereços)
        var departamento = new Departamento($"Departamento {Ref}", endereco.Id);
        departamento.DataCriacao = _dataCriacao;
        await _departamentoRepositorio.AdicionarAsync(departamento);
        

        Assert.IsTrue(departamento.Id > 0);
    }

    [TestMethod]
    [DataRow(1, Turnos.Matutino)]
    [DataRow(2, Turnos.Noturno)]
    [DataRow(3, Turnos.Vespertino)]
    [DataRow(4, Turnos.Vespertino)]
    [DataRow(5, Turnos.Matutino)]
    public async Task TestCursoADD(int Ref, Turnos turno)
    {
        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        //Criação Dos Departamentos (Precisa de Endereços)
        var departamento = new Departamento($"Departamento {Ref}", endereco.Id);
        departamento.DataCriacao = _dataCriacao;
        await _departamentoRepositorio.AdicionarAsync(departamento);

        //Criação Dos Cursos (Precisa de Departamentos)
        var curso = new Curso($"Curso {Ref}", turno ,TimeSpan.FromHours(Ref), $"Tipo {Ref}", departamento.Id);
        curso.DataCriacao = _dataCriacao;
        await _cursoRepositorio.AdicionarAsync(curso);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    [DataRow(5)]
    
    public async Task TestProfessorADD(int Ref)
    {
        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        //Criação Dos Departamentos (Precisa de Endereços)
        var departamento = new Departamento($"Departamento {Ref}", endereco.Id);
        departamento.DataCriacao = _dataCriacao;
        await _departamentoRepositorio.AdicionarAsync(departamento);

        //Criação Dos Professores (Precisa de Endereços E Departamento)
        var professor = new Professor(_random.NextInt64(10000000000, 99999999999).ToString(), $"Pedro {Ref}",
                                                    _random.NextInt64(1000, 9999), DateTime.Now.AddDays(Ref),
                                                    DateTime.Now.AddMonths(Ref), endereco.Id, departamento.Id);
        professor.DataCriacao = _dataCriacao;
        await _professorRepositorio.AdicionarAsync(professor);

        Assert.IsTrue(professor.Id > 0);
    }
    [TestMethod]
    [DataRow(1, Turnos.Matutino)]
    [DataRow(2, Turnos.Noturno)]
    [DataRow(3, Turnos.Vespertino)]
    [DataRow(4, Turnos.Vespertino)]
    [DataRow(5, Turnos.Matutino)]
    public async Task TestAlunoADD(int Ref, Turnos turno)
    {
        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        //Criação Dos Departamentos (Precisa de Endereços)
        var departamento = new Departamento($"Departamento {Ref}", endereco.Id);
        departamento.DataCriacao = _dataCriacao;
        await _departamentoRepositorio.AdicionarAsync(departamento);

        //Criação Dos Cursos (Precisa de Departamentos)
        var curso = new Curso($"Curso {Ref}", turno ,TimeSpan.FromHours(Ref), $"Tipo {Ref}", departamento.Id);
        curso.DataCriacao = _dataCriacao;
        await _cursoRepositorio.AdicionarAsync(curso);

        //Criação Dos Alunos (Precisa de Endereco E Curso)
        var aluno = new Aluno((_random.Next(100000000, 999999999)), $"Aluno {Ref}",
                                     DateTime.Now.AddDays(Ref), endereco.Id, curso.Id);
        aluno.DataCriacao = _dataCriacao;
        await _alunoRepositorio.AdicionarAsync(aluno);

        Assert.IsTrue(aluno.Id > 0);
    }

    [TestMethod]
    [DataRow(1, Turnos.Matutino)]
    [DataRow(2, Turnos.Noturno)]
    [DataRow(3, Turnos.Vespertino)]
    [DataRow(4, Turnos.Vespertino)]
    [DataRow(5, Turnos.Matutino)]
    public async Task TestCursoDisciplinaADD(int Ref, Turnos turno)
    {
        
        //Criação das Disciplinas
        var disciplina = new Disciplina($"Disciplina {Ref}", TimeSpan.FromHours(Ref));
        disciplina.DataCriacao = _dataCriacao;
        await _disciplinaRepositorio.AdicionarAsync(disciplina);
        Assert.IsTrue(disciplina.Id > 0);

        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        //Criação Dos Departamentos (Precisa de Endereços)
        var departamento = new Departamento($"Departamento {Ref}", endereco.Id);
        departamento.DataCriacao = _dataCriacao;
        await _departamentoRepositorio.AdicionarAsync(departamento);

        //Criação Dos Cursos (Precisa de Departamentos)
        var curso = new Curso($"Curso {Ref}", turno ,TimeSpan.FromHours(Ref), $"Tipo {Ref}", departamento.Id);
        curso.DataCriacao = _dataCriacao;
        await _cursoRepositorio.AdicionarAsync(curso);

        //Criação de CursoDisciplina ( Precisa de Curso E Disciplina)
        var cursoDisciplina = new CursoDisciplina(curso.Id, disciplina.Id);
        cursoDisciplina.DataCriacao = _dataCriacao;
        await _cursoDisciplinaRepositorio.AdicionarAsync(cursoDisciplina);
        Assert.IsTrue(cursoDisciplina.Id > 0);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    [DataRow(5)]
    public async Task TestDependenteADD(int Ref)
    {
        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        //Criação Dos Departamentos (Precisa de Endereços)
        var departamento = new Departamento($"Departamento {Ref}", endereco.Id);
        departamento.DataCriacao = _dataCriacao;
        await _departamentoRepositorio.AdicionarAsync(departamento);

        //Criação Dos Professores (Precisa de Endereços E Departamento)
        var professor = new Professor(_random.NextInt64(10000000000, 99999999999).ToString(), $"Pedro {Ref}",
                                                    _random.NextInt64(1000, 9999), DateTime.Now.AddDays(Ref),
                                                    DateTime.Now.AddMonths(Ref), endereco.Id, departamento.Id);
        professor.DataCriacao = _dataCriacao;
        await _professorRepositorio.AdicionarAsync(professor);

        //Criação dos Dependentes ( Precisa de Professor)
        var dependente = new Dependente($"Cezar {Ref}", $"Relacionamento {Ref}", DateTime.Now.AddMonths(Ref), professor.Id);
        dependente.DataCriacao = _dataCriacao;
        await _dependenteRepositorio.AdicionarAsync(dependente);
        Assert.IsTrue(dependente.Id > 0);
    }
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    [DataRow(5)]
    public async Task TestTitulacaoADD(int Ref)
    {
        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        //Criação Dos Departamentos (Precisa de Endereços)
        var departamento = new Departamento($"Departamento {Ref}", endereco.Id);
        departamento.DataCriacao = _dataCriacao;
        await _departamentoRepositorio.AdicionarAsync(departamento);

        //Criação Dos Professores (Precisa de Endereços E Departamento)
        var professor = new Professor(_random.NextInt64(10000000000, 99999999999).ToString(), $"Pedro {Ref}",
                                                    _random.NextInt64(1000, 9999), DateTime.Now.AddDays(Ref),
                                                    DateTime.Now.AddMonths(Ref), endereco.Id, departamento.Id);
        professor.DataCriacao = _dataCriacao;
        await _professorRepositorio.AdicionarAsync(professor);

        //Criação das Titulaçoes (Precisa de Professor)
        var titulacao = new Titulacao($"Grau {Ref}", $"Curso {Ref}", $"Instituição {Ref}", professor.Id);
        titulacao.DataCriacao = _dataCriacao;
        await _titulacaoRepositorio.AdicionarAsync(titulacao);
        Assert.IsTrue(titulacao.Id > 0);
    }

    [TestMethod]
    [DataRow(1, Turnos.Matutino)]
    [DataRow(2, Turnos.Noturno)]
    [DataRow(3, Turnos.Vespertino)]
    [DataRow(4, Turnos.Vespertino)]
    [DataRow(5, Turnos.Matutino)]
    public async Task TestOfertaADD(int Ref, Turnos turno)
    {
        //Criação das Disciplinas
        var disciplina = new Disciplina($"Disciplina {Ref}", TimeSpan.FromHours(Ref));
        disciplina.DataCriacao = _dataCriacao;
        await _disciplinaRepositorio.AdicionarAsync(disciplina);
        Assert.IsTrue(disciplina.Id > 0);

        //Criação dos Endereços
        var endereco = new Endereco($"Rua {Ref}", $"Cidade {Ref}",$"Estado {Ref}", $"Complemento {Ref}");
        endereco.DataCriacao = _dataCriacao;
        await _enderecoRepositorio.AdicionarAsync(endereco);

        //Criação Dos Departamentos (Precisa de Endereços)
        var departamento = new Departamento($"Departamento {Ref}", endereco.Id);
        departamento.DataCriacao = _dataCriacao;
        await _departamentoRepositorio.AdicionarAsync(departamento);

        //Criação Dos Professores (Precisa de Endereços E Departamento)
        var professor = new Professor(_random.NextInt64(10000000000, 99999999999).ToString(), $"Pedro {Ref}",
                                                    _random.NextInt64(1000, 9999), DateTime.Now.AddDays(Ref),
                                                    DateTime.Now.AddMonths(Ref), endereco.Id, departamento.Id);
        professor.DataCriacao = _dataCriacao;
        await _professorRepositorio.AdicionarAsync(professor);

        //Criação Dos Cursos (Precisa de Departamentos)
        var curso = new Curso($"Curso {Ref}", turno ,TimeSpan.FromHours(Ref), $"Tipo {Ref}", departamento.Id);
        curso.DataCriacao = _dataCriacao;
        await _cursoRepositorio.AdicionarAsync(curso);

        //Criação Dos Alunos (Precisa de Endereco E Curso)
        var aluno = new Aluno((_random.Next(100000000, 999999999)), $"Aluno {Ref}",
                                     DateTime.Now.AddDays(Ref), endereco.Id, curso.Id);
        aluno.DataCriacao = _dataCriacao;
        await _alunoRepositorio.AdicionarAsync(aluno);

        //Criação Das Ofertas (Precisa de Aluno, Professor e Disciplina)
        var oferta = new Oferta($"{Ref+2000}", Ref, Ref+10, Ref+30, aluno.Id, professor.Id, disciplina.Id);
        oferta.DataCriacao = _dataCriacao;
        await _ofertaRepositorio.AdicionarAsync(oferta);
        Assert.IsTrue(oferta.Id > 0);
    }
}