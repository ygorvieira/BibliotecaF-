namespace Tests

open NUnit.Framework
open System
open BibliotecaDeMidias

[<TestFixture>]
type LivroTests() =

    [<Test>]
    member _.``Criar Livro válido deve definir propriedades corretamente`` () =
        let livro = Livro("Dom Casmurro", "Machado de Assis", 200, 39.9, "Romance", isbn = "1234567890")
        Assert.AreEqual("Machado de Assis", livro.Autor)
        Assert.AreEqual("1234567890", livro.ISBN)
        Assert.AreEqual(200, livro.NumeroDePaginas)

    [<Test>]
    member _.``Criar Livro sem ISBN deve usar valor padrão`` () =
        let livro = Livro("Dom Casmurro", "Machado de Assis", 200, 39.9, "Romance")
        Assert.AreEqual("1", livro.ISBN)

    [<Test>]
    member _.``Criar Livro com numeroDePaginas zero deve lançar exceção`` () =
        let ex = Assert.Throws<ArgumentException>(fun () ->
            Livro("Dom Casmurro", "Machado de Assis", 0, 39.9, "Romance") |> ignore)
        Assert.That(ex.Message, Does.Contain("numeroDePaginas"))

    [<Test>]
    member _.``Criar Livro com valor zero deve lançar exceção`` () =
        let ex = Assert.Throws<ArgumentException>(fun () ->
            Livro("Dom Casmurro", "Machado de Assis", 200, 0.0, "Romance") |> ignore)
        Assert.That(ex.Message, Does.Contain("valor"))
