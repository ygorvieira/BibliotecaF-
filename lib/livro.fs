namespace BibliotecaDeMidias

open System

/// Representa um livro com título, autor, ISBN, número de páginas, valor e categoria
type Livro(titulo: string, autor: string, numeroDePaginas: int, valor: float, categoria: string, ?isbn: string, ?desconto: float) =
    inherit Midia(titulo, valor = valor, desconto = defaultArg desconto Midia.DescontoPadrao, categoria = Some categoria)

    // Valores padrão
    static let ISBN_PADRAO = "1"

    // Validações
    do
        if numeroDePaginas <= 0 then
            invalidArg "numeroDePaginas" "O número de páginas deve ser maior que zero"
        if valor <= 0.0 then
            invalidArg "valor" "O valor deve ser maior que zero"

    // Propriedades
    member this.Autor = autor
    member this.ISBN = defaultArg isbn ISBN_PADRAO
    member this.NumeroDePaginas = numeroDePaginas