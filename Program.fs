open BibliotecaDeMidias

let livro = Livro(
    titulo = "Programação em F#",
    autor = "João Silva",
    isbn = "12345",
    numeroDePaginas = 300,
    valor = 50.0,
    categoria = "Programação",
    desconto = 0.1
)

printfn "Título: %s" livro.Titulo
printfn "Autor: %s" livro.Autor
printfn "ISBN: %s" livro.ISBN
printfn "Número de Páginas: %d" livro.NumeroDePaginas
printfn "Valor com Desconto: %.2f" (livro.ValorComDesconto())

//Midia
// [<EntryPoint>]
// let main argv =
//     let midia = new Midia("Livro", ?valor = Some 50.0, ?desconto = Some 0.2)
//     printfn "Título: %s, Valor com desconto: %.2f" midia.Titulo (midia.ValorComDesconto())
//     0
