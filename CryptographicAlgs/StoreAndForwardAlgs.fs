namespace CryptographicAlgs

module SAF =
    
    let YuPieEncrypt (input: string) = 
        let mutable result: string  = ""
        for i in [0 .. input.Length - 1] do
            let number: int = 2 <<< int input.[i]
            result <- result + string number + " "
        result
