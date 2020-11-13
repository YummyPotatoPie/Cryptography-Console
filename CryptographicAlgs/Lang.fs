namespace CryptographicAlgs

[<Struct>]
type public Lang = 
    struct     
        static member En = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray()

        static member IndexOf(x: char) = 
            let mutable index: int = -1
            for i in [0 .. Lang.En.Length - 1] do
                if Lang.En.[i] = x then index <- i
            index
    end
