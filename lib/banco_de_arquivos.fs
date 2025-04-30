namespace BibliotecaDeMidias

open System
open System.IO
open System.Text.Json

/// Representa um banco de arquivos para salvar e carregar mídias
type BancoDeArquivos() =

    // Caminho do diretório onde os arquivos serão salvos
    let dbPath = "db"

    /// Salva uma mídia no arquivo correspondente
    member this.Salva<'T>(midia: 'T) =
        if isNull (box midia) then
            () // Não salva objetos nulos
        else
            // Garante que o diretório 'db' existe
            Directory.CreateDirectory(dbPath) |> ignore

            // Define o caminho do arquivo com base no tipo da mídia
            let filePath = Path.Combine(dbPath, $"{typeof<'T>.Name.ToLower()}s.json")

            // Serializa e salva a mídia no arquivo
            let json = JsonSerializer.Serialize(midia)
            File.AppendAllText(filePath, json + Environment.NewLine)

    /// Carrega todas as mídias do arquivo
    member this.Carrega<'T>() : 'T list =
        let filePath = Path.Combine(dbPath, $"{typeof<'T>.Name.ToLower()}s.json")
        if not (File.Exists(filePath)) then
            [] // Retorna uma lista vazia se o arquivo não existir
        else
            // Lê e desserializa as mídias do arquivo
            File.ReadAllLines(filePath)
            |> Array.map (fun line -> JsonSerializer.Deserialize<'T>(line))
            |> Array.toList