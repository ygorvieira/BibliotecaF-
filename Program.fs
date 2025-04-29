open BibliotecaDeMidias

[<EntryPoint>]
let main argv =
    let midia = new Midia("Livro", ?valor = Some 50.0, ?desconto = Some 0.2)
    printfn "Título: %s, Valor com desconto: %.2f" midia.Titulo (midia.ValorComDesconto())
    0
