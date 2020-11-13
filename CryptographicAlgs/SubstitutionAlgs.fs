namespace CryptographicAlgs

module SubstitutionAlgs =

    let Caesar (input: string) (key: int) =
        let mutable result: string = ""
        for i in [0 .. input.Length - 1] do
            let index: int = Lang.IndexOf(input.[i])
            if index = -1 then result <- result + string input.[i]
            else result <- result + string Lang.En.[(index + key) % Lang.En.Length]
        result

    let ROT13 (input: string) = Caesar input 13

