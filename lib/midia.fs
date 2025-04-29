namespace BibliotecaDeMidias

/// Representa uma mídia com título, valor, desconto e categoria
type Midia(titulo: string, ?valor: float, ?desconto: float, ?categoria: string option) =
    // Valores padrão
    static let VALOR_PADRAO = 10.0
    static let DESCONTO_PADRAO = 0.1

    // Valida os parâmetros de entrada
    do
        let valorReal = defaultArg valor VALOR_PADRAO
        let descontoReal = defaultArg desconto DESCONTO_PADRAO

        if valorReal <= 0.0 then
            invalidArg "valor" "O valor deve ser maior que zero"
        if descontoReal < 0.0 || descontoReal > 1.0 then
            invalidArg "desconto" "O desconto deve estar entre 0 e 1"

    // Propriedades
    member this.Titulo = titulo 
    member this.Valor = defaultArg valor VALOR_PADRAO 
    member this.Desconto = defaultArg desconto DESCONTO_PADRAO 
    member this.Categoria = categoria 

    /// Retorna o valor da mídia com o desconto aplicado
    member this.ValorComDesconto() : float =
        this.Valor * (1.0 - this.Desconto)